using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockServer.Enums
{
    public enum ContentType
    {
        [Description("appliction/json")]
        ApplicationJson = 0,
        [Description("appliction/xml")]
        ApplicationXml = 1,
        [Description("text/json")]
        TextJson = 2,
        [Description("text/xml")]
        TextXml = 3,
        [Description("text/plain")]
        TextPlain = 4,
    }
}
