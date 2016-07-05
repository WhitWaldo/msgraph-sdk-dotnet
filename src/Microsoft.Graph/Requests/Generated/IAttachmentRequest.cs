// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IAttachmentRequest.
    /// </summary>
    public partial interface IAttachmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Attachment using PUT.
        /// </summary>
        /// <param name="attachmentToCreate">The Attachment to create.</param>
        /// <returns>The created Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> CreateAsync(Attachment attachmentToCreate);        /// <summary>
        /// Creates the specified Attachment using PUT.
        /// </summary>
        /// <param name="attachmentToCreate">The Attachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> CreateAsync(Attachment attachmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Attachment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Attachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Attachment.
        /// </summary>
        /// <returns>The Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> GetAsync();

        /// <summary>
        /// Gets the specified Attachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Attachment using PATCH.
        /// </summary>
        /// <param name="attachmentToUpdate">The Attachment to update.</param>
        /// <returns>The updated Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> UpdateAsync(Attachment attachmentToUpdate);

        /// <summary>
        /// Updates the specified Attachment using PATCH.
        /// </summary>
        /// <param name="attachmentToUpdate">The Attachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> UpdateAsync(Attachment attachmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAttachmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAttachmentRequest Select(string value);

    }
}
