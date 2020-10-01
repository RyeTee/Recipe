﻿using Recipe.Web.Data.Enums;
using System;

namespace Recipe.Web.Data
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public UserType UserType { get; set; }

        public int FailedLoginAttempts { get; set; }
        public bool IsLocked { get; set; }
        public string SecurityQuestion1 { get; set; }
        public string SecurityQuestion2 { get; set; }
        public string SecurityAnswer1 { get; set; }
        public string SecurityAnswer2 { get; set; }
    }
}
