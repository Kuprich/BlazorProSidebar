
## Blazor Pro Sidebar

The basis of This template is the following project made using the React.Therefore, I am forced to leave a link to the author of the original project.

Original project: [Click here](https://github.com/azouaoui-med/react-pro-sidebar)

Responsive layout with advanced sidebar menu built with CSS and Blazor.
        The project uses a library of icons named as [Remix](https://remixicon.com/)

**Features**

+ Fully responsive
+ Collapsable sidebar
+ Multi level menu
+ RTL support
+ Customizable

![adaptive](https://github.com/Kuprich/BlazorProTemplate/assets/23151696/4ee0bf34-bad4-4132-8147-5f596f096dbf)

![submenu](https://github.com/Kuprich/BlazorProTemplate/assets/23151696/df29ae5c-9175-4d02-8abe-30784d6dcc14)


### Ohter

Menu items can be represented as follows: 

```C#
List<MenuItem> menuItems = new()
{
    new MenuItem(href:"/home", title: "Home", icon:"ri-home-3-fill"),
    new MenuItem(href:"/counter", title: "Counter", icon:"ri-add-box-fill"),
    new MenuItem(href:"/weather", title: "Weather", icon:"ri-bar-chart-horizontal-line"),
};

```
nested menu items can be easily added. Below is an example of a complex multi-level menu:

```C#
var menuItem = new MenuItem(title:"Components", icon:"ri-vip-diamond-fill", suffix: new("Hot", "primary"), childMenuItems:
[
    new MenuItem(href:"#", title:"Grid"),
    new MenuItem(title:"Layout", childMenuItems:
    [
        new MenuItem(title:"Forms", childMenuItems:
        [
            new MenuItem(href:"#", title:"Input"),
            new MenuItem(href:"#", title:"Select"),
            new MenuItem(title:"More", childMenuItems:
            [
                new MenuItem(href:"#", title:"CheckBox"),
                new MenuItem(href:"#", title:"Radio"),
                new MenuItem(title:"Want more", childMenuItems:
                [
                    new MenuItem(href:"#", title:"You made it"),
                ]),
            ]),
        ]),
    ]),
]);

```



