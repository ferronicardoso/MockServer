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

namespace MockServer
{
    // https://msdn.microsoft.com/pt-br/library/system.net.httplistener(v=vs.110).aspx
    public class Server
    {
        private RestMockRepository restMockRepository;
        private HttpListener listener;
        private HttpListenerContext context;
        private int Port = 80;
        
        public Server(int port)
        {
            this.Port = port;

            this.listener = new HttpListener();
            this.listener.Prefixes.Clear();
            this.listener.Prefixes.Add($"http://*:{this.Port}/");

            restMockRepository = new RestMockRepository();
        }
                
        public void Start()
        {
            listener.Start();

            for (; ; )
            {
                this.context = listener.GetContext();
                ResponseContext();
            }
        }

        public void Stop()
        {

        }

        private void ResponseContext()
        {
            var url = this.context.Request.Url;
            var method = this.context.Request.HttpMethod;
            var mock = this.restMockRepository.GetMatch(url.AbsolutePath, method);
            
            if (mock != null)
            {
                var bodyModel = JsonConvert.DeserializeObject(mock.ResponseBody);
                Thread.Sleep(new TimeSpan(0, 0, mock.ResponseDelay));

                context.Response.ContentType = mock.ContentType;
                context.Response.ContentEncoding = Encoding.GetEncoding(mock.ContentEncoding);
                context.Response.ResponseObjectToJson(HttpStatusCode.OK, mock.ContentType, mock.ContentEncoding, bodyModel);
            }
            else
            {
                var error = new
                {
                    message = $"No HTTP resource was found that matches the request URI '{url.OriginalString}'."
                };

                context.Response.ResponseObjectToJson(HttpStatusCode.NotFound, ContentType.TextJson.GetDescription(), "UTF-8", error);
            }
        }
    }
}
