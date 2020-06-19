using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagHelperDemo.CustomHelpers
{
    [HtmlTargetElement("hello-world")]
    public class HelloTagHelper : TagHelper
    {
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "author-name";
            output.TagMode = TagMode.StartTagAndEndTag;

            var strSb = new StringBuilder();
            strSb.AppendFormat("<span>Hello! My Name is {0}</span>", this.Name);

            output.PreContent.SetHtmlContent(strSb.ToString());
        }

    }
}
