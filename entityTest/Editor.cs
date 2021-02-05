using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1
{
    [Table("Editor")]
    public class Editor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        private long id;

        [Column("name")]
        [Required]
        private string name;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
