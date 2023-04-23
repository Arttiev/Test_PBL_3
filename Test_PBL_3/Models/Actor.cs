using System.ComponentModel.DataAnnotations;

namespace Test_PBL_3.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Full Name")]
        public string name { get;set; }
		[Display(Name = "Biography")]
		public string Bio { get;set; }
		[Display(Name = "Profile Picture URL")]
        public string url { get;set; }         
        //
        public virtual ICollection<Actor_Movie> Actor_Movies { get; set; }
        public Actor()
        {
            Actor_Movies = new HashSet<Actor_Movie>();
        }
    }
}
