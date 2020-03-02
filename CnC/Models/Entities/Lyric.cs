using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Models.Entities
{
    public class Lyric
    {
        #region Internal

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }
        
        [Display(Name = "Texto")]
        public string Text { get; set; }

        #endregion

        #region External

        [ForeignKey("MusicId")]
        [Display(Name = "Música")]
        public Music Music { get; set; }
        public int MusicId { get; set; }

        #endregion
    }
}
