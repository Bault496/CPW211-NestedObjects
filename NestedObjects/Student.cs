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
        /// the date of birth of the Student
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Student's preferred contact number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Student's Assigned Advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }

    }
}
