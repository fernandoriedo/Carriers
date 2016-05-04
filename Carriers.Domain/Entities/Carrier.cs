
using System;
using System.Collections.Generic;

namespace Carriers.Domain.Entities
{
    public class Carrier
    {
        public int CarrierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }

        public virtual IEnumerable<Rating> Ratings { get; set; }
    }
}
