using System.ComponentModel.DataAnnotations;
namespace infraAlerta.Models
{
    public class User{
        [Key]
        [StringLength(2, MinimumLength =2, ErrorMessage ="O campo deve ter 2 caracteress")]
        public string Nome {get;set;}
    }
}