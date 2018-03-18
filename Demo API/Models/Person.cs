using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_API.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
     
        /// <summary>
        /// the user's first name
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// The user's last name
        /// </summary>
       
        public string LastName { get; set; } = "";
        /// <summary>
        /// The ID from SQL of the user
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// the person's age
        /// </summary>
        public int Age { get; set; } = 0;

    }
}