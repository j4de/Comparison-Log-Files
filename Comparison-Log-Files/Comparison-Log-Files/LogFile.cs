using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Comparison_Log_Files
{
    public class LogFile
    {
        public string ProblemID { get; set; }
        public string Signature { get; set; }
        public int LDvalue { get; set; }
        public int NumOfLines { get; set; }
        public string CustomerID { get; set; }
        public string Version { get; set; }
        public string Narrative { get; set; }
        public LogFile()
        {

        }
    }
}
