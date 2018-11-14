// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OfficeClientConfigurationRequest.
    /// </summary>
    public partial class OfficeClientConfigurationRequest : BaseRequest, IOfficeClientConfigurationRequest
    {
        /// <summary>
        /// Constructs a new OfficeClientConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OfficeClientConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OfficeClientConfiguration using POST.
        /// </summary>
        /// <param name="officeClientConfigurationToCreate">The OfficeClientConfiguration to create.</param>
        /// <returns>The created OfficeClientConfiguration.</returns>
        public System.Threading.Tasks.Task<OfficeClientConfiguration> CreateAsync(OfficeClientConfiguration officeClientConfigurationToCreate)
        {
            return this.CreateAsync(officeClientConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OfficeClientConfiguration using POST.
        /// </summary>
        /// <param name="officeClientConfigurationToCreate">The OfficeClientConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OfficeClientConfiguration.</returns>
        public async System.Threading.Tasks.Task<OfficeClientConfiguration> CreateAsync(OfficeClientConfiguration officeClientConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OfficeClientConfiguration>(officeClientConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified OfficeClientConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OfficeClientConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OfficeClientConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OfficeClientConfiguration.
        /// </summary>
        /// <returns>The OfficeClientConfiguration.</returns>
        public System.Threading.Tasks.Task<OfficeClientConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OfficeClientConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OfficeClientConfiguration.</returns>
        public async System.Threading.Tasks.Task<OfficeClientConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OfficeClientConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OfficeClientConfiguration using PATCH.
        /// </summary>
        /// <param name="officeClientConfigurationToUpdate">The OfficeClientConfiguration to update.</param>
        /// <returns>The updated OfficeClientConfiguration.</returns>
        public System.Threading.Tasks.Task<OfficeClientConfiguration> UpdateAsync(OfficeClientConfiguration officeClientConfigurationToUpdate)
        {
            return this.UpdateAsync(officeClientConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OfficeClientConfiguration using PATCH.
        /// </summary>
        /// <param name="officeClientConfigurationToUpdate">The OfficeClientConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OfficeClientConfiguration.</returns>
        public async System.Threading.Tasks.Task<OfficeClientConfiguration> UpdateAsync(OfficeClientConfiguration officeClientConfigurationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OfficeClientConfiguration>(officeClientConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeClientConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeClientConfigurationRequest Expand(Expression<Func<OfficeClientConfiguration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeClientConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeClientConfigurationRequest Select(Expression<Func<OfficeClientConfiguration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="officeClientConfigurationToInitialize">The <see cref="OfficeClientConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OfficeClientConfiguration officeClientConfigurationToInitialize)
        {

            if (officeClientConfigurationToInitialize != null && officeClientConfigurationToInitialize.AdditionalData != null)
            {

                if (officeClientConfigurationToInitialize.Assignments != null && officeClientConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    officeClientConfigurationToInitialize.Assignments.AdditionalData = officeClientConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    officeClientConfigurationToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        officeClientConfigurationToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}