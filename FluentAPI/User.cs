using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI
{
    //[Table("_users")]
    public class User
    {
        //[Column("ID")]
        //[Key]
        public int Id { get; set; }

        //[Column("login")]
        //[Required]
        //[StringLength(8, MinimumLength = 3)]
        public string Login { get; set; }

        //[Column("passw")]
        //[Required]
        //[MinLength(6)]
        public string Password { get; set; }
    }
}
