// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type UserCreatedObjectsCollectionWithReferencesPage.
    /// </summary>
    public partial class UserCreatedObjectsCollectionWithReferencesPage : CollectionPage<DirectoryObject>, IUserCreatedObjectsCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IUserCreatedObjectsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IUserCreatedObjectsCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new UserCreatedObjectsCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
