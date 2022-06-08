using u19239752_HW03.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace u19239752_HW03.Controllers
{
    public class HomeController : Controller
    {

        
        [HttpGet]
        public ActionResult Index()
        {
           
            
            return View();
        }


        // gets  the file 
        [HttpPost]
        public ActionResult Index(string FileType, HttpPostedFileBase file)
        {                     
            
               
            // does a check  file is upload
            if (  file != null)
            {
                string extension = Path.GetExtension(file.FileName);
                

                
                if( FileType == "Image")
                {
                    // Save Image 
                    file.SaveAs(Path.Combine(HttpContext.Server.MapPath("~/Media/Images"), Path.GetFileName(file.FileName)));
                    ViewBag.Message = "File uploaded";
                } 
                else if( FileType == "Video")
                {
                    // Save video 
                    file.SaveAs(Path.Combine(HttpContext.Server.MapPath("~/Media/Videos"), Path.GetFileName(file.FileName)));
                    ViewBag.Message = "File uploaded";
                }
                else if(FileType == "Document")
                {
                    // Save Document 
                    file.SaveAs(Path.Combine(HttpContext.Server.MapPath("~/Media/Documents"), Path.GetFileName(file.FileName)));
                    ViewBag.Message = "File uploaded";
                }
            }
            else
            {
                ViewBag.Message = "Plese Select a file:";
             
            }
            // redirect the user


            return View();
        }

        public ActionResult About()
        {
            return View();
        }



    }
}