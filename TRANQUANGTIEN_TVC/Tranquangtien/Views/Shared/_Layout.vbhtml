﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Application name", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("ViewResult", "TestViewResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("PartialViewResult", "TestPartialViewResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("EmptyResult", "TestEmptyResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("RedirectResult", "TestRedirectResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("JsonResult", "TestJsonResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("JavaScriptResult", "TestJavaScriptResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("ContentResult", "TestContentResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("FileContentResult", "TestFileContentResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("FileStreamResult", "TestFileStreamResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("FilePathResult", "TestFilePathResult", "tranquangtien")</li>
                    <li>@Html.ActionLink("FileContentResult", "TestFileContentResult", "tranquangtien")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>