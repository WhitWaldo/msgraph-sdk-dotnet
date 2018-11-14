// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIntuneBrandingProfileRequest.
    /// </summary>
    public partial interface IIntuneBrandingProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IntuneBrandingProfile using PUT.
        /// </summary>
        /// <param name="intuneBrandingProfileToCreate">The IntuneBrandingProfile to create.</param>
        /// <returns>The created IntuneBrandingProfile.</returns>
        System.Threading.Tasks.Task<IntuneBrandingProfile> CreateAsync(IntuneBrandingProfile intuneBrandingProfileToCreate);        /// <summary>
        /// Creates the specified IntuneBrandingProfile using PUT.
        /// </summary>
        /// <param name="intuneBrandingProfileToCreate">The IntuneBrandingProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IntuneBrandingProfile.</returns>
        System.Threading.Tasks.Task<IntuneBrandingProfile> CreateAsync(IntuneBrandingProfile intuneBrandingProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IntuneBrandingProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IntuneBrandingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IntuneBrandingProfile.
        /// </summary>
        /// <returns>The IntuneBrandingProfile.</returns>
        System.Threading.Tasks.Task<IntuneBrandingProfile> GetAsync();

        /// <summary>
        /// Gets the specified IntuneBrandingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IntuneBrandingProfile.</returns>
        System.Threading.Tasks.Task<IntuneBrandingProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IntuneBrandingProfile using PATCH.
        /// </summary>
        /// <param name="intuneBrandingProfileToUpdate">The IntuneBrandingProfile to update.</param>
        /// <returns>The updated IntuneBrandingProfile.</returns>
        System.Threading.Tasks.Task<IntuneBrandingProfile> UpdateAsync(IntuneBrandingProfile intuneBrandingProfileToUpdate);

        /// <summary>
        /// Updates the specified IntuneBrandingProfile using PATCH.
        /// </summary>
        /// <param name="intuneBrandingProfileToUpdate">The IntuneBrandingProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IntuneBrandingProfile.</returns>
        System.Threading.Tasks.Task<IntuneBrandingProfile> UpdateAsync(IntuneBrandingProfile intuneBrandingProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIntuneBrandingProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIntuneBrandingProfileRequest Expand(Expression<Func<IntuneBrandingProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIntuneBrandingProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIntuneBrandingProfileRequest Select(Expression<Func<IntuneBrandingProfile, object>> selectExpression);

    }
}