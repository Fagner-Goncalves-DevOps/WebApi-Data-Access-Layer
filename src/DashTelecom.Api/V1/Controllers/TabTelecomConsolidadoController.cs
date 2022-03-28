using AutoMapper;
using DashTelecom.Api.Controllers;
using DashTelecom.Api.ViewModels;
using DashTelecom.Domain.Intefaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashTelecom.Api.V1.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/TabTelecomConsolidado")]
    public class TabTelecomConsolidadoController : MainController
    {

        private readonly ITabTelecomConsolidadoRepository _tabTelecomConsolidadoRepository;
        private readonly ICustoGeralRepository _custoDiaRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TabTelecomConsolidadoController(ITabTelecomConsolidadoRepository tabTelecomConsolidadoRepository,
                                                ICustoGeralRepository custoDiaRepository,
                                                INotificador notificador,
                                                IMapper mapper,
                                                IHttpContextAccessor httpContextAccessor,
                                                IUser user) : base(notificador, user)
        {
            _tabTelecomConsolidadoRepository = tabTelecomConsolidadoRepository;
            _custoDiaRepository = custoDiaRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

       // [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<TabTelecomConsolidadoViewModel>> ObterTodos()
        {
            var TabTelecomConsolidado = _mapper.Map<IEnumerable<TabTelecomConsolidadoViewModel>>(await _tabTelecomConsolidadoRepository.ObterTelecomConsolidado());
            return TabTelecomConsolidado;
        }

        [HttpGet("CustoPorDia")]
        public async Task<IEnumerable<CustoDiaViewModel>> CustoPorDia()
        {
            var CustoPorDia = _mapper.Map<IEnumerable<CustoDiaViewModel>>(await _custoDiaRepository.ObterCustoServidorDia());
            return CustoPorDia;
        }

        [HttpGet("CustoPorServidor")]
        public async Task<IEnumerable<CustoServidorViewModel>> CustoPorServidor()
        {
            var CustoPorServidor = _mapper.Map<IEnumerable<CustoServidorViewModel>>(await _custoDiaRepository.ObterCustoServidorPorServidor());
            return CustoPorServidor;
        }

        [HttpGet("CustoPorOperadora")]
        public async Task<IEnumerable<CustoOperadoraViewModel>> CustoOperadora()
        {
            var CustoOperadora = _mapper.Map<IEnumerable<CustoOperadoraViewModel>>(await _custoDiaRepository.ObterCustoOperadora());
            return CustoOperadora;
        }

    }
}



