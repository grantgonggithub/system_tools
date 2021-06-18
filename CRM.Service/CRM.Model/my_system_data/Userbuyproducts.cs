using System;
using System.Collections.Generic;

namespace CRM.Model
{
    public partial class Userbuyproducts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductPrice { get; set; }
        public string PaySeqNo { get; set; }
        public int PayStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpiresDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
