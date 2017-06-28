﻿using System;
using System.Collections.Generic;

namespace Fabric.Authorization.API.Models
{
    public class RoleApiModel : IIdentifiable
    {
        public Guid? Id { get; set; }
        public string Grain { get; set; }
        public string SecurableItem { get; set; }
        public string Name { get; set; }
        public RoleApiModel ParentRole { get; set; }
        public IEnumerable<PermissionApiModel> Permissions { get; set; }
        public IEnumerable<PermissionApiModel> DeniedPermissions { get; set; }
        public IEnumerable<RoleApiModel> ChildRoles { get; set; }
        public DateTime CreatedDateTimeUtc { get; set; }
        public DateTime? ModifiedDateTimeUtc { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public string Identifier => Id.HasValue ? Id.ToString() : "";
    }
}