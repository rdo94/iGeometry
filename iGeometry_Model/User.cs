using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGeometry_Model
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }

        override public string ToString()
        {
            return string.Format("User: {0} \n Password: {1}", Email, Password);
        }

    }
}
