﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otlob.Core.ViewModel
{
    public class ApplicationUserlVM
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string UserName { get; set; }

        [Required,MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "There is no match with Password")]
        public string ConfirmPassword { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; }

        [Required, Display(Name = "Phone")]
        [MaxLength(11)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{1,11}$", ErrorMessage = "The phone number must contain only numbers and be up to 11 digits long.")]
        public string PhoneNumber { get; set; }
    }
}
