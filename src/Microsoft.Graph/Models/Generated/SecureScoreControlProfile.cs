// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Secure Score Control Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SecureScoreControlProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets action type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionType", Required = Newtonsoft.Json.Required.Default)]
        public string ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets action url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ActionUrl { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets compliance information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceInformation", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ComplianceInformation> ComplianceInformation { get; set; }
    
        /// <summary>
        /// Gets or sets control category.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "controlCategory", Required = Newtonsoft.Json.Required.Default)]
        public string ControlCategory { get; set; }
    
        /// <summary>
        /// Gets or sets control state updates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "controlStateUpdates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SecureScoreControlStateUpdate> ControlStateUpdates { get; set; }
    
        /// <summary>
        /// Gets or sets deprecated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deprecated", Required = Newtonsoft.Json.Required.Default)]
        public bool? Deprecated { get; set; }
    
        /// <summary>
        /// Gets or sets implementation cost.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "implementationCost", Required = Newtonsoft.Json.Required.Default)]
        public string ImplementationCost { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets max score.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxScore", Required = Newtonsoft.Json.Required.Default)]
        public double? MaxScore { get; set; }
    
        /// <summary>
        /// Gets or sets rank.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rank", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Rank { get; set; }
    
        /// <summary>
        /// Gets or sets remediation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediation", Required = Newtonsoft.Json.Required.Default)]
        public string Remediation { get; set; }
    
        /// <summary>
        /// Gets or sets remediation impact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediationImpact", Required = Newtonsoft.Json.Required.Default)]
        public string RemediationImpact { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service", Required = Newtonsoft.Json.Required.Default)]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets threats.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "threats", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Threats { get; set; }
    
        /// <summary>
        /// Gets or sets tier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tier", Required = Newtonsoft.Json.Required.Default)]
        public string Tier { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets user impact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userImpact", Required = Newtonsoft.Json.Required.Default)]
        public string UserImpact { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInformation", Required = Newtonsoft.Json.Required.Default)]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}
