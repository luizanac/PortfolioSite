namespace PortfolioSite.Shared.Base.BaseHeaderComponent {
    public class NavLinkButton {
        public NavLinkButton (string route, string routeName) {
            this.Route = route;
            this.RouteName = routeName;

        }
        public string Route { get; set; }
        public string RouteName { get; set; }
    }
}