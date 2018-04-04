using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace System
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum enumeration)
        {
            var memberInfo = enumeration.GetType().GetMember(Enum.GetName(enumeration.GetType(), enumeration));
            var attribute = (DescriptionAttribute)memberInfo[0].GetCustomAttribute(typeof(DescriptionAttribute), false);
            string description = attribute.Description;

            return description;
        }


    }
}
