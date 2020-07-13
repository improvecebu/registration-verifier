using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationVerifier.Models
{
    public class Citizen
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Name
    {
        public string Last { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }

        public override string ToString()
        {
            return $"{Last}, {First} {Middle}";
        }
    }
}
