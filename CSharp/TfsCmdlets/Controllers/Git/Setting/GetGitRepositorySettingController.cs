using Microsoft.TeamFoundation.SourceControl.WebApi;
using TfsCmdlets.HttpClient;

namespace TfsCmdlets.Controllers.Git
{
    [CmdletController(typeof(GitRepository))]
    partial class GetGitRepositorySettingController
    {
        protected override IEnumerable Run()
        {
            var repos = GetItems<GitRepository>();

            foreach(var repo in repos)
            {
                
            }
            return null;
        }
    }
}