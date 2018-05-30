using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Log_Files
{
    public class Cluster
    {
        public LogFile MainLog { get; set; }
        public List<LogFile> MatchedLogs { get; set; }

        public Cluster()
        {
            MatchedLogs = new List<LogFile>();
            MainLog = new LogFile();
        }
    }
    
}
