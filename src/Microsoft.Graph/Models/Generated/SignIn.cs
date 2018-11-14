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
    /// The type Sign In.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SignIn : Entity
    {
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipAddress", Required = Newtonsoft.Json.Required.Default)]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public SignInStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets client app used.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientAppUsed", Required = Newtonsoft.Json.Required.Default)]
        public string ClientAppUsed { get; set; }
    
        /// <summary>
        /// Gets or sets device detail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDetail", Required = Newtonsoft.Json.Required.Default)]
        public DeviceDetail DeviceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets mfa detail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mfaDetail", Required = Newtonsoft.Json.Required.Default)]
        public MfaDetail MfaDetail { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "correlationId", Required = Newtonsoft.Json.Required.Default)]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessStatus", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets is risky.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isRisky", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsRisky { get; set; }
    
        /// <summary>
        /// Gets or sets risk level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskLevel", Required = Newtonsoft.Json.Required.Default)]
        public RiskLevel? RiskLevel { get; set; }
    
    }
}
