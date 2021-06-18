using System;
using System.Collections.Generic;

namespace CRM.Model
{
    public partial class Userloginlog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoginDate { get; set; }
        public string Ip { get; set; }
        public string DeviceInfo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
