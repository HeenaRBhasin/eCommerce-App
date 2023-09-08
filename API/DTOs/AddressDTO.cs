using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class AddressDTO
    {
        [Required]
        public string FirstName { get; set; }
		        public string FirstName1 { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string Street { get; set; }

        public string Street1   { get; set; }
        
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zipcode { get; set; }
    }
}