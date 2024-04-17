@Code
    ViewData("Title") = "TestFileContentResult"
End Code
@Code
    ViewData("Title") = "File Content Result"
End Code

<h2>@ViewData("Title")</h2>

<p>Click the button below to download the file:</p>

<a href="@Url.Action("TestFileContentResult")" class="btn btn-primary">Download File</a>

