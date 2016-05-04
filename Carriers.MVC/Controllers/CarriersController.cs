using System.Collections;
using System.Web.Mvc;
using AutoMapper;
using Carriers.Domain.Entities;
using Carriers.MVC.ViewModels;
using System.Collections.Generic;
using Carriers.Application.Interfaces;

namespace Carriers.MVC.Controllers
{
    public class CarriersController : Controller
    {
        private readonly ICarrierAppService _carrierApp;

        public CarriersController(ICarrierAppService carrierApp)
        {
            _carrierApp = carrierApp;
        }

        // GET: Carriers
        public ActionResult Index()
        {
            var carrierViewModel =
                Mapper.Map<IEnumerable<Carrier>, IEnumerable<CarrierViewModel>>(_carrierApp.GetAll());
            return View(carrierViewModel);
        }

        // GET: Carriers/Details/5
        public ActionResult Details(int id)
        {
            var carriere = _carrierApp.GetById(id);
            var carriereViewModel = Mapper.Map<Carrier, CarrierViewModel>(carriere);
            return View(carriereViewModel);
        }

        // GET: Carriers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carriers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarrierViewModel carriere)
        {
            if (ModelState.IsValid)
            {
                var carriereDomain = Mapper.Map<CarrierViewModel, Carrier>(carriere);
                _carrierApp.Add(carriereDomain);

                return RedirectToAction("Index");
            }

            return View(carriere);
        }

        // GET: Carriers/Edit/5
        public ActionResult Edit(int id)
        {
            var carriere = _carrierApp.GetById(id);
            var carriereViewModel = Mapper.Map<Carrier, CarrierViewModel>(carriere);
            return View(carriereViewModel);
        }

        // POST: Carriers/Edit/5
        [HttpPost]
        public ActionResult Edit(CarrierViewModel carriere)
        {
            if (ModelState.IsValid)
            {
                var carriereDomain = Mapper.Map<CarrierViewModel, Carrier>(carriere);
                _carrierApp.Update(carriereDomain);

                return RedirectToAction("Index");
            }

            return View(carriere);
        }

        // GET: Carriers/Delete/5
        public ActionResult Delete(int id)
        {
            var carriere = _carrierApp.GetById(id);
            var carriereViewModel = Mapper.Map<Carrier, CarrierViewModel>(carriere);
            return View(carriereViewModel);
        }

        // POST: Carriers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var carrier = _carrierApp.GetById(id);
            _carrierApp.Remove(carrier);

            return RedirectToAction("Index");
        }
    }
}
