namespace SortedNameApplication.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using Microsoft.VisualBasic;
    class WriteLog
    {
        public void SaveLog(string oPath, string iText)
        {
            try
            {
                FileStream fileStream = File.Open(oPath, FileMode.Append, FileAccess.Write);
                StreamWriter fileWriter = new StreamWriter(fileStream);
                fileWriter.WriteLine(iText);
                fileWriter.Close();
            }

            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }

        }
    }
}
