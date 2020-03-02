using CNC.Utils.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Models.Entities
{
    public class Serie
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

        [Display(Name = "Em Andamento")]
        public bool OnGoing { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Término")]
        public DateTime FinalDate { get; set; }

        #endregion

        #region External

        [Display(Name = "Idiomas")]
        public List<Language> Languages { get; set; }

        [Required]
        [Display(Name = "Gêneros")]
        public List<Genre> Genres { get; set; }

        [Display(Name = "Episódios")]
        public List<Episode> Episodes { get; set; }

        [Display(Name = "Temporadas")]
        public List<Season> Seasons { get; set; }

        [Display (Name = "Diretores")]
        public List<Director> Directors { get; set; }

        [Display(Name = "Produtores")]
        public List<Producer> Producers { get; set; }

        [Display(Name = "Elenco")]
        public List<Actor> Cast { get; set; }

        [Display(Name = "Trilha Sonora")]
        public List<Music> Sountracks { get; set; }

        #endregion
    }
}
