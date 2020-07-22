using System;
using System.Text.Json.Serialization;

namespace PortfolioSite.Shared.Dtos.Git {
    public class GitHubRepo {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName ("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName ("html_url")]
        public string Url { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        [JsonPropertyName ("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName ("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}