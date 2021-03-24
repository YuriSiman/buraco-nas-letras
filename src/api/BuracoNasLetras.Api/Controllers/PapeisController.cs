using AutoMapper;
using BuracoNasLetras.Api.Extensios;
using BuracoNasLetras.Api.ViewModels;
using BuracoNasLetras.Business.Interfaces;
using BuracoNasLetras.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuracoNasLetras.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpPost]
        public async Task<ActionResult<PapelViewModel>> Post(PapelViewModel papelViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var papel = _mapper.Map<Papel>(papelViewModel);

            var papelAtualizado = PopularInformacoesPapel(papel);

            await _papelRepository.Adicionar(papelAtualizado);

            return Ok(papelAtualizado);
        }

        private Papel PopularInformacoesPapel(Papel papel)
        {
            papel.Tamanho = papel.Texto.Length;
            papel.TotalDePalavras = papel.Texto.Replace(" ", "").Length;
            papel.TotalDeBuracos = _quantidadeBuracosTexto.QuantidadeDeBuracos(papel.Texto);

            return papel;
        }
    }
}
