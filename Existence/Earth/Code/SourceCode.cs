using System;
using Existence.Earth.Alphabet;

namespace Existence.Earth.Code
{
    public enum CloudRepositoryGitProvider
    {
        Bitbucket,
        GitHub,
    }

    public class SourceCodeRepositoryUserAttribute : Attribute
    {
        public CloudRepositoryGitProvider ProviderType { get; set; }
        public string UserName { get; set; }
        public SourceCodeRepositoryUserAttribute(CloudRepositoryGitProvider ProviderType, string UserName)
        {
            this.ProviderType = ProviderType;
            this.UserName = UserName;
        }
    }

    public class RepositoryNameAttribute : TextAttribute
    {
        public string Name
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public RepositoryNameAttribute(string Name) : base(Name)
        {
        }
    }
}
