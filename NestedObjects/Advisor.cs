using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a college advisor
/// </summary>
namespace NestedObjects
{
    public class Advisor
    {
        /// <summary>
        /// The legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// the advisors work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number of office
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
