// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder.
    /// </summary>
    public partial class DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder : BaseRequestBuilder, IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IImportedAppleDeviceIdentityRequestBuilder"/> for the specified DepOnboardingSettingImportedAppleDeviceIdentity.
        /// </summary>
        /// <param name="id">The ID for the DepOnboardingSettingImportedAppleDeviceIdentity.</param>
        /// <returns>The <see cref="IImportedAppleDeviceIdentityRequestBuilder"/>.</returns>
        public IImportedAppleDeviceIdentityRequestBuilder this[string id]
        {
            get
            {
                return new ImportedAppleDeviceIdentityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ImportedAppleDeviceIdentityImportAppleDeviceIdentityList.
        /// </summary>
        /// <returns>The <see cref="IImportedAppleDeviceIdentityImportAppleDeviceIdentityListRequestBuilder"/>.</returns>
        public IImportedAppleDeviceIdentityImportAppleDeviceIdentityListRequestBuilder ImportAppleDeviceIdentityList(
            bool overwriteImportedDeviceIdentities,
            IEnumerable<ImportedAppleDeviceIdentity> importedAppleDeviceIdentities = null)
        {
            return new ImportedAppleDeviceIdentityImportAppleDeviceIdentityListRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.importAppleDeviceIdentityList"),
                this.Client,
                overwriteImportedDeviceIdentities,
                importedAppleDeviceIdentities);
        }
    }
}