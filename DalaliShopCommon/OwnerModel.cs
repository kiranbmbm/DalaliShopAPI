using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalaliShopCommon
{
    public class OwnerModel
    {
        public int UsedId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string EmailAdress { get; set; }
        public int MobileNumber { get; set; }
        public string PermanantAdress { get; set; }
        public string Place { get; set; }
        public string Taluq { get; set; }
        public string District { get; set; }
        public int Pincode { get; set; }
        public string FingerPrint { get; set; }
        public bool Active { get; set; }
    }
}
