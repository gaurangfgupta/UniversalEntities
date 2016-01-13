using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities
{
    interface IBankAccount
    {
        string BankName { get; set; }
        string AccountNumber { get; set; }
        string IFSC { get; set; }
        string MICR { get; set; }
        string Branch { get; set; }
    }
}
