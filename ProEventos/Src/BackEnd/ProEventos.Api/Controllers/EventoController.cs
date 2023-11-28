using Microsoft.AspNetCore.Mvc;
using ProEventos.Application.Dtos;
using ProEventos.Application.Interfaces;
using ProEventos.Domain.Entitys;

namespace ProEventos.Api.Controllers
{
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService _service;
        public EventoController(IEventoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _service.GetAllEventosAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] long id)
        {
            return Ok(await _service.GetEventoByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddEventoAsync([FromBody] EventoDto evento)
        {
            EventoDto e = await _service.AddEventosAsync(evento);
            return CreatedAtAction("GetById", new { id = e.Id }, e);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateEventoAsync([FromBody] EventoDto evento, [FromRoute] long id )
        {
            EventoDto e = await _service.UpdateEventoAsync(id, evento);
            return Ok(e);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteEventoAsync([FromRoute] long id)
        {
            await _service.DeleteEventoAsync(id);
            return NoContent();
        }
    }
}
