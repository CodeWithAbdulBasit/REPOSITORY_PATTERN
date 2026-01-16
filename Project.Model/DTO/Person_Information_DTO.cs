using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model.DTO
{
    public class Person_Information_DTO
    {
        public int PI_Auto_ID { get; set; }
        public string PI_First_Name { get; set; }
        public string PI_Last_Name { get; set; }
        public string PI_Father_Name { get; set; }
        public string PI_CNIC { get; set; }
        public string PI_Gender { get; set; }
        public Nullable<System.DateTime> PI_Date_Of_Birth { get; set; }
        public string PI_Phone_Number { get; set; }
        public string PI_Email { get; set; }
        public string PI_Address { get; set; }
        public string PI_City { get; set; }
        public string PI_Country { get; set; }
        public bool PI_IsActive { get; set; }
        public System.DateTime PI_Created_Date { get; set; }
        public int PI_Created_UserID { get; set; }
        public Nullable<System.DateTime> PI_Edit_Date { get; set; }
        public Nullable<int> PI_Edit_UserID { get; set; }
    }
}
