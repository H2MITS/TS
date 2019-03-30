using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.ViewModel
{
    public class SheetMasterVM
    {
        public long rowNo { get; set; }
        public long sheetId { get; set; }
        public string sheetName { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> totalRate { get; set; }
        public Nullable<decimal> profitMargin { get; set; }
        public Nullable<decimal> gstPer { get; set; }
        public Nullable<decimal> gstAmt { get; set; }
        public Nullable<decimal> totalAmt { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> cDate { get; set; }
        public Nullable<System.DateTime> uDate { get; set; }
    }
}
