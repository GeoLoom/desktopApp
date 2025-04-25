using chaisAps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Text;
using System.Xml.Linq;

namespace chaisAps.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [TempData]
        public decimal Total { get; set; }
        public List<Boisson> Boissons { get; set; } = new List<Boisson>();

            public void OnGet()
            {
                // DATAGAP
                Boissons.Add(new Boisson { Id = 1, Nom = "Coca-Cola", Prix = 1});
                Boissons.Add(new Boisson { Id = 2, Nom = "Pepsi", Prix = 1 });
                Boissons.Add(new Boisson { Id = 3, Nom = "Orangina", Prix = 1 });
                Boissons.Add(new Boisson { Id = 4, Nom = "Eau Minérale", Prix = 1 });
                Boissons.Add(new Boisson { Id = 5, Nom = "Thé Glacé", Prix = 1 });
            }

           /* public string GenerateBoissonHtml(IEnumerable<Boisson> boissons)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var boisson in boissons)
                {
                    sb.Append($"<div class='boisson-card'>");
                    sb.Append($"<h3>{boisson.Nom}</h3>");
                    sb.Append($"<p>{boisson.Prix} €</p>");
                    sb.Append($"<form method='post' asp-page-handler='TotalHtml'>");
                    sb.Append($"<input type='hidden' name='id' value='{boisson.Id}'/>");
                    sb.Append($"<button type='submit' class='add-button'>Ajouter</button>");
                    sb.Append("</form>");
                    sb.Append("</div>");
                }
                return sb.ToString();
            } */

            public void OnPostTotalHtml(int id)
            {
                Total += Boissons[id].Prix;
                //Total = Boissons[id].Prix.ToString() + " €";
            }
    }

    }
