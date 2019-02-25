using System.Net;
using System.Web.Mvc;
using DataAnalysis.DTO;
using DataAnalysis.Models;
using DouStatistics.DAL;
using DouStatistics.DAL.Repository;

namespace DouStatisticsWebApi.Controllers.MVC
{
    public class KeyWordsController : Controller
    {
        private readonly SearchKeywordsDTO _searchKeywordsDTO;

        public KeyWordsController()
        {
            _searchKeywordsDTO = new SearchKeywordsDTO(new GenericRepository<KeyWords>());
        }

        // GET: KeyWords
        public ActionResult Index()
        {
            return View(_searchKeywordsDTO.GetAll());
        }

        // GET: KeyWords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyWordDto keyWords = _searchKeywordsDTO.Get((int)id);
            if (keyWords == null)
            {
                return HttpNotFound();
            }
            return View(keyWords);
        }

        // GET: KeyWords/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KeyWordDto keyWords)
        {
            if (ModelState.IsValid)
            {
                _searchKeywordsDTO.Add(keyWords);
                return RedirectToAction("Index");
            }

            return View(keyWords);
        }

        // GET: KeyWords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            KeyWordDto keyWords = _searchKeywordsDTO.Get((int)id);

            if (keyWords == null)
                return HttpNotFound();

            return View(keyWords);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KeyWordDto keyWords)
        {
            if (ModelState.IsValid)
            {
                _searchKeywordsDTO.Add(keyWords);
                return RedirectToAction("Index");
            }
            return View(keyWords);
        }
    }
}
