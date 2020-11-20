// <copyright file="Alias.Git.Clog.cs" company="Float">
// Copyright (c) 2020 Float, All rights reserved.
// Shared under an MIT license. See license.md for details.
// </copyright>

using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Git.Clog
{
    /// <summary>
    /// Contains aliases for clog.
    /// </summary>
    [CakeAliasCategory("git clog")]
    public static class ClogAliases
    {
        /// <summary>
        /// Run clog in the given directory.
        /// </summary>
        /// <code>
        /// Task("GitClog")
        ///   .Does( => {
        ///     GitClog(new ClogSettings { FromLatestTag = true });
        ///   });
        /// </code>
        /// <param name="context">The current Cake context.</param>
        /// <param name="settings">Settings for clog.</param>
        /// <returns>The standard output.</returns>
        [CakeMethodAlias]
        public static IEnumerable<string> GitClogWithResult(this ICakeContext context, GitClogSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var runner = new GitClogRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            return runner.RunWithResult(settings);
        }
    }
}
