using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1
{
    [Table("Author")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        private long id;

        [Column("firstname")]
        [Required]
        private string firstname;

        [Column("lastname")]
        [Required]
        private string lastname;

        public long Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        [NotMapped]
        public string Fullname
        {
            get { return Firstname + "." + Lastname; }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}