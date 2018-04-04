using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MockServer.Enums
{
    public enum VerbType
    {
        [Description("GET")]
        GET = 0,
        [Description("POST")]
        POST = 1,
        [Description("PUT")]
        PUT = 2,
        [Description("PATCH")]
        PATCH = 3,
        [Description("DELETE")]
        DELETE = 4,
        [Description("OPTIONS")]
        OPTIONS = 5
    }
}