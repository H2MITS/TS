using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.ViewModel
{
   public class SheetDetailsVM
    {
        public long rowNo { get; set; }
        public long sheetDetailsId { get; set; }
        public Nullable<long> sheetId { get; set; }
        public Nullable<long> pId { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> weight { get; set; }

        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> amt { get; set; }
        public Nullable<System.DateTime> cDate { get; set; }
        public Nullable<System.DateTime> uDate { get; set; }
    }
}
