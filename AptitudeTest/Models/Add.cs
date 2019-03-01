using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptitudeTest.Models
{
    public partial class Add
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public string RolesID { get; set; }

    }

}