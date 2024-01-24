namespace BlazorProTemplate.Components.Layout.Sidebar;

public class SidebarData
{

    public static List<MenuItem> GetStandardMenuItems() => new()
    {
        new MenuItem(href:"/home", title: "Home", icon:"ri-home-3-fill"),
        new MenuItem(href:"/counter", title: "Counter", icon:"ri-add-box-fill"),
        new MenuItem(href:"/weather", title: "Weather", icon:"ri-bar-chart-horizontal-line"),
    };

    public static List<MenuItem> GetGeneralMenuItems() => new()
    {
        new(href:"#", title:"Components", icon:"ri-vip-diamond-fill", suffix: new("Hot", "primary"), childMenuItems:
        [
            new MenuItem(href:"#", title:"Grid"),
            new MenuItem(href:"#", title:"Layout", childMenuItems:
            [
                new MenuItem(href:"#", title:"Forms", childMenuItems:
                [
                   new MenuItem(href:"#", title:"Input"),
                   new MenuItem(href:"#", title:"Select"),
                   new MenuItem(href:"#", title:"More", childMenuItems:
                   [
                       new MenuItem(href:"#", title:"CheckBox"),
                       new MenuItem(href:"#", title:"Radio"),
                       new MenuItem(href:"#", title:"Want more", childMenuItems:
                       [
                           new MenuItem(href:"#", title:"You made it"),
                       ]),
                   ]),
                ]),
            ]),
        ]),

        new MenuItem(href:"#", title:"Charts", icon:"ri-bar-chart-2-fill", childMenuItems:
        [
            new MenuItem(href:"#", title:"Pie chart"),
            new MenuItem(href:"#", title:"Line chart"),
            new MenuItem(href:"#", title:"Bar chart"),
        ]),

        new MenuItem(title:"E-commerce", icon:"ri-shopping-cart-fill", childMenuItems:
        [
            new MenuItem(href:"#", title:"Products"),
            new MenuItem(href:"#", title:"Orders"),
            new MenuItem(href:"#", title:"Credit card"),
        ]),

        new MenuItem(title:"Maps", icon:"ri-global-fill", childMenuItems:
        [
            new MenuItem(href:"#", title:"Google maps"),
            new MenuItem(href:"#", title:"Open street map"),
        ]),
        new MenuItem(title:"Theme", icon:"ri-paint-brush-fill", childMenuItems:
        [
            new MenuItem(href:"#", title:"Dark"),
            new MenuItem(href:"#", title:"Light"),
        ]),
    };

}
