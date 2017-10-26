using System.ComponentModel.DataAnnotations;

namespace aspnet4_sample.Models
{
    public class GreetModel
    {
        [Required]
        public string Name { get; set; }
        public string Greeting { get; set; }
    }
}