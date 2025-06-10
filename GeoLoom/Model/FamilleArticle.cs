using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class FamilleArticle
        {
            public int FamilleArticleId { get; set; }
            public int FamArtId { get; set; }
            public int StateId { get; set; }
            public int UnitId { get; set; }
            public int CriticalStockMax { get; set; }
            public int CriticalStockMin { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }
    }
