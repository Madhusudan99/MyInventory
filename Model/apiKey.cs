
using System.ComponentModel.DataAnnotations;

namespace MyInventory.Model
{
    public class apiKey
    {
        [Key]
        public string userKey { get; set; }
        public int userId { get; set; }

    }
}
