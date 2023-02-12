namespace Evenement.Model.Dto
{
    public class EventsDto
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string ville { get; set; }
        public string description { get; set; }
        public int nb_place { get; set; }
        public DateTime date { get; set; }
    }
}
