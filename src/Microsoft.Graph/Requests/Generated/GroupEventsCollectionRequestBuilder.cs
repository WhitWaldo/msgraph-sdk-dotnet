// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupEventsCollectionRequestBuilder.
    /// </summary>
    public partial class GroupEventsCollectionRequestBuilder : BaseRequestBuilder, IGroupEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GroupEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEventRequestBuilder"/> for the specified GroupEvent.
        /// </summary>
        /// <param name="id">The ID for the GroupEvent.</param>
        /// <returns>The <see cref="IEventRequestBuilder"/>.</returns>
        public IEventRequestBuilder this[string id]
        {
            get
            {
                return new EventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
