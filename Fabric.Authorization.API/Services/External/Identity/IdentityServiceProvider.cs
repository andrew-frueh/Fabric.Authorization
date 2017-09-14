﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fabric.Authorization.API.Configuration;
using Fabric.Authorization.API.Constants;
using Fabric.Authorization.API.Models.External.Identity;
using Fabric.Platform.Http;

namespace Fabric.Authorization.API.Services.External.Identity
{
    public class IdentityServiceProvider : IIdentityServiceProvider
    {
        private readonly IAppConfiguration _appConfiguration;
        private readonly IHttpClientFactory _httpClientFactory;

        public IdentityServiceProvider(IHttpClientFactory httpClientFactory, IAppConfiguration appConfiguration)
        {
            _httpClientFactory = httpClientFactory;
            _appConfiguration = appConfiguration;
        }

        public async Task<IEnumerable<IdentityUserSearchResponse>> Search(IEnumerable<string> subjectIds)
        {
            // get all users in groups tied to clientRoles
            var httpClient =
                await _httpClientFactory.Create(
                    new Uri(_appConfiguration.IdentityServerConfidentialClientSettings.Authority),
                    IdentityScopes.ReadScope);

            var response = await httpClient.GetAsync("users");

            return new List<IdentityUserSearchResponse>();
        }
    }
}