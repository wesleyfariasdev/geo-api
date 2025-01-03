using Geo.Application.Dto.Request;
using Geo.Application.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace GeoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalController(ILocalService _localService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] LocalRequestDto localDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var local = await _localService.Criar(localDto);
            return CreatedAtAction(nameof(BuscarPorId), new { id = local.Id }, local);
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            var locais = await _localService.BuscarTodos();
            return Ok(locais);
        }

        [HttpGet("geojson")]
        public async Task<IActionResult> ListarEmGeoJson()
        {
            var geoJson = await _localService.ObterGeoJson();
            return Ok(geoJson);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> BuscarPorId(Guid id)
        {
            var local = await _localService.BuscarLocalPorId(id);
            if (local == null)
                return NotFound();

            return Ok(local);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Atualizar(Guid id, [FromBody] LocalRequestDto localDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var atualizado = await _localService.Atualizar(localDto);
            if (atualizado == null)
                return NotFound();

            return Ok(atualizado);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var sucesso = await _localService.Deletar(id);
            if (!sucesso)
                return NotFound();

            return NoContent();
        }
    }
}
