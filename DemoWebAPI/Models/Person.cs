﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from Sql
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// User's first name
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// User's last name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}