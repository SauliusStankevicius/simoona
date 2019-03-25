﻿using System.Collections.Generic;
using Shrooms.DataTransferObjects.Models.ExternalLinks;

namespace Shrooms.Domain.Services.ExternalLinks
{
    public interface IExternalLinkService
    {
        IEnumerable<ExternalLinkDTO> GetAll(int organizationId);
        void UpdateLinks(AddEditDeleteExternalLinkDTO updateLinksDto);
    }
}
