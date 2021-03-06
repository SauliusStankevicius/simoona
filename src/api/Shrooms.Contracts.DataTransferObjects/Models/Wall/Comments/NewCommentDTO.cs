﻿using System.Collections.Generic;

namespace Shrooms.Contracts.DataTransferObjects.Models.Wall.Comments
{
    public class NewCommentDTO : UserAndOrganizationDTO
    {
        public int PostId { get; set; }
        public string MessageBody { get; set; }
        public string PictureId { get; set; }

        public IEnumerable<string> MentionedUserIds { get; set; }
    }
}
