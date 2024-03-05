﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace MK.IO
{
    public class ContentKeyPolicyUnknownRestriction : ContentKeyPolicyRestriction
    {
        public ContentKeyPolicyUnknownRestriction()
        {
        }

        [JsonProperty("@odata.type")]
        internal override string OdataType => "#Microsoft.Media.ContentKeyPolicyUnknownRestriction";
    }
}