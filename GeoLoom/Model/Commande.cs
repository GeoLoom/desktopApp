using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class Commande
        {
            public int CommandeId { get; set; }         // id_cmd (Primary Key)
            public int StateId { get; set; }            // id_e_cmd
            public int ClientId { get; set; }           // id_clt
            public int FournisseurId { get; set; }      // id_fournisseur
            public DateTime CommandDate { get; set; }   // date_cmd
            public DateTime CreatedAt { get; set; }     // created_at
            public DateTime UpdatedAt { get; set; }     // updated_at
        }
    }
