Imports System.Web.Mvc
Imports System.IO

Namespace Controllers
    Public Class tranquangtienController
        Inherits Controller

        ' GET: tranquangtien
        Function Index() As ActionResult
            Return View()
        End Function

        Function TestViewResult() As ViewResult

            Return View()
        End Function
        Function TestPartialViewResult() As PartialViewResult
            Return PartialView()
        End Function
        Public Function TestEmptyResult() As EmptyResult
            Return New EmptyResult()
        End Function

        Public Function TestRedirectResult() As RedirectResult
            Return Redirect("Index")
        End Function

        Public Function TestJsonResult() As JsonResult


            Dim listStudent As New List(Of trantien)()
            listStudent.Add(New trantien() With {.id = 1, .name = "Nguyễn Quang Huy", .classname = "C1311L"})
            listStudent.Add(New trantien() With {.id = 2, .name = "Nguyễn Quang Hiển", .classname = "C1311H"})
            listStudent.Add(New trantien() With {.id = 3, .name = "Nguyễn Duy Huân", .classname = "C1311T"})
            listStudent.Add(New trantien() With {.id = 4, .name = "Vũ Quang Huy", .classname = "C1311C"})
            listStudent.Add(New trantien() With {.id = 5, .name = "Trần Quang Huy", .classname = "C1311L"})
            listStudent.Add(New trantien() With {.id = 6, .name = "Phạm Quang Huy", .classname = "C1311L"})
            listStudent.Add(New trantien() With {.id = 7, .name = "Trịnh Quang Huy", .classname = "C1311B"})
            listStudent.Add(New trantien() With {.id = 8, .name = "Vũ Quang Huy", .classname = "C1311L"})
            listStudent.Add(New trantien() With {.id = 9, .name = "Vũ Minh Trịnh", .classname = "C1311M"})

            Return Json(listStudent)
        End Function
        Function TestJavaScriptResult() As JavaScriptResult
            Dim js As String = "function checkEmail() {
    var emailPattern = /^([a-zA-Z0-9_.+-]+)@([a-zA-Z0-9-]+).([a-zA-Z]{2,5})$/;
    var email = document.getElementById('email').value;
    var kq = false;
    
    if (emailPattern.test(email)) {
        kq = true;
    } else {
        alert('Invalid email address');
        kq = false;
    }
    
    return kq;
}"

            Return JavaScript(js)
        End Function
        Dim contentXML As XElement =
        <Students>
            <Student>
                <ID>001</ID>
                <FullName>Nguyễn Viết Nam</FullName>
                <ClassName>C1308H</ClassName>
            </Student>
            <Student>
                <ID>002</ID>
                <FullName>Nguyễn Hoàng Anh</FullName>
                <ClassName>C1411P</ClassName>
            </Student>
            <Student>
                <ID>003</ID>
                <FullName>Phạm Ngọc Anh</FullName>
                <ClassName>C1411L</ClassName>
            </Student>
            <Student>
                <ID>004</ID>
                <FullName>Trần Ngọc Linh</FullName>
                <ClassName>C1411H</ClassName>
            </Student>
            <Student>
                <ID>005</ID>
                <FullName>Nguyễn Hồng Anh</FullName>
                <ClassName>C1411L</ClassName>
            </Student>
        </Students>



        Function TestFileContentResult() As FileContentResult
            Dim fileBytes As Byte() = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/demovideo.mp4"))
            Dim fileName As String = "demovideo.mp4"
            Return File(fileBytes, "video/mp4", fileName)
        End Function
        Function TestFileStreamResult() As FileStreamResult
            Dim pathFile As String = Server.MapPath("~/Content/vonsong.docx")
            Dim fileName As String = "vonsong.docx"
            Dim fileStream As New FileStream(pathFile, FileMode.Open, FileAccess.Read)
            Return New FileStreamResult(fileStream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document") With {
        .FileDownloadName = fileName
    }
        End Function
        Function TestFilePathResult() As FilePathResult
            Dim pathFile As String = Server.MapPath("~/Content/vonsong.docx")
            Dim fileName As String = "vonsong.docx"
            Return File(pathFile, "application/msword", fileName)
        End Function
    End Class

End Namespace