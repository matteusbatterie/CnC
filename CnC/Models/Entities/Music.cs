using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Models.Entities
{
    public class Music
    {
        #region Internal

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Gênero")]
        public string Genre { get; set; }

        [Display(Name = "Explícito")]
        public bool Explicit { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Duração")]
        public TimeSpan Duration { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        #endregion

        #region External

        [Display(Name = "Letra")]
        public Lyric Lyrics { get; set; }

        [NotMapped]
        [Display(Name = "Artistas")]
        public List<Author> Authors { get; set; }

        #endregion
    }
}
