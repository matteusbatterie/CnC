using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNC.Models.Entities
{
    /// <summary>
    /// An Author is a type of artist responsible for 
    /// producing or participating in the development
    /// of some work.
    /// </summary>
    public class Author
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