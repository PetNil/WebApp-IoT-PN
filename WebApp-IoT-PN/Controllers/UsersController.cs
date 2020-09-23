using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApp_IoT_PN.Models
{
    public class UsersController : Controller
    {
        // GET: LogInController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormCollection collection)
        {
            try
            {
                if (Users.listOfAdmin.Count == 0)
                {
                    Users.GenerateAdmin();
                }
                Users model = new Users();
                if (collection["Email"] == Users.listOfAdmin[0].Email && collection["Password"] == Users.listOfAdmin[0].Password) { 
                    return RedirectToAction(nameof(Edit));
                }
                else 
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogInController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogInController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogInController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index", "Devices");
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogInController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
