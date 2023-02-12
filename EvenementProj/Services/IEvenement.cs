using Evenement.Model.Dto;
using VoitureAPi2.Model;

namespace VoitureAPi2.Services
{
    public interface IEvenement
    {
        Task<EventsDto> addUpdateEvent(EventsDto evenement);
        void removeEvent(EventsDto Event);
        Task<EventsDto> getEvenement(int id);
        Task<IEnumerable<EventsDto>> getAllEvenement();
    }
}
