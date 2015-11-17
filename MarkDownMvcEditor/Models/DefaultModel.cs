using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkDownMvcEditor.Models
{
    public class DefaultModel
    {
        [AllowHtml]
        public string PostMarkdown { get; set; }
    }
}