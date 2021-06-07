using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Business.Business;

namespace Precrime.Controllers
{
    public class ProdutoscadastradoController : Controller
    {
        private GerenciadoraCadastroProduto gor;

        public ProdutoscadastradoController()
        {
            gor = new GerenciadoraCadastroProduto();
        }

        public IActionResult Index()
        {
            List<Produtoscadastrado> model = gor.ObterTodos();
            if(model.Count == 0)
                model = null;
            return View(model);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(cadastrado obj_Produtoscadastrado)
        {
            try
            {
                if(ModelState.IsValid)
                    gor.Adicionar(obj_Produtoscadastrado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                cadastrado produtoscadastrado = gor.ObterById(id);
                if (produtoscadastrado != null)
                    return View(produtoscadastrado);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(cadastrado obj_produtoscadastrado)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    gor.Editar(obj_produtoscadastrado);
                    return RedirectToAction("Index");
                }
                return View(obj_produtoscadastrado);

            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int? id)
        {
            if(id.HasValue)
            {
                cadastrado objetos = gor.ObterById(id);
                if (objetos != null)
                    return View(objetos);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)

                    gor.Remover(int.Parse(form["id"]));
                    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Details(int? id)
        {
            cadastrado Obj_usuario = gor.ObterById(id);
            if (id == null)
                return View(Obj_usuario);

            return View(Obj_usuario);
        }
    }
}