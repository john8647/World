using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.ViewModels
{
    public class LoginViewModel
    {
            [Required]
            [StringLength(100, MinimumLength = 5)]
            public string Username { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Password { get; set; }

    }
}
