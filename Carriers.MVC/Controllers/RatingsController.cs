using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Carriers.Application.Interfaces;
using Carriers.Domain.Entities;
using Carriers.MVC.Helpers;
using Carriers.MVC.ViewModels;

namespace Carriers.MVC.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ICarrierAppService _carrierApp;
        private readonly IRatingAppService _ratingApp;

        public RatingsController(IRatingAppService ratingApp, ICarrierAppService carrierApp)
        {
            _ratingApp = ratingApp;
            _carrierApp = carrierApp;
        }

        // GET: Carriers
        public ActionResult Index()
        {
            var ratingViewModel =
                Mapper.Map<IEnumerable<Rating>, IEnumerable<RatingViewModel>>(_ratingApp.GetAll().Where(r => r.UserId == GerenciadorSessao.User.UserId));
            return View(ratingViewModel);
        }

        // GET: Carriers/Details/5
        public ActionResult Details(int id)
        {
            var rating = _ratingApp.GetById(id);
            var ratingViewModel = Mapper.Map<Rating, RatingViewModel>(rating);
            return View(ratingViewModel);
        }

        // GET: Carriers/Create
        public ActionResult Create()
        {
            if (GerenciadorSessao.User != null)
            {

                ViewBag.CarrierId = new SelectList(_carrierApp.GetAll(), "CarrierId", "Name");

                return View();
            }

            return RedirectToAction("Index", "Users");
        }

        // POST: Carriers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RatingViewModel rating)
        {
            if (GerenciadorSessao.User != null)
            {
                rating.User = GerenciadorSessao.User;
                if (ModelState.IsValid)
                {
                    if (_ratingApp.GetAll().Any(r => r.UserId == GerenciadorSessao.User.UserId && r.CarrierId == rating.CarrierId)) return RedirectToAction("Index", "Ratings");

                    var ratingDomain = Mapper.Map<RatingViewModel, Rating>(rating);
                    _ratingApp.Add(ratingDomain);

                    return RedirectToAction("Index");
                }

                ViewBag.CarrierId = new SelectList(_carrierApp.GetAll(), "CarrierId", "Name");
                return View(rating);
            }
            return RedirectToAction("Index", "Users");
        }

        // GET: Carriers/Edit/5
        public ActionResult Edit(int id)
        {
            var rating = _ratingApp.GetById(id);
            var ratingViewModel = Mapper.Map<Rating, RatingViewModel>(rating);

            ViewBag.CarrierId = new SelectList(_carrierApp.GetAll(), "CarrierId", "Name", rating.CarrierId);

            return View(ratingViewModel);
        }

        // POST: Carriers/Edit/5
        [HttpPost]
        public ActionResult Edit(RatingViewModel rating)
        {
            if (ModelState.IsValid)
            {
                var ratingDomain = Mapper.Map<RatingViewModel, Rating>(rating);
                _ratingApp.Update(ratingDomain);

                return RedirectToAction("Index");
            }

            ViewBag.CarrierId = new SelectList(_carrierApp.GetAll(), "CarriereId", "Nome", rating.CarrierId);
            return View(rating);
        }

        // GET: Carriers/Delete/5
        public ActionResult Delete(int id)
        {
            var rating = _ratingApp.GetById(id);
            var ratingViewModel = Mapper.Map<Rating, RatingViewModel>(rating);
            return View(ratingViewModel);
        }

        // POST: Carriers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var rating = _ratingApp.GetById(id);
            _ratingApp.Remove(rating);

            return RedirectToAction("Index");
        }
    }
}