using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userGroupID { get; set; }
        public bool isDeleted { get; set; }
    }
}
