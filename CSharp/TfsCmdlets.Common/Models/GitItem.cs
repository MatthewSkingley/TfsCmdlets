namespace TfsCmdlets.Models
{
    public class GitItem : ModelBase<Microsoft.TeamFoundation.SourceControl.WebApi.GitItem>
    {
        public GitItem(Microsoft.TeamFoundation.SourceControl.WebApi.GitItem item, string project, string repository, Dictionary<string, bool> settings = null) : base(item)
        {
            Project = project;
            Repository = repository;
            Settings = settings ?? new Dictionary<string, bool>();
        }

        public string Project
        {
            get => this.GetProperty("Project").Value as string;
            set => this.SetProperty("Project", value);
        }

        public string Repository
        {
            get => this.GetProperty("Repository").Value as string;
            set => this.SetProperty("Repository", value);
        }

        public Dictionary<string, bool> Settings
        {
            get => this.GetProperty("Settings").Value as Dictionary<string, bool>;
            set => this.SetProperty("Settings", value);
        }
    }
}