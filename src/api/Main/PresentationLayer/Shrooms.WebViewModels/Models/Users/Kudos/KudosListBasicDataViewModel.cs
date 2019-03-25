﻿using System.Collections.Generic;
using Shrooms.WebViewModels.Models.Kudos;

namespace Shrooms.WebViewModels.Models.Users.Kudos
{
    public class KudosListBasicDataViewModel
    {
        public IEnumerable<KudosBasicDataViewModel> Users { get; set; }

        public int Months { get; set; }
    }
}
