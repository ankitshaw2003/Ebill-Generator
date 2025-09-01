using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebill.Models;

namespace Ebill.Repository
{
    interface IData
    {
        void SaveBillDetails(BillDetail details);
    }
}
