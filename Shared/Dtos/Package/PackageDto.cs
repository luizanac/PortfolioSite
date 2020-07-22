namespace PortfolioSite.Shared.Dtos.Package {
    public class PackageDto {
        public PackageDto () {

        }

        public PackageDto (string name, string description, string url, string language, string version, string commandToInstall) {
            this.Name = name;
            this.Description = description;
            this.Url = url;
            this.Language = language;
            this.Version = version;
            this.CommandToInstall = commandToInstall;

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public string Version { get; set; }
        public string CommandToInstall { get; set; }
    }
}