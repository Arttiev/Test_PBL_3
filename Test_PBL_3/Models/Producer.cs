using System.ComponentModel.DataAnnotations;

namespace Test_PBL_3.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string Bio { get; set; }

        // relation
        public ICollection<Movie> Movies { get; set; }

    }
}
