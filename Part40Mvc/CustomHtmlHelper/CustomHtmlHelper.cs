using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part40Mvc.CustomHtmlHelper
{
    public static class CustomHtmlHelper
    {
        public static IHtmlString Image(this HtmlHelper helper,string src, string alt)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            tag.Attributes.Add("alt", alt);
            return new MvcHtmlString(tag.ToString(TagRenderMode.SelfClosing));
        }
    }
}