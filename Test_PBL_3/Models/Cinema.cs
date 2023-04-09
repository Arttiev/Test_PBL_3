using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_PBL_3.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        public string logo { get; set; }
        public string name { get; set; }    
        public string description { get; set; }

        // relation 
        public int MovieID { get; set; }
        [ForeignKey("MovieID")]
        public List<Movie> movies { get; set; }

    }
}
