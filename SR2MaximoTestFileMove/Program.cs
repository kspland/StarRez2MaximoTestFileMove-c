using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Xml;
using System.IO;

namespace SR2MaximoTestFileMove
{
    class Program
    {
        static void Main(string[] args)
        {

            /* This program renames and moves the StarRez Maintenance file that has been exported
             * It renames the file and moves it to a folder for archived Maintenance files
             * 
             * 
             */

            //This is the file path of the data file
            string file_name = @"\\ServerName\$SRuea\Maintenance\Maximo-" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            string file_name2 = @"\\ServerName\$SRuea\Maintenance\Maximo-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_.txt";

           
            // Move file to temp location
            File.Move(file_name, file_name2);

            //Delete orginal file
            File.Delete(file_name);


            string FileName = Path.GetFileName(file_name2);


             string sourcePath = @"\\ServerName\$SRuea\Maintenance";

             string targetPath = @"\\Servername\$SRuea\Maintenance\Archive";

             string sourceFile = System.IO.Path.Combine(sourcePath,FileName);
             string destFile = System.IO.Path.Combine(targetPath, FileName);



            // System.IO.File.Copy(sourceFile, destFile, true);
             System.IO.File.Move(sourceFile, destFile);

        }
    }
}
