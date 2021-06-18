using System;
using System.Collections.Generic;

namespace CRM.Model
{
    public partial class Verificationcode
    {
        public int Id { get; set; }
        public string Tel { get; set; }
        public string VerificationCode1 { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
