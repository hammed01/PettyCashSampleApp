using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PettyCashApp.Models
{
    public class PettyRequest
    {
    
       public string  RequestName { get; set; }
        public string EmployeeId { get; set; }
        public string RequestId { get; set; }
        public string RequestEmail { get; set; }
        public int TelephoneNumber { get; set; }
        public string Department { get; set; }
        public string EmployeeID { get; set; }
        public int Amount { get; set; }
        public string ReasonForRequest { get; set; }
        public DateTime Requestdate { get; set; }
        public string ActionMessage;
        public bool ActionStatus;
        public string LineManagerName { get; set; }
        public string LineManagerEmail { get; set; }
    }
}