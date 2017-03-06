using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ExpenditureModel
    {
        public int ID { get; set; }
        public int parishUserID { get; set; }
        public decimal amount { get; set; }
        public int expenseTypeID { get; set; }
        public System.DateTime expenseDate { get; set; }
        public System.DateTime dateSubmitted { get; set; }
    }
}
