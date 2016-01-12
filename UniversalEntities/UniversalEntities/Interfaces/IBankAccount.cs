using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities.Interfaces
{
    interface IBankAccount
    {
        /// <summary>
        /// The name of the bank
        /// </summary>
        string BankName { get; set; }
        /// <summary>
        /// The bank account number (not the Customer ID)
        /// </summary>
        string AccountNumber { get; set; }
        /// <summary>
        /// Minimum 11 characters (info to implement validation)
        /// </summary>
        string IFSC { get; set; }
        string MICR { get; set; }
        string Branch { get; set; }
    }
}
