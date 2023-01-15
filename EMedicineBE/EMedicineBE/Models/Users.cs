using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace EMedicineBE.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Password { get; set; }
        public string Emain { get; set; }
        public decimal Fund { get; set; }
        public string Type { get; set; }

        public int Status { get; set; }
        public DateTime CreatedON { get; set; }

    }
}
