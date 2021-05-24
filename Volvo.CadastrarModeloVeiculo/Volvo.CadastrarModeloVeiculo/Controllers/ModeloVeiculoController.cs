using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Volvo.CadastrarModeloVeiculo.Dominio;
using Volvo.CadastrarModeloVeiculo.AcessoDados.Entity.Context;
using Volvo.CadastrarModeloVeiculo.Repositorio.Comum.Entity;
using Volvo.CadastrarModeloVeiculo.comum;
using Volvo.CadastrarModeloVeiculo.ViewModel.ModeloVeiculo;
using AutoMapper;

namespace Volvo.CadastrarModeloVeiculo.Controllers
{
    public class ModeloVeiculoController : Controller
    {

        private IRepositorioGenerico<ModeloVeiculo, int> repositorioModeloVeiculo
            = new ModeloVeiculoRepositorio(new VolvoDbContext());

        // GET: ModeloVeiculo
        public ActionResult Index()
        {
            return View(Mapper.Map<List<ModeloVeiculo>, List<ModeloVeiculoIndexViewModel>>(repositorioModeloVeiculo.Selecionar()));
        }

        // GET: ModeloVeiculo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModeloVeiculo mv = repositorioModeloVeiculo.SelecionarPorId(id.Value);
            if (mv == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<ModeloVeiculo, ModeloVeiculoIndexViewModel>(mv));
        }

        // GET: ModeloVeiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModeloVeiculo/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Modelo,AnoFabricacao,AnoModelo")] ModeloVeiculoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                ModeloVeiculo mv = Mapper.Map<ModeloVeiculoViewModel, ModeloVeiculo>(viewModel);
                repositorioModeloVeiculo.Inserir(mv);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: ModeloVeiculo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModeloVeiculo mv = repositorioModeloVeiculo.SelecionarPorId(id.Value);
            if (mv == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<ModeloVeiculo, ModeloVeiculoViewModel>(mv));
        }

        // POST: ModeloVeiculo/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Modelo,AnoFabricacao,AnoModelo")] ModeloVeiculoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                ModeloVeiculo mv = Mapper.Map<ModeloVeiculoViewModel, ModeloVeiculo>(viewModel);
                repositorioModeloVeiculo.Alterar(mv);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: ModeloVeiculo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModeloVeiculo mv = repositorioModeloVeiculo.SelecionarPorId(id.Value);
            if (mv == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<ModeloVeiculo, ModeloVeiculoIndexViewModel>(mv));
        }

        // POST: ModeloVeiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioModeloVeiculo.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}
