using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        [Display(Name = "Ulica")]
        [StringLength(85, MinimumLength = 4), Required(ErrorMessage = "Pole jest obowiązkowe.")]
        public string Street { get; set; }
        [Display(Name = "Kod pocztowy")]
        [StringLength(6, MinimumLength = 6), Required(ErrorMessage = "Pole jest obowiązkowe.")]
        public string ZipCode { get; set; }
        [Display(Name = "Miasto")]
        [StringLength(85), Required(ErrorMessage = "Pole jest obowiązkowe.")]
        public string City { get; set; }
        [Display(Name = "Numer")]
        [Required(ErrorMessage = "Pole jest obowiązkowe.")]
        public int Number { get; set; }
    }
}
