using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1
{
    [Table("book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        private long id;

        [Column("name")]
        [Required]
        private string name;

        [Column("nb_page")]
        [Required]
        private int nb_page;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Nb_page { get => nb_page; set => nb_page = value; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
