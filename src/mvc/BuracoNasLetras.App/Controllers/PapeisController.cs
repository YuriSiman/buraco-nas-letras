using AutoMapper;
using BuracoNasLetras.App.ViewModels;
using BuracoNasLetras.Business.Interfaces;
using BuracoNasLetras.Business.Models;
using BuracoNasLetras.ConsoleApp.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuracoNasLetras.App.Controllers
{
    public class PapeisController : Controller
    {
        protected readonly IPapelRepository _papelRepository;
        protected readonly IMapper _mapper;
        protected readonly QuantidadeBuracosTexto _quantidadeBuracosTexto;

        public PapeisController(IPapelRepository papelRepository, IMapper mapper, QuantidadeBuracosTexto quantidadeBuracosTexto)
        {
            _papelRepository = papelRepository;
            _mapper = mapper;
            _quantidadeBuracosTexto = quantidadeBuracosTexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<PapelViewModel>>(await _papelRepository.ObterTodos()));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PapelViewModel papelViewModel)
        {
            if (!ModelState.IsValid) return View(papelViewModel);

            var papel = _mapper.Map<Papel>(papelViewModel);

            var papelAtualizado = PopularInformacoesPapel(papel);

            await _papelRepository.Adicionar(papelAtualizado);

            return RedirectToAction(nameof(Index));
        }

        public Papel PopularInformacoesPapel(Papel papel)
        {
            papel.Tamanho = papel.Texto.Length;
            papel.TotalDePalavras = papel.Texto.Replace(" ", "").Length;
            papel.TotalDeBuracos = _quantidadeBuracosTexto.QuantidadeDeBuracos(papel.Texto);

            return papel;
        }
    }
}
