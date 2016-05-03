using System;
using System.Collections.Generic;

namespace Service.Models
{
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Discribe { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
    }
}
