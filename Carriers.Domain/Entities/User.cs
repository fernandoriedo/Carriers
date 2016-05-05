using System;
using System.Collections.Generic;

namespace Carriers.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateRegister { get; set; }

        public virtual IEnumerable<Rating> Ratings { get; set; }

    }
}
