using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core
{
    public abstract class Person : AuditableEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // A computed property to make displaying the name easy later
        public string FullName => $"{FirstName} {LastName}";
    }
}
