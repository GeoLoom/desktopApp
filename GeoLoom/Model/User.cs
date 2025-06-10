using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class User
        {
            public int UserId { get; set; }             // id_user (Primary Key)
            public int StateId { get; set; }            // id_e_users
            public string Username { get; set; }        // username
            public string Role { get; set; }            // role
            public DateTime CreatedAt { get; set; }     // created_at
            public DateTime UpdatedAt { get; set; }     // updated_at
        }
}
