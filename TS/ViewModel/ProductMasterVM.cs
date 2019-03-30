using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.ViewModel
{
    public class ProductMasterVM
    {
        public int rowNo { get; set; }
        public long id { get; set; }
        public string p_Name { get; set; }
        public string rate { get; set; }
        public Nullable<System.DateTime> cDate { get; set; }
        public Nullable<System.DateTime> uDate { get; set; }

    }
}
