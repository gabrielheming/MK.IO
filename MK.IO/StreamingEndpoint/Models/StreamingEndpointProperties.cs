﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace MK.IO
{
    public class StreamingEndpointProperties
    {
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }

        [JsonProperty("resourceState")]
        public string ResourceState { get; set; }

        [JsonProperty("scaleUnits")]
        public int ScaleUnits { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("accessControl")]
        public object AccessControl { get; set; }

        [JsonProperty("cdnEnabled")]
        public bool CdnEnabled { get; set; }

        [JsonProperty("hostName")]
        public string HostName { get; set; }

        [JsonProperty("customHostNames")]
        public List<string> CustomHostNames { get; set; }

        [JsonProperty("maxCacheAge")]
        public int? MaxCacheAge { get; set; }

        [JsonProperty("crossSiteAccessPolicies")]
        public object CrossSiteAccessPolicies { get; set; }

        [JsonProperty("sku")]
        public StreamingEndpointSku Sku { get; set; }
    }
}