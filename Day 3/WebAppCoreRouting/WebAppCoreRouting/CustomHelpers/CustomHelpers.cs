using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreRouting.CustomHelpers
{
    public static class CustomHelpers
    {
        public static IHtmlContent SubmitButton(this IHtmlHelper htmlHelper, string name, string value)
        {
            string str = "<input type='submit' name='" + name + "' value='" + value + "'/>";
            return new HtmlString(str);
        }

        public static string StrSubmitButton(this IHtmlHelper htmlHelper, string name, string value)
        {
           return "<input type='submit' name='" + name + "' value='" + value + "'/>";
        }
    }
}
