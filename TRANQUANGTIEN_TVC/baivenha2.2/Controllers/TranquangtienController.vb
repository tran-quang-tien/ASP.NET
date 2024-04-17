Imports System.Web.Mvc

Namespace Controllers
    Public Class TranquangtienController
        Inherits Controller

        ' GET: Tranquangtien
        Function Index() As ActionResult
            Return View()
        End Function
        Function bai1() As ActionResult
            Dim fileBytes As Byte() = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/aiduaemve.mp4"))
            Dim fileName As String = "aiduaemve.mp4"
            Return File(fileBytes, "video/mp4", fileName)
            Return View()
        End Function
        Function bai2() As ActionResult
            Dim fileBytes As Byte() = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/tenki no ko.mp4"))
            Dim fileName As String = "tenki no ko.mp4"
            Return File(fileBytes, "video/mp4", fileName)
            Return View()
        End Function
        Function bai3() As ActionResult
            Dim fileBytes As Byte() = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/trang tri.mp4"))
            Dim fileName As String = "trang tri .mp4"
            Return File(fileBytes, "video/mp4", fileName)
            Return View()
        End Function
        Function bai4() As ActionResult
            Dim fileBytes As Byte() = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/kho bau.mp4"))
            Dim fileName As String = "kho bau.mp4"
            Return File(fileBytes, "video/mp4", fileName)
            Return View()
        End Function

    End Class
End Namespace