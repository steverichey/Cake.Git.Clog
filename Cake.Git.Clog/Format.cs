// <copyright file="Format.cs" company="Float">
// Copyright (c) 2020 Float, All rights reserved.
// Shared under an MIT license. See license.md for details.
// </copyright>

namespace Cake.Git.Clog
{
    /// <summary>
    /// Valid output formats.
    /// </summary>
    public enum Format
    {
        /// <summary>
        /// Hash identifiers for the commits.
        /// </summary>
        Commits,

        /// <summary>
        /// Log of the changes.
        /// </summary>
        Changes,

        /// <summary>
        /// Referenced Assembla ticket numbers.
        /// </summary>
        Tickets,

        /// <summary>
        /// URLs to the referenced tickets.
        /// </summary>
        Urls,

        /// <summary>
        /// URLs to the merge requests.
        /// </summary>
        MergeRequests,
    }
}
