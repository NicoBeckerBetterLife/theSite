using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ParishUserModel
    {
        public int ID { get; set; }
        public int parishID { get; set; }
        public int userID { get; set; }
        public bool isDeleted { get; set; }
    }
}
