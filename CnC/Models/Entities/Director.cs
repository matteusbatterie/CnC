using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNC.Models.Entities
{
    /// <summary>
    /// A Director is an Artist that participated
    /// in the development of a Movie or Serie as
    /// a director.
    /// </summary>
    public class Director
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