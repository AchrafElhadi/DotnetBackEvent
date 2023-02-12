using AutoMapper;
using Evenement.Model.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VoitureApi.Model;
using VoitureAPi2.Model;

namespace VoitureAPi2.Services
{
    public class EvenementService : IEvenement
    {
        MyDatabaseContext myDatabase;
        IMapper mapper;
        public EvenementService(MyDatabaseContext myDatabase,IMapper mapper)
        {
            this.myDatabase = myDatabase;
            this.mapper = mapper;
        }
        public async Task<EventsDto> addUpdateEvent(EventsDto evenement)
        {
            if (evenement == null)
                throw new Exception("Categorie null");
            if (evenement.Id == 0)
                myDatabase.evenements.Add(mapper.Map<Events>(evenement));
            else
                myDatabase.evenements.Update(mapper.Map<Events>(evenement));
             myDatabase.SaveChanges();
            return evenement;
        }

        public async Task<IEnumerable<EventsDto>> getAllEvenement()
        {
            return mapper.Map< IEnumerable < EventsDto >>( await myDatabase.evenements.ToListAsync());
        }

        
        public async Task<EventsDto> getEvenement(int id)
        {
            Events e = await myDatabase.evenements.FirstOrDefaultAsync(x => x.Id == id);
            if (e == null)
                throw new Exception("Not found");
            return mapper.Map<EventsDto>(e);
        }

        public void removeEvent(EventsDto Event)
        {
            Events ev = mapper.Map<Events>(Event);
            myDatabase.evenements.Remove(ev);
            myDatabase.SaveChanges();
        }
    }
}
