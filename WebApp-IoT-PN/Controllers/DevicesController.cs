using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_IoT_PN.Models
{
    public class DevicesController : Controller
    {
        private readonly IDevicesRepository _devicesRepository;

        public DevicesController(IDevicesRepository devicesRepository)
        {
            _devicesRepository = devicesRepository;
        }

        // GET: DevicesController
        public ActionResult Index()
        {
            return View(_devicesRepository.AllDevices);
        }

        // GET: DevicesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DevicesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DevicesController/Create
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

        // GET: DevicesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DevicesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DevicesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DevicesController/Delete/5
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
