using System;
using System.Collections.Generic;

namespace Service.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> Sex { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Remark { get; set; }
    }
}
