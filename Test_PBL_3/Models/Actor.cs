using System.ComponentModel.DataAnnotations;

namespace Test_PBL_3.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string url { get;set; }
        public string name { get;set; } 
        public string Bio { get;set; }
        //
        public ICollection<Actor_Movie> Actor_Movies { get; set; }

    }
}
