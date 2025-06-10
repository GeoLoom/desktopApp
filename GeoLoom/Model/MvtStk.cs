using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class MvtStk
        {
            public int MvtStkId { get; set; }           // id_mvt (Primary Key)
            public int RefTable { get; set; }           // ref_table (Polymorphic Association)
            public int RefId { get; set; }              // ref_id (Polymorphic Association)
            public int StateId { get; set; }            // id_e_mvt
            public int UserId { get; set; }             // id_user
            public int EmplacementId { get; set; }      // id_empl
            public int ArticleId { get; set; }          // id_art
            public int MovementTypeId { get; set; }     // id_t_mvt
            public int QuantityOld { get; set; }        // quantity_old
            public int QuantityYoung { get; set; }      // quantity_young
            public DateTime CreatedAt { get; set; }     // created_at
            public DateTime UpdatedAt { get; set; }     // updated_at
        }
    }
