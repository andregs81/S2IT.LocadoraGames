using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using S2IT.LocadoraGames.Application.Interfaces;
using S2IT.LocadoraGames.Application.ViewModels;
using System;
using System.Linq;

namespace S2IT.LocadoraGames.Site.Controllers
{
    [Authorize]
    public class JogosController : Controller
    {
        private readonly IJogoAppService _jogoAppService;
        private readonly IAmigoAppService _amigoAppService;

        public JogosController(IJogoAppService jogoAppService, IAmigoAppService amigoAppService)
        {
            _jogoAppService = jogoAppService;
            _amigoAppService = amigoAppService;
        }

        // GET: Jogos
        public IActionResult Index()
        {
            var jogos = _jogoAppService.GetAll();
            return View(jogos);
        }

        // GET: Jogos/Details/5
        public IActionResult Details(int id)
        {

            var jogoViewModel = _jogoAppService.GetById(id);

            if (jogoViewModel == null)
            {
                return NotFound();
            }

            //return View(jogoViewModel);
            return PartialView(jogoViewModel);
        }

        // GET: Jogos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jogos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JogoViewModel jogoViewModel)
        {
            var titulo = _jogoAppService.GetByTitle(jogoViewModel.Titulo);
            if(titulo.Any())
            {
                ViewBag.RetornoPost = "error,Já existe um jogo com esse nome!";
                return View(jogoViewModel);
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _jogoAppService.Add(jogoViewModel);
                    ViewBag.RetornoPost = "success,Jogo registrado com sucesso!";
                }
                catch (Exception ex)
                {
                    ViewBag.RetornoPost = string.Format("{0};{1}. {2}", "error", "Problemas ao salvar os dados no banco de dados: ", ex.Message);

                }
                
                
                //return RedirectToAction("Index");
            }
            else {
                ViewBag.RetornoPost = "error, Problemas ao salvar o registro. Verifique as mensagens";
            }

            return View(jogoViewModel);
        }

        // GET: Jogos/Edit/5
        public IActionResult Edit(int id)
        {
            var jogoViewModel = _jogoAppService.GetById(id);
            if (jogoViewModel == null)
            {
                return NotFound();
            }

            return View(jogoViewModel);
        }

        // POST: Jogos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JogoViewModel jogoViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _jogoAppService.Update(jogoViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AmigoId"] = new SelectList(_context.Set<Amigo>(), "AmigoId", "AmigoId", jogoViewModel.AmigoId);
            return View(jogoViewModel);
        }

        // GET: Jogos/Delete/5
        public IActionResult Delete(int id)
        {
            var jogoViewModel = _jogoAppService.GetById(id);


            if (jogoViewModel == null)
            {
                return NotFound();
            }

            return View(jogoViewModel);
        }

        // POST: Jogos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            _jogoAppService.Remove(id);

            return RedirectToAction("Index");
        }

        //Emprestismo

        public IActionResult Lista()
        {
            var jogos = _jogoAppService.GetGamesAndFriends();
            return View(jogos);
        }

        public IActionResult Emprestar(int id)
        {
            var jogoViewModel = _jogoAppService.GetById(id);
            if (jogoViewModel == null)
            {
                return NotFound();
            }
            ViewData["AmigoId"] = new SelectList(_amigoAppService.GetAll(), "AmigoId", "Nome", jogoViewModel.AmigoId);
            return View(jogoViewModel);
        }

        // POST: Jogos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Emprestar(JogoViewModel jogoViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _jogoAppService.Update(jogoViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Lista");
            }
            return View(jogoViewModel);
        }

        public IActionResult Devolver(int id)
        {
            var jogoViewModel = _jogoAppService.GetById(id);
            if (jogoViewModel == null)
            {
                return NotFound();
            }
            ViewData["AmigoId"] = new SelectList(_amigoAppService.GetAll(), "AmigoId", "Nome", jogoViewModel.AmigoId);
            return View(jogoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Devolver(JogoViewModel jogoViewModel)
        {
            try
            {
                _jogoAppService.Devolver(jogoViewModel);
                return RedirectToAction("Lista");
            }
            catch (DbUpdateConcurrencyException)
            {
                return View(jogoViewModel);
            }



        }

    }
}
