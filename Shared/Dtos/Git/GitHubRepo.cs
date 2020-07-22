using System;
using Newtonsoft.Json;

namespace PortfolioSite.Shared.Dtos.Git {
    public class GitHubRepo {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty ("full_name")]
        public string FullName { get; set; }

        [JsonProperty ("html_url")]
        public string Url { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        [JsonProperty ("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty ("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}