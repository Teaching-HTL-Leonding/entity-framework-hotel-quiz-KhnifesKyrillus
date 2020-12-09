using System.ComponentModel.DataAnnotations;

namespace HotelExercise.Model
{
    public class Address
    {
        public int Id { get; set; }

        [MaxLength(60)]
        public string Street { get; set; }

        public int ZipCode { get; set; }
        public string City { get; set; }
    }
}