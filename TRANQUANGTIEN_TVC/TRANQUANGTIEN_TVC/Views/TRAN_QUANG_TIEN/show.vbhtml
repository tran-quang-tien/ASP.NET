@Code
    ViewData("Title") = "show"
End Code
<h1>Xin chào tới các bản nhạc hay</h1>
@ViewBag.name
@ModelType List(Of tranquangtiennhac)

@For Each nhac As tranquangtiennhac In Model
<div>
<h3>@nhac.tennhac</h3>
        <a href = "@nhac.link" > Tải về</a>
    </div>
Next