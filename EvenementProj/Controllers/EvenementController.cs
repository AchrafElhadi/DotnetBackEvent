using AutoMapper;
using Evenement.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoitureApi.Model;
using VoitureAPi2.Model;
using VoitureAPi2.Services;

namespace VoitureAPi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenementController : ControllerBase
    {
        IEvenement eventServ;
        IMapper mapper;
        public EvenementController(IEvenement eventServ, IMapper mapper)
        {
            this.eventServ = eventServ;
            this.mapper = mapper;
        }
        [HttpGet("{id}")]
        public  async Task<EventsDto> getEvent(int id)
        {
            return  await eventServ.getEvenement(id);
        }

        [HttpPost]
        public Task<EventsDto> getEvenement([FromBody] EventsDto evenement)
        {
            return eventServ.addUpdateEvent(evenement);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deletecat(int id)
        {
            EventsDto evenement = mapper.Map<EventsDto>( await getEvent(id));
            eventServ.removeEvent(evenement);
            return Ok();
        }

        [HttpGet()]
        public Task<IEnumerable<EventsDto>> getAllCategories()
        {
            return eventServ.getAllEvenement();
        }
    }
}
