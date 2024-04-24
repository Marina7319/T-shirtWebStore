using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TshirtWeb.Areas.Customer.Email
{
    public class EmailSend : TagHelper
    {
        public string Address {  get; set; }

        public string Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
        }

    }
}
