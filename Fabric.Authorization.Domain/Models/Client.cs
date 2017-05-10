﻿using System;

namespace Fabric.Authorization.Domain.Models
{
    public class Client : ITrackable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public SecurableItem TopLevelSecurableItem { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDateTimeUtc { get; set; }
        public DateTime? ModifiedDateTimeUtc { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
