using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading;
using System.Web.Mvc;


namespace OlgasTestTask.Controllers
{
    public class HomeController : Controller
    {
       static int[,] localArray;
        public ActionResult Index(string id)
        {
            int m = 3;
           if(localArray==null)
            localArray = new int[m, m];
          
            if (id == null) {
                return View();
            }
            if (id.Contains("GenerateRandomMatrix"))
            {
               Core.Core.GenerateMatrix(localArray);
            }
            else if (id.Contains("TraverseMatrix"))
            {
                localArray = Core.Core.RotateMatrixClockwise(localArray);
                
            }
            else if (id.Contains("ExportMatrix"))
            {
                Core.Core.SaveArrayAsCSV(localArray, "FileForMatrixImport.csv", "D:\\");
            }
            else if (id.Contains("UploadFromCSV"))
            {  
                UploadFromCSVCOntroller("C:\\Program Files (x86)\\IIS Express\\", "FileForMatrixImport.csv");
            }
            


            
            return View(new OlgasTestTask.Models.Grid() { Array= localArray });
        }
        
      
            
 
    public ActionResult UploadFromCSVCOntroller(string path, string fileName)
    {
            
        if (!Core.Core.CheckIfFileExists(path))
        {
            Core.Core.CreateAndWriteCsvFile(path);
        };
          Core.Core.ReadCSVFile(fileName);
            
            return View();
    
    }


    public ActionResult About()
        {
            ViewBag.Message = "Olgas Action Test";

            return View();
        }
       

        public ActionResult UploadFromCSV()
        {
            ViewBag.Message = "Olgas Action Test";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

    }
}