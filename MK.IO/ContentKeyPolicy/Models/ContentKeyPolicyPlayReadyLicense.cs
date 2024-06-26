﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace MK.IO.Models
{

    public class ContentKeyPolicyPlayReadyLicense
    {
        public ContentKeyPolicyPlayReadyLicense(PlayReadyContentType contentType, PlayReadyLicenseType licenseType, PlayReadySecurityLevel securityLevel, bool allowTestDevices, ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader contentKeyLocation, ContentKeyPolicyPlayReadyPlayRight playRight)
        {
            ContentType = contentType;
            LicenseType = licenseType;
            SecurityLevel = securityLevel;
            AllowTestDevices = allowTestDevices;
            ContentKeyLocation = contentKeyLocation;
            PlayRight = playRight;
        }

        /// <summary>
        /// A flag indicating whether test devices can use the license.
        /// </summary>
        /// <value>A flag indicating whether test devices can use the license.</value>
        [JsonProperty("allowTestDevices")]
        public bool? AllowTestDevices { get; set; }

        /// <summary>
        /// The begin date of license
        /// </summary>
        /// <value>The begin date of license</value>
        [JsonProperty(PropertyName = "beginDate")]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The content key location.
        /// </summary>
        /// <value>The content key location.</value>
        [JsonProperty("contentKeyLocation")]
        public PlayReadyContentKeyLocation ContentKeyLocation { get; set; }

        /// <summary>
        /// The PlayReady content type.
        /// </summary>
        /// <value>The PlayReady content type.</value>
        [JsonProperty("contentType")]
        public PlayReadyContentType ContentType { get; set; }

        /// <summary>
        /// The expiration date of license.
        /// </summary>
        /// <value>The expiration date of license.</value>
        [JsonProperty(PropertyName = "expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The grace period of license.
        /// </summary>
        /// <value>The grace period of license.</value>
        [JsonProperty("gracePeriod")]
        public string GracePeriod { get; set; }

        /// <summary>
        /// The license type.
        /// </summary>
        /// <value>The license type.</value>
        [JsonProperty("licenseType")]
        public PlayReadyLicenseType LicenseType { get; set; }

        /// <summary>
        /// Gets or Sets PlayRight
        /// </summary>
        [JsonProperty("playRight")]
        public ContentKeyPolicyPlayReadyPlayRight PlayRight { get; set; }

        /// <summary>
        /// The relative begin date of license.
        /// </summary>
        /// <value>The relative begin date of license.</value>
        [JsonProperty("relativeBeginDate")]
        public string RelativeBeginDate { get; set; }

        /// <summary>
        /// The security level.
        /// </summary>
        /// <value>The security level.</value>
        [JsonProperty("securityLevel")]
        public PlayReadySecurityLevel SecurityLevel { get; set; }

        /// <summary>
        /// The relative expiration date of license.
        /// </summary>
        /// <value>The relative expiration date of license.</value>
        [JsonProperty("relativeExpirationDate")]
        public string RelativeExpirationDate { get; set; }
    }
}