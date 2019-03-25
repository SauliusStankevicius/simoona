﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shrooms.WebViewModels.Models
{
    public class CertificatePostViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public bool InProgress { get; set; }

        public IEnumerable<ExamPostViewModel> Exams { get; set; }
    }
}