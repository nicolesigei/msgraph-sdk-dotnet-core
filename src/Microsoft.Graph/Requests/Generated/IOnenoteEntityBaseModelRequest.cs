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
    /// The interface IOnenoteEntityBaseModelRequest.
    /// </summary>
    public partial interface IOnenoteEntityBaseModelRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnenoteEntityBaseModel using PUT.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToCreate">The OnenoteEntityBaseModel to create.</param>
        /// <returns>The created OnenoteEntityBaseModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityBaseModel> CreateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToCreate);        /// <summary>
        /// Creates the specified OnenoteEntityBaseModel using PUT.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToCreate">The OnenoteEntityBaseModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteEntityBaseModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityBaseModel> CreateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <returns>The OnenoteEntityBaseModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityBaseModel> GetAsync();

        /// <summary>
        /// Gets the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteEntityBaseModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityBaseModel> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnenoteEntityBaseModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToUpdate">The OnenoteEntityBaseModel to update.</param>
        /// <returns>The updated OnenoteEntityBaseModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityBaseModel> UpdateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToUpdate);

        /// <summary>
        /// Updates the specified OnenoteEntityBaseModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToUpdate">The OnenoteEntityBaseModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OnenoteEntityBaseModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityBaseModel> UpdateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityBaseModelRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityBaseModelRequest Expand(Expression<Func<OnenoteEntityBaseModel, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityBaseModelRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityBaseModelRequest Select(Expression<Func<OnenoteEntityBaseModel, object>> selectExpression);

    }
}
