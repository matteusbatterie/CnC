using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNC.Models.Entities
{
    /// <summary>
    /// An Actor is an Artist that participated
    /// as an figurant in a Movie or Serie.
    /// </summary>
    public class Actor
    {
        #region Internal

        [Key]
        public int Id { get; set; }

        #endregion

        #region External

        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }

        #endregion
    }
}