using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Models.Entities
{
    public class Season
    {
        #region Internal

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Número da Temporada")]
        public int Number { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        #endregion

        #region External

        [ForeignKey("SerieId")]
        [Display(Name = "Série")]
        public Serie Serie { get; set; }
        public int SerieId { get; set; } // FK

        [Display(Name = "Episódios")]
        public List<Episode> Episodes { get; set; }

        #endregion
    }
}
