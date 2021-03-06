using System.ComponentModel.DataAnnotations;

namespace MudBlazorTest.Model
{
    public sealed class Meal
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        // Relationships
        public ICollection<Presence> Presences { get; } = new List<Presence>();
        public ICollection<Dish> Dishes { get; } = new List<Dish>();

        public override string ToString()
        {
            return $"Meal of {Date}";
        }
    }
}