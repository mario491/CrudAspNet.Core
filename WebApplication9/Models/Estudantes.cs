using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;

namespace WebApplication9.Models
{

    [Table ("Estudantes")]
    public class Estudantes
    {
        [Key]
       public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }

    }
}
