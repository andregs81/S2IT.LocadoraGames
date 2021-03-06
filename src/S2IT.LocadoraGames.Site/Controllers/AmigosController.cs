﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using S2IT.LocadoraGames.Application.Interfaces;
using S2IT.LocadoraGames.Application.ViewModels;
using System;
using System.Linq;

namespace S2IT.LocadoraGames.Site.Controllers
{
    [Authorize]
    public class AmigosController : Controller
    {
        private readonly IAmigoAppService _amigoAppService;
        private readonly IJogoAppService _jogoAppService;
        private readonly IEnderecoAppService _enderecoAppService;

        public AmigosController(IAmigoAppService amigoAppService, IJogoAppService jogoAppService, IEnderecoAppService enderecoAppService)
        {
            _amigoAppService = amigoAppService;
            _jogoAppService = jogoAppService;
            _enderecoAppService = enderecoAppService;
        }

        // GET: Amigos
        public ActionResult Index()
        {
            var amigoViewModel = _amigoAppService.GetAll();

            return View(amigoViewModel);
        }

        // GET: Amigos/Details/5
        public ActionResult Details(int id)
        {
            var amigoViewModel = _amigoAppService.GetById(id);
            amigoViewModel.Jogos = _jogoAppService.GetAll().Where(j => j.AmigoId == id).ToList();

            return PartialView(amigoViewModel);
        }

        // GET: Amigos/Create
        public ActionResult Create()
        {
            ViewData["CidadeId"] = new SelectList("0", "");
            ViewData["CidadeId"] = new SelectList(_enderecoAppService.ObterCidades(), "CidadeId", "Nome");
            return View();
        }

        // POST: Amigos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AmigoEnderecoViewModel amigoViewModel)
        {
            try
            {
                // TODO: Add insert logic here                
                if (ModelState.IsValid)
                {
                    _amigoAppService.Add(amigoViewModel);
                }


                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {

                string mensagem = string.Empty;
                foreach (var item in ModelState.Values.SelectMany(v => v.Errors).ToList())
                {
                    ViewBag.RetornoPost += string.Format("{0}\n\r", item.ErrorMessage);
                }

                return View();
            }
        }

        // GET: Amigos/Edit/5
        public ActionResult Edit(int id)
        {
            var amigoViewModel = _amigoAppService.GetById(id);

            return View(amigoViewModel);
        }

        // POST: Amigos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AmigoViewModel amigoViewModel)
        {

            if (ModelState.IsValid)
            {
                _amigoAppService.Update(amigoViewModel);
                return RedirectToAction("Index");
            }

            return View();

        }

        // GET: Amigos/Delete/5
        public ActionResult Delete(int id)
        {
            var amigoViewModel = _amigoAppService.GetById(id);

            return View(amigoViewModel);
        }

        // POST: Amigos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _amigoAppService.Remove(id);

            return RedirectToAction("Index");

        }
    }
}