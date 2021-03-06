﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZHS.WebApi.Models
{
    public class ValidateModel
    {
        [Required(ErrorMessage = "数字是必需的")]
        [Range(1,1000,ErrorMessage ="数字必须在1到1000之间")]
        public Int32? Num { get; set; }

        public String Test { get; set; }
    }
}
