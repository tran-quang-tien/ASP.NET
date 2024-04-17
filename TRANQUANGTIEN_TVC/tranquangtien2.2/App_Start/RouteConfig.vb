Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Show Product",
            url:="San-Pham/Danh-Sach-San-Pham",
            defaults:=New With {.controller = "Product", .action = "ShowProduct"})
        routes.MapRoute(
            name:="Edit Product",
            url:="San-Pham/Sua/{productId}",
            defaults:=New With {.controller = "Product", .action = "EditProduct", .productId = "\d{1,4}"})
        routes.MapRoute(
            name:="Details Product",
            url:="San-Pham/{productName}/{productId}",
            defaults:=New With {.controller = "Product", .action = "DetailsProduct", .productId = "\d{1,4}"}
)
    End Sub
End Module