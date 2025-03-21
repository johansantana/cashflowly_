﻿using CashFlowly.Core.Application.DTOs.Cuentas;
using CashFlowly.Core.Application.DTOs.Gastos;
using CashFlowly.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashFlowly.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        private readonly ICuentasService _cuentasService;
        private readonly ILogger<CuentasController> _logger;

        public CuentasController(ICuentasService cuentasService, ILogger<CuentasController> logger)
        {
            _cuentasService = cuentasService;
            _logger = logger;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            /*
            var userIdClaim = int.Parse(User.Claims.First(c => c.Type == "id").Value);
            if (userIdClaim == null)
            {
                throw new Exception("Usuario no autenticado.");
            }
            */
            return Ok(await _cuentasService.FindByIdAsync(id));
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody] CreateCuentaDTO createCuentaDTO)
        {
            await _cuentasService.CreateAsync(createCuentaDTO);
            return Ok(new { message = "Cuenta registrada correctamente." });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cuentasService.FindAllAsync());
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<IActionResult> GetByUserId(int id)
        {
            return Ok(await _cuentasService.GetByUserId(id));
        }

       [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateCuentaDTO updateCuentaDTO)
        {
            return Ok(await _cuentasService.UpdateAsync(updateCuentaDTO, id));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarGasto(int id)
        {
            await _cuentasService.DeleteAsync(id);
            return Ok();
        }
    }
}
