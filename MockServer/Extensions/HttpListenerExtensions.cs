using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    public static class HttpListenerExtensions
    {
        public static void ResponseObjectToJson<T>(this HttpListenerResponse response, HttpStatusCode statusCode, string contenType, string encoding, T respondeModel)
        {
            var responseString = JsonConvert.SerializeObject(respondeModel);
            response.ResponseJson(statusCode, contenType, encoding, responseString);
        }

        public static void ResponseJson(this HttpListenerResponse response, HttpStatusCode statusCode, string contenType, string encoding, string responseString)
        {
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            response.StatusCode = statusCode.GetHashCode();
            response.ContentEncoding = string.IsNullOrWhiteSpace(encoding) ? Encoding.UTF8 : Encoding.GetEncoding(encoding);
            response.ContentType = string.IsNullOrWhiteSpace(contenType) ? "text/json" : contenType;
            response.ContentLength64 = buffer.Length;
            using (var output = response.OutputStream)
            {
                output.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
