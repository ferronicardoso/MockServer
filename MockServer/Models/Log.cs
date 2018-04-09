using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockServer.Models
{
    public class Log
    {
        [BsonId]
        public int IdLog { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Ip { get; set; }
        public string Verb { get; set; }
        public string Path { get; set; }
        public int ResponseStatus { get; set; }
        public string HttpVersion { get; set; }
        public string UserAgent { get; set; }
    }
}
