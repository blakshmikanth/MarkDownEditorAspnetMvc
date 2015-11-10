using MarkDownMvcEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkDownMvcEditor.Controllers
{
    public class HomeController : Controller
    {

        /* 
 * For the purposes of this sample project, the user editable markdown page content is saved 
 * here in a static variable.  
 * 
 * In the real world don't do this... save your stuff to a db or whatever.
 */
        static string m_Content =
@"# Edit this text to see the live changes

This demo project shows how to use MarkdownDeep in a typical ASP.NET MVC application.

* Click the *Edit this Page* link below to make changes to this page with MarkdownDeep's editor
* Use the links in the top right for more info.

> Demo code sample. [Highlight.js](https://highlightjs.org/) is used for code highlighting.

```
public ActionResult Index(DefaultModel model)
{
    if(model == null)
    {
        model = new DefaultModel();
        model.PostMarkdown = ""##Sample test""
    }
    var md = new MarkdownDeep.Markdown();
    
    md.ExtraMode = true;
    md.SafeMode = true;

    string output = md.Transform(model.PostMarkdown);
    ViewBag.Content = output;
    return View(model);
}
```
>Image sample 

![alt](http://i.stack.imgur.com/eZDLA.png)
";

        public ActionResult Index(DefaultModel model)
        {
            if(model == null || string.IsNullOrWhiteSpace(model.PostMarkdown))
            {
                model = new DefaultModel();
                model.PostMarkdown = m_Content;
            }
			else
			{
				var md = new MarkdownDeep.Markdown();
            
				md.ExtraMode = true;
				md.SafeMode = true;

				string output = md.Transform(model.PostMarkdown);
				ViewBag.Content = output;
			
				ViewBag.Saved = true;
			}
           
			// save the content to db or any other persistence
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyPostAction()
        {
            return View();
        }
    }
}