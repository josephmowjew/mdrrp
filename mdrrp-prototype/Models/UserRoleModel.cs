﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mdrrp_prototype.Models
{
    public class UserRoleModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}