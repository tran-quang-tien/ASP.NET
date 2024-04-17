@Code
    ViewData("Title") = "TestFileStreamResult"
End Code

@Code
    ViewData("Title") = "File Stream Result"
End Code

<h2>@ViewData("Title")</h2>

<p>Click the button below to download the file:</p>

<a href="@Url.Action("TestFileStreamResult")" class="btn btn-primary">Download File</a>
