using GeoLoom.Model;
using System.Collections.Generic;
using System.Linq;
using GeoLoom.Model;

namespace GeoLoom.Data
{
    public static class DBConnect
    {
        // ------- Article -------
        public static List<Article> GetAllArticles()
        {
            using (var context = new WarehouseContext())
                => context.Articles.ToList();
        }

        public static void AddArticle(Article article)
        {
            using (var context = new WarehouseContext())
            {
                context.Articles.Add(article);
                context.SaveChanges();
            }
        }

        public static void UpdateArticle(Article article)
        {
            using (var context = new WarehouseContext())
            {
                context.Articles.Update(article);
                context.SaveChanges();
            }
        }

        public static void DeleteArticle(int articleId)
        {
            using (var context = new WarehouseContext())
            {
                var article = context.Articles.Find(articleId);
                if (article != null)
                {
                    context.Articles.Remove(article);
                    context.SaveChanges();
                }
            }
        }

        // ------- FamilleArticle -------
        public static List<FamilleArticle> GetAllFamilleArticles()
        {
            using (var context = new WarehouseContext())
                => context.FamilleArticles.ToList();
        }

        public static void AddFamilleArticle(FamilleArticle famille)
        {
            using (var context = new WarehouseContext())
            {
                context.FamilleArticles.Add(famille);
                context.SaveChanges();
            }
        }

        public static void UpdateFamilleArticle(FamilleArticle famille)
        {
            using (var context = new WarehouseContext())
            {
                context.FamilleArticles.Update(famille);
                context.SaveChanges();
            }
        }

        public static void DeleteFamilleArticle(int familleId)
        {
            using (var context = new WarehouseContext())
            {
                var famille = context.FamilleArticles.Find(familleId);
                if (famille != null)
                {
                    context.FamilleArticles.Remove(famille);
                    context.SaveChanges();
                }
            }
        }

        // ------- Emplacement -------
        public static List<Emplacement> GetAllEmplacements()
        {
            using (var context = new WarehouseContext())
                => context.Emplacements.ToList();
        }
        public static void AddEmplacement(Emplacement empl)
        {
            using (var context = new WarehouseContext())
            {
                context.Emplacements.Add(empl);
                context.SaveChanges();
            }
        }
        public static void UpdateEmplacement(Emplacement empl)
        {
            using (var context = new WarehouseContext())
            {
                context.Emplacements.Update(empl);
                context.SaveChanges();
            }
        }
        public static void DeleteEmplacement(int emplId)
        {
            using (var context = new WarehouseContext())
            {
                var empl = context.Emplacements.Find(emplId);
                if (empl != null)
                {
                    context.Emplacements.Remove(empl);
                    context.SaveChanges();
                }
            }
        }

        // ------- Magasin -------
        public static List<Magasin> GetAllMagasins()
        {
            using (var context = new WarehouseContext())
                => context.Magasins.ToList();
        }
        public static void AddMagasin(Magasin mag)
        {
            using (var context = new WarehouseContext())
            {
                context.Magasins.Add(mag);
                context.SaveChanges();
            }
        }
        public static void UpdateMagasin(Magasin mag)
        {
            using (var context = new WarehouseContext())
            {
                context.Magasins.Update(mag);
                context.SaveChanges();
            }
        }
        public static void DeleteMagasin(int magId)
        {
            using (var context = new WarehouseContext())
            {
                var mag = context.Magasins.Find(magId);
                if (mag != null)
                {
                    context.Magasins.Remove(mag);
                    context.SaveChanges();
                }
            }
        }

        // ------- User -------
        public static List<User> GetAllUsers()
        {
            using (var context = new WarehouseContext())
                => context.Users.ToList();
        }
        public static void AddUser(User user)
        {
            using (var context = new WarehouseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public static void UpdateUser(User user)
        {
            using (var context = new WarehouseContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
        public static void DeleteUser(int userId)
        {
            using (var context = new WarehouseContext())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }

        // ------- MvtStk -------
        public static List<MvtStk> GetAllMvtStks()
        {
            using (var context = new WarehouseContext())
                => context.MvtStks.ToList();
        }
        public static void AddMvtStk(MvtStk mvt)
        {
            using (var context = new WarehouseContext())
            {
                context.MvtStks.Add(mvt);
                context.SaveChanges();
            }
        }
        public static void UpdateMvtStk(MvtStk mvt)
        {
            using (var context = new WarehouseContext())
            {
                context.MvtStks.Update(mvt);
                context.SaveChanges();
            }
        }
        public static void DeleteMvtStk(int mvtId)
        {
            using (var context = new WarehouseContext())
            {
                var mvt = context.MvtStks.Find(mvtId);
                if (mvt != null)
                {
                    context.MvtStks.Remove(mvt);
                    context.SaveChanges();
                }
            }
        }

        // ------- Commande -------
        public static List<Commande> GetAllCommandes()
        {
            using (var context = new WarehouseContext())
                => context.Commandes.ToList();
        }
        public static void AddCommande(Commande cmd)
        {
            using (var context = new WarehouseContext())
            {
                context.Commandes.Add(cmd);
                context.SaveChanges();
            }
        }
        public static void UpdateCommande(Commande cmd)
        {
            using (var context = new WarehouseContext())
            {
                context.Commandes.Update(cmd);
                context.SaveChanges();
            }
        }
        public static void DeleteCommande(int cmdId)
        {
            using (var context = new WarehouseContext())
            {
                var cmd = context.Commandes.Find(cmdId);
                if (cmd != null)
                {
                    context.Commandes.Remove(cmd);
                    context.SaveChanges();
                }
            }
        }

        // ------- LgnCmd -------
        public static List<LgnCmd> GetAllLgnCmds()
        {
            using (var context = new WarehouseContext())
                => context.LgnCmds.ToList();
        }
        public static void AddLgnCmd(LgnCmd lgn)
        {
            using (var context = new WarehouseContext())
            {
                context.LgnCmds.Add(lgn);
                context.SaveChanges();
            }
        }
        public static void UpdateLgnCmd(LgnCmd lgn)
        {
            using (var context = new WarehouseContext())
            {
                context.LgnCmds.Update(lgn);
                context.SaveChanges();
            }
        }
        public static void DeleteLgnCmd(int lgnId)
        {
            using (var context = new WarehouseContext())
            {
                var lgn = context.LgnCmds.Find(lgnId);
                if (lgn != null)
                {
                    context.LgnCmds.Remove(lgn);
                    context.SaveChanges();
                }
            }
        }

        // ------- Client -------
        public static List<Client> GetAllClients()
        {
            using (var context = new WarehouseContext())
                => context.Clients.ToList();
        }
        public static void AddClient(Client client)
        {
            using (var context = new WarehouseContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }
        public static void UpdateClient(Client client)
        {
            using (var context = new WarehouseContext())
            {
                context.Clients.Update(client);
                context.SaveChanges();
            }
        }
        public static void DeleteClient(int clientId)
        {
            using (var context = new WarehouseContext())
            {
                var client = context.Clients.Find(clientId);
                if (client != null)
                {
                    context.Clients.Remove(client);
                    context.SaveChanges();
                }
            }
        }
    }
}
