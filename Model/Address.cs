using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace web_yep.Model
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string City { get; set; }
        public int Number { get; set; }

    }
}
