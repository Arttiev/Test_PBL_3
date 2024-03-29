﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_PBL_3.Models
{
    [PrimaryKey("MovieID","ActorID")]
    public class Actor_Movie
    {

        public int MovieID {get; set; }
        [ForeignKey("MovieID")]
        public virtual Movie Movie { get; set; }
        [Key]
        public int ActorID { get; set; }
        [ForeignKey("ActorID")]
        public virtual Actor Actor { get; set; }

    }
}
