using System.ComponentModel.DataAnnotations;

namespace TestEF062325
{
    public class car
    {
        [Key]
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
    }
}
