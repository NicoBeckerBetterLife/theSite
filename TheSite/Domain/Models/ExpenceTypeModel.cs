using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ExpenseTypeModel
    {
        public int ID { get; set; }
        public string description { get; set; }
        public bool isDeleted { get; set; }
    }
}
