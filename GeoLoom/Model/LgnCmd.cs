using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class LgnCmd
        {
            public int LgnCmdId { get; set; }           // id_lgn_cmd (Primary Key)
            public int CommandeId { get; set; }         // id_cmd
            public int ArticleId { get; set; }          // id_art
            public int Quantity { get; set; }           // quantity
            public int QuantityAtribution { get; set; } // quantity_atribution
            public int QuantityEnd { get; set; }        // quantity_end
            public int StateId { get; set; }            // id_e_lgn_cmd
            public DateTime CreatedAt { get; set; }     // created_at
            public DateTime UpdatedAt { get; set; }     // updated_at
        }
}
