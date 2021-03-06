﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Magenic.BadgeApplication.Common.DTO;

namespace Magenic.BadgeApplication.Common.Interfaces
{
    /// <summary>
    /// Data Access Layer interface to load for classes implementing <see cref="IApproveActivityCollection"/>.
    /// </summary>
    public interface IApproveActivityManagerCollectionDAL
    {
        /// <summary>
        /// Asynchronously returns a <see cref="System.Collections.Generic.IEnumerable&lt;IApproveActivityItemDTO&gt;" />
        /// for the specified badge type.
        /// </summary>
        /// <param name="criteria">The employee Id of the manager to get badge submission for and a reference to an object
        /// to resolve out what badges may be awarded.</param>
        /// <returns>
        /// A <see cref="System.Collections.Generic.IEnumerable&lt;IApproveActivityItemDTO&gt;" />.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<IEnumerable<ApproveActivityItemDTO>> GetActivitiesToApproveForManagerAsync(IApproveActivityCollectionCriteria criteria);

        /// <summary>
        /// Updates list of activity submissions for a manager's employees 
        /// based on information passed in via the DTO.
        /// </summary>
        /// <param name="data">The values to update.</param>
        /// <returns>A DTO with updated values after the save.</returns>
        IEnumerable<ApproveActivityItemDTO> Update(IEnumerable<ApproveActivityItemDTO> data);
    }
}
