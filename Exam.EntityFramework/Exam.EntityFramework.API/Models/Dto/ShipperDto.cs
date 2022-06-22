﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.EntityFramework.API.Models.Dto
{
    public class ShipperDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        [Display(Name = "Nombre *")]
        public string Name { get; set; }
    }
}