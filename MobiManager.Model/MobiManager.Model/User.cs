﻿using System;

namespace MobiManager.Model
{
    public class User
    {
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; }
        public string Location { get; set; }
    }
}
