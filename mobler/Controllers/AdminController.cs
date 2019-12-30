using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mobler.Models;

namespace mobler.Controllers
{
    public class AdminController : Controller
    {
        // l'objet qui represente la base de donnees
        MoblerDBEntities2 DB = new MoblerDBEntities2();
        // GET: Admin
        public ActionResult Index()
        {
            var Cats = DB.Categories.ToList();
            var SubCats = DB.SubCategories.ToList();
            
            return View(Cats);
        }
        public ActionResult AjouterCat() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterCat( Categorie cat , HttpPostedFileBase fichier) //  Model binding
        {
            // string nom_categorie = Request.Form["NomCat"];
            // traiter l'image 
            string nom_empty = Path.GetFileNameWithoutExtension(fichier.FileName); // nom sans Extension
              //To Get File Extension  
              string nom_ext = Path.GetExtension(fichier.FileName);
              //Add Current Date To Attached File Name  
              string nom_complet = nom_empty.Trim() + "_" + DateTime.Now.ToString("yy-MM-dd-mm-ss") + nom_ext;
              cat.Img_Cat = "/Img/Categorie" + nom_complet;
              fichier.SaveAs(Server.MapPath(cat.Img_Cat));
              //cat.Nom_Cat = nom_categorie;
        
                DB.Categories.Add(cat);

                DB.SaveChanges();
              
              return RedirectToAction("Index");
           
        }
        public ActionResult AjouterSubCat()
        {
            var Cats = DB.Categories.ToList();
            return View(Cats);
        }

        [HttpPost]
        public ActionResult AjouterSubCat(Categorie cat, HttpPostedFileBase fichier) //  Model binding
        {
            /* // string nom_categorie = Request.Form["NomCat"];
             // traiter l'image 
             string nom_empty = Path.GetFileNameWithoutExtension(fichier.FileName); // nom sans Extension
               //To Get File Extension  
               string nom_ext = Path.GetExtension(fichier.FileName);
               //Add Current Date To Attached File Name  
               string nom_complet = nom_empty.Trim() + "_" + DateTime.Now.ToString("yy-MM-dd-mm-ss") + nom_ext;
               cat.Img_Cat = "/Img/Categorie" + nom_complet;
               fichier.SaveAs(Server.MapPath(cat.Img_Cat));
               //cat.Nom_Cat = nom_categorie;

                 db.Categories.Add(cat);

               db.SaveChanges();*/

            return RedirectToAction("Index");

        }
        public ActionResult AjouterAdmin()
        {
            var user = DB.Utilisateurs.ToList();
            var nbr = DB.Utilisateurs.Count();
            ViewBag.Nbr_User = nbr;
            return View(user);
        }

        [HttpPost]
        public ActionResult AjouterAdmin(Utilisateur user) //  Model binding
        {
                user.type_User = 1 ;
                DB.Utilisateurs.Add(user);
                DB.SaveChanges();
                return RedirectToAction("AjouterAdmin");

        }
        public ActionResult SupprimerAdmin(Utilisateur user)
        {
          /*  Utilisateur _user = DB.Utilisateurs.Find(user.Id_User);
            var usr = DB.Utilisateurs.ToList();
            foreach(var item in user )
            {
                if (item.Id_User == id)
                {
                    DB.Utilisateurs.Remove(item);
                }
            }
           */
            return RedirectToAction("/Admin/AjouterAdmin");
        }
        public ActionResult AjouterArticle()
        {
            var SubCats = DB.SubCategories.ToList();
            return View(SubCats);
        }
        [HttpPost]
        public ActionResult AjouterArticle(Article art)
        {
            DB.Articles.Add(art);
            DB.SaveChanges();
            return View();
        }
    }
}