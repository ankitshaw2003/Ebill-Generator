using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebill.Models
{
    public class BillList
    {
        public List<tbl_BillDetails> BillDetails { get; set; }
        public List<tbl_BillItems> BillItems { get; set; }
    }
}