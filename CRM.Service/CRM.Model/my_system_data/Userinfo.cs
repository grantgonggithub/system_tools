using System;
using System.Collections.Generic;

namespace CRM.Model
{
    public partial class Userinfo
    {
        public int Id { get; set; }
        public string Tel { get; set; }
        public string PassWord { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Ip { get; set; }
        public string DeviceInfo { get; set; }
        public string DeviceNo { get; set; }
    }
}
