﻿using System.ComponentModel.DataAnnotations;
using Shrooms.Contracts.Constants;

namespace Shrooms.Presentation.WebViewModels.Models.KudosBaskets
{
    public class KudosBasketCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(KudosBasketConstants.KudosBasketMaxTitleLength)]
        public string Title { get; set; }

        [MaxLength(KudosBasketConstants.KudosBasketMaxDescriptionLength)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
