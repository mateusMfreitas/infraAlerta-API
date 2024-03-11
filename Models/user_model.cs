using System.ComponentModel.DataAnnotations;
namespace infraAlerta.Models
{
    public class User{
        [Key]
        public int user_id{get;set;}
        public string name {get;set;}
        public string cpf{get;set;}
        public string phone{get;set;}
        public bool admin{get;set;}
    }
}