using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
        public class Emplacement
        {
            public int EmplacementId { get; set; }
            public int WarehouseId { get; set; }
            public int StateId { get; set; }
            public string Name { get; set; }
            public int OccupancyRate { get; set; }
            public int Zone { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }
    }
