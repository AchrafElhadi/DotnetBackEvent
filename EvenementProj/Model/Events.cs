using System.ComponentModel.DataAnnotations.Schema;

namespace VoitureAPi2.Model
{
    public class Events
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string ville { get; set; }
        public string description { get; set; }
        public int nb_place { get; set; }
        [Column(TypeName ="date")]
        public DateTime date { get; set; }
    }
}
