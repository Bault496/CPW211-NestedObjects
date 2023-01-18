using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represetns a individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The legal First Name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The legal Last Name
        /// </summary>
        public string LastName { get; set; } 
        /// <summary>
        /// The assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// Student's Cell Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Studnet's Assigned Advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }

    }
}
