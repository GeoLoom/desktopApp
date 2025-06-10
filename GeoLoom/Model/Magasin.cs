using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class Magasin
        {
            public int MagasinId { get; set; }          // id_mag (Primary Key)
            public int StateId { get; set; }            // id_e_mag
            public int TypeId { get; set; }             // id_t_mag
            public string Name { get; set; }            // libelle_mag
            public DateTime CreatedAt { get; set; }     // created_at
            public DateTime UpdatedAt { get; set; }     // updated_at
        }
    }