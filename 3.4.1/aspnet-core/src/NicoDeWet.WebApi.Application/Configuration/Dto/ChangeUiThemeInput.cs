﻿using System.ComponentModel.DataAnnotations;

namespace NicoDeWet.WebApi.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
