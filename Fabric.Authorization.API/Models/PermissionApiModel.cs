﻿using System;
using Fabric.Authorization.Domain.Models;

namespace Fabric.Authorization.API.Models
{
    public class PermissionApiModel : IIdentifiable
    {
        public Guid? Id { get; set; }

        public string Grain { get; set; }

        public string SecurableItem { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDateTimeUtc { get; set; }

        public DateTime? ModifiedDateTimeUtc { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public PermissionAction PermissionAction { get; set; }

        public string Identifier => Id.HasValue ? Id.ToString() : "";
    }

    public enum PermissionAction
    {
        Allow,
        Deny
    }
}