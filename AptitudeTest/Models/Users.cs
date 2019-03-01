using System;
using System.Collections.Generic;

namespace AptitudeTest.Models
{
    public partial class Users
    {
        public Users()
        {
            Question = new HashSet<Question>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        

        public virtual ICollection<Question> Question { get; set; }
    }
}
