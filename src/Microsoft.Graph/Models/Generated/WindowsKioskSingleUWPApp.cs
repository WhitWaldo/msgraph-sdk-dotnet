// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsKioskSingleUWPApp.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsKioskSingleUWPApp : WindowsKioskAppConfiguration
    {

        /// <summary>
        /// Gets or sets uwpApp.
        /// This is the only Application User Model ID (AUMID) that will be available to launch use while in Kiosk Mode
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uwpApp", Required = Newtonsoft.Json.Required.Default)]
        public WindowsKioskUWPApp UwpApp { get; set; }
    
    }
}