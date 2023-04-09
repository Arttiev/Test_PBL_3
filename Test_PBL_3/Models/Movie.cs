using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test_PBL_3.Data.Enum;

namespace Test_PBL_3.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imgUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Movie_category Movie_Category { get; set; }  
        // relation 

        public ICollection<Actor_Movie> Actor_Movies { get; set; }

        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }
    }
}
