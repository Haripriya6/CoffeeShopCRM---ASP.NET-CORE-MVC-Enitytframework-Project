using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS_CustomerInfo_Module.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }
        [Required]
        public string Cust_FirstName { get; set; }
        public string Cust_LastName { get; set; }
        public string Cust_Addr1 { get; set; }
        public string Cust_Addr2 { get; set; }
        public string Cust_City { get; set; }
        public string Cust_Country { get; set; }
        [Required]
        public string Cust_ContactNumber { get; set; }
        public string Cust_ProvinceState { get; set; }
        public string Cust_Email { get; set; }
        public string Cust_Website { get; set; }
        [Required]
        public int Cust_ZipPostalCode { get; set; }

        //public List<Country> Country { get; set; }

        //public List<State> State { get; set; }

        //public List<City> City { get; set; }


    }
}
