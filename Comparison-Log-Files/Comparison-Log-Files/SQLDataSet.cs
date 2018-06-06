using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Log_Files
{
    public class SQLDataSet
    {
        public int MaxLogs { get; set; }
        public int NumOfDays { get; set; }
        public string ScrNarrative { get; set; }
        public int? CustID { get; set; }
        public int MaxLInes { get; set; }
        public string  OutPutFileName { get; set; }
    }
}
