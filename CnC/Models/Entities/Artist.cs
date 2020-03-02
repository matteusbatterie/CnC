using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CNC.Utils.Artist;

namespace CNC.Models.Entities
{
    public class Artist
    {
        #region Internal

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; } // PK

        [Display(Name = "Idade")]
        public int Age { get; set; }
        
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Biografia")]
        public string Biografy { get; set; }

        #endregion

        #region External

        [Display(Name = "Filmes")]
        public ICollection<Movie> Movies { get; set; }

        [Display(Name = "Séries")]
        public ICollection<Serie> Series { get; set; }

        [Display(Name = "Músicas")]
        public ICollection<Music> Songs { get; set; }

        #endregion
    }
}
