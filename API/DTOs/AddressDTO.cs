using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class AddressDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zipcode { get; set; }

        public string Zipcode1 { get; set; }

        public string Zipcode2 { get; set; }

        public string Zipcode3 { get; set; }

		
		public string City2 { get; set; }
		
		public string City3 { get; set; }
    }
}