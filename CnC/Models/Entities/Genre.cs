using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Models.Entities
{
    public class Genre
    {
        #region Internal

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        #endregion
    }
}
