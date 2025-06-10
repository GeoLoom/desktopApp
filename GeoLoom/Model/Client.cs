using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class Client
        {
            public int ClientId { get; set; }           // id_clt (Primary Key)
            public int StateId { get; set; }            // id_e_clt
            public string Name { get; set; }            // libelle_clt
            public DateTime CommandDate { get; set; }   // date_cmd
            public DateTime CreatedAt { get; set; }     // created_at
            public DateTime UpdatedAt { get; set; }     // updated_at
        }
    }
