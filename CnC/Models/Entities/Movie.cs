using CNC.Utils.Enumerations;
using CNC.Utils.Enumerations.Movie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Models.Entities
{
    public class Movie
    {
        #region Internal

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Bilheteria")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BoxOffice { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Duração")]
        public TimeSpan Duration { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        #endregion

        #region External

        [Display(Name = "Gênero")]
        public List<Genre> Genres { get; set; }

        [Display(Name = "Idiomas")]
        public List<Language> Languages { get; set; }

        [NotMapped]
        [Display(Name = "Diretores")]
        public List<Director> Directors { get; set; }

        [NotMapped]
        [Display(Name = "Produtores")]
        public List<Producer> Producers { get; set; }

        [NotMapped]
        [Display(Name = "Elenco")]
        public List<Actor> Cast { get; set; }

        [Display(Name = "Trilhas Sonoras")]
        public List<Music> Soundtracks { get; set; }

        #endregion
    }
}
