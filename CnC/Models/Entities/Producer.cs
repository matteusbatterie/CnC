using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNC.Models.Entities
{
    /// <summary>
    /// A Producer is an Artist that participated
    /// in the development of some Movie or Serie
    /// as a producer.
    /// </summary>
    public class Producer
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