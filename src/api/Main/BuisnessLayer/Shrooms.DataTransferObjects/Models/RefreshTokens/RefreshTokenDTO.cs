﻿using System;

namespace Shrooms.DataTransferObjects.Models.RefreshTokens
{
    public class RefreshTokenDTO
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        public string ProtectedTicket { get; set; }
        public int OrganizationId { get; set; }
    }
}
