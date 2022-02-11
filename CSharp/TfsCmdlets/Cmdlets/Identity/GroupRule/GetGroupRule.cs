using Microsoft.VisualStudio.Services.Licensing;

namespace TfsCmdlets.Cmdlets.Identity.GroupRule
{
    /// <summary>
    /// Gets one or more Azure DevOps groups.
    /// </summary>
    [TfsCmdlet(CmdletScope.Collection, OutputType = typeof(Microsoft.VisualStudio.Services.Licensing.))]
    partial class GetGroupRule
    {
        /// <summary>
        /// Specifies the group to be retrieved. Supported values are: 
        /// Group name or ID. Wildcards are supported.
        /// </summary>
        [Parameter(Position = 0)]
        [SupportsWildcards]
        public object Group { get; set; } = "*";
    }
}