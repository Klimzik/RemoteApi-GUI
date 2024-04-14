using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class CatFact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string fact { get; set; }
        public int length { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Fact: {fact}, Length: {length}";
        }

    }
}
