
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Model
{
    public class Value
    {
        [Key]
        public int Id { get; set; }
        public string value { get; set; }

        

    }
}