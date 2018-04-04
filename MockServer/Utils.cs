using MockServer.Enums;
using MockServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MockServer
{
    public static class Utils
    {
        public static bool IsMatch(string patternUrl, string url)
        {
            var pattern = "^(" + patternUrl + "(\\/?))$";
            var regex = new Regex(pattern);
            return regex.IsMatch(url);
        }

        public static List<SelectListItem> GetContentTypeList()
        {
            var result = Enum.GetValues(typeof(ContentType))
                             .Cast<ContentType>()
                             .Select(s => new SelectListItem()
                             {
                                 Text = s.GetDescription(),
                                 Value = s.GetDescription()
                             })
                             .ToList();
            return result;
        }

        public static List<SelectListItem> GetVerbList()
        {
            var result = Enum.GetValues(typeof(VerbType))
                             .Cast<VerbType>()
                             .Select(s => new SelectListItem()
                             {
                                 Text = s.GetDescription(),
                                 Value = s.GetDescription()
                             })
                             .ToList();
            return result;
        }

        public static List<SelectListItem> GetResponseStatusList()
        {
            var result = Enum.GetValues(typeof(ResponseStatusType))
                             .Cast<ResponseStatusType>()
                             .Select(s => new SelectListItem()
                             {
                                 Text = string.Format("{0} - {1}", (int)s, s.GetDescription()),
                                 Value = ((int)s).ToString()
                             })
                             .ToList();
            return result;
        }
    }
}
