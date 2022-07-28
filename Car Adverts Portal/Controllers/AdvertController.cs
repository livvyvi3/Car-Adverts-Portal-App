using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;


namespace Car_Adverts_Portal.Controllers
{
    public class AdvertController : Controller
    {
        // GET: Advert
        public ActionResult Index()
        {
            return View(Models.DapperORMModel.ReturnList<Models.AdvertModel>("AdvertViewAll", null));
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                return View(Models.DapperORMModel.ReturnList<Models.AdvertModel>("AdvertViewById", param).FirstOrDefault<Models.AdvertModel>());
            }


        }

        [HttpPost]
        public ActionResult AddOrEdit(Models.AdvertModel advert)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", advert.Id);
            param.Add("@Make", advert.Make);
            param.Add("@Model", advert.Model);
            param.Add("@Year", advert.Year);
            param.Add("@Color", advert.Color);
            param.Add("@Condition", advert.Condition);
            param.Add("@Price", advert.Price);
            param.Add("@Images ", advert.Images);
            param.Add("@Doors", advert.Doors);
            param.Add("@Status", advert.Status);
            Models.DapperORMModel.ExecuteWithoutReturn("AdvertAddOrEdit", param);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", id);
            Models.DapperORMModel.ExecuteWithoutReturn("AdvertDeleteByID", param);
            return RedirectToAction("Index");
        }
    }
}