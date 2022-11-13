using System.ComponentModel.DataAnnotations.Schema;

namespace Toplicean_Iustina_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Disply(nameof = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
    }
}
