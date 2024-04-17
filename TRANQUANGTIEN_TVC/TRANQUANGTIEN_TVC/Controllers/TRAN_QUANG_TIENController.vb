Imports System.Web.Mvc

Namespace Controllers
    Public Class TRAN_QUANG_TIENController
        Inherits Controller

        ' GET: TRAN_QUANG_TIEN
        Function Index() As ActionResult
            Return View()
        End Function
        Function show() As ActionResult
            ViewBag.name = "Dưới đây là list nhạc"
            Return View()
        End Function
        Function nhac() As List(Of tranquangtiennhac)
            Dim ten As New List(Of tranquangtiennhac)
            ten.Add(New tranquangtiennhac() With {.tennhac = "Bạn đời", .link = "https://www.y2mate.com/vi/youtube/h7cOOfpdEfk"})
            ten.Add(New tranquangtiennhac() With {.tennhac = "Không phải dạng vừa đâu", .link = "https://www.y2mate.com/vi/youtube/OE57pr7sPE4"})
        End Function



    End Class
End Namespace