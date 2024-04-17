Imports System.Web.Mvc

Namespace Controllers
    Public Class tranquangtienbai2Controller
        Inherits Controller

        ' GET: tranquangtienbai2
        Function Index() As ActionResult
            Return View()
        End Function
        Function ShowProduct() As ActionResult
            Return View()
        End Function
        Function EditProduct(ByVal productId As Integer?) As ActionResult
            ViewBag.id = productId
            Return View()
        End Function

        Function DetailsProduct(ByVal productName As String, ByVal productId As Integer?) As ActionResult
            ViewBag.name = productName
            ViewBag.id = productId
            Return View()
        End Function



    End Class
End Namespace