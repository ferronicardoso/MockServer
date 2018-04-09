using MockServer.Enums;
using MockServer.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MockServer
{
    // https://msdn.microsoft.com/pt-br/library/system.net.httplistener(v=vs.110).aspx
    public class Server
    {
        private RestMockRepository restMockRepository;
        private LogRepository logRepository;
        private HttpListener listener;
        private int Port = 3000;
        private string Url;

        public delegate void ServerStartedEventHandler(string message, string url);
        public delegate void ServerStoppedEventHandler(string message);
        public event ServerStartedEventHandler Server_Started;
        public event ServerStoppedEventHandler Server_Stopped;

        public Server(int port)
        {
            this.Port = port;
            this.Url = $"http://*:{this.Port}/";

            this.listener = new HttpListener();
            this.listener.Prefixes.Add(this.Url);

            restMockRepository = new RestMockRepository();
            logRepository = new LogRepository();
        }
                
        public void Start()
        {
            if (!listener.IsListening)
            {
                listener.Start();

                Task.Factory.StartNew(async () =>
                {
                    while (true)
                    {
                        await ResponseContext(listener);
                    }
                }, TaskCreationOptions.LongRunning);

                if (Server_Started != null)
                    Server_Started("Server started", this.Url);
            }
        }

        public void Stop()
        {
            if (listener.IsListening)
            {
                listener.Stop();
                if (Server_Stopped != null)
                    Server_Stopped("Server stopped");
            }
        }

        private async Task ResponseContext(HttpListener listener)
        {
            var context = await listener.GetContextAsync();
            var url = context.Request.Url;
            var method = context.Request.HttpMethod;
            var mock = this.restMockRepository.GetMatch(url.AbsolutePath, method);
            var responseStatus = HttpStatusCode.NotFound;
            
            if (mock != null)
            {
                responseStatus = HttpStatusCode.OK;
                var bodyModel = JsonConvert.DeserializeObject(mock.ResponseBody);
                Thread.Sleep(new TimeSpan(0, 0, mock.ResponseDelay));

                context.Response.ContentType = mock.ContentType;
                context.Response.ContentEncoding = Encoding.GetEncoding(mock.ContentEncoding);
                context.Response.ResponseObjectToJson(responseStatus, mock.ContentType, mock.ContentEncoding, bodyModel);
            }
            else
            {
                var error = new
                {
                    message = $"No HTTP resource was found that matches the request URI '{url.OriginalString}'."
                };

                context.Response.ResponseObjectToJson(responseStatus, ContentType.TextJson.GetDescription(), "UTF-8", error);
            }
            var logModel = new Models.Log
            {
                DateAndTime = DateTime.Now,
                Ip = context.Request.RemoteEndPoint.ToString(),
                HttpVersion = string.Format($"HTTP/{context.Request.ProtocolVersion.ToString()}"),
                Path = url.AbsolutePath,
                Verb = method,
                ResponseStatus = responseStatus.GetHashCode(),
                UserAgent = context.Request.UserAgent
            };
            logRepository.Add(logModel);
        }
    }
}
