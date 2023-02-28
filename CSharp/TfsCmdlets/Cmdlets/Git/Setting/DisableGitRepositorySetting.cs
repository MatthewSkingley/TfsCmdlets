using System.Management.Automation;
using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace TfsCmdlets.Cmdlets.Git
{
    /// <summary>
    /// Disables one or more Git repository settings.
    /// </summary>
    [TfsCmdlet(CmdletScope.Project, SupportsShouldProcess = true, OutputType = typeof(GitRepository))]
    partial class DisableGitRepositorySetting
    {
        /// <summary>
        /// Specifies one or more Git repository settings to enable.
        /// </summary>
        [Parameter(Position = 0, Mandatory = true)]
        public RepositorySetting Setting { get; set; }

        /// <summary>
        /// Specifies the name or ID of a Git repository. Wildcards are supported. 
        /// </summary>
        [Parameter(ValueFromPipeline = true)]
        [SupportsWildcards()]
        [Alias("Name")]
        public object Repository { get; set; }
    }
}