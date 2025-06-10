using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.Model
{
    public class Article
    {
        public int ArticleId { get; set; }
        public int StateId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int FamilyId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

      
        // public virtual FamilleArticle Famille { get; set; }
    }
}
