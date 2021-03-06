// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsYieldMatRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsYieldMatRequestBody
    {
    
        /// <summary>
        /// Gets or sets Settlement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settlement", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Settlement { get; set; }
    
        /// <summary>
        /// Gets or sets Maturity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maturity", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Maturity { get; set; }
    
        /// <summary>
        /// Gets or sets Issue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issue", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Issue { get; set; }
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rate", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Pr.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pr", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Pr { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "basis", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
    }
}
