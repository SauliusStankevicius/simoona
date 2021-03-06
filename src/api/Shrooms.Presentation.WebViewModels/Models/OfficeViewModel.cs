﻿using System.Collections.Generic;
using System.Linq;
using Shrooms.Contracts.ViewModels;

namespace Shrooms.Presentation.WebViewModels.Models
{
    public class OfficeViewModel : AbstractViewModel
    {
        public bool IsDefault { get; set; }

        public string Name { get; set; }

        public AddressViewModel Address { get; set; }

        public virtual IEnumerable<FloorViewModel> Floors { get; set; }

        public int FloorsCount => Floors?.Count() ?? 0;

        public int RoomsCount { get; set; }

        public int ApplicationUsersCount { get; set; }
    }
}