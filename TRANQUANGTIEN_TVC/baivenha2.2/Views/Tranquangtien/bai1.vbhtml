@Code
    ViewData("Title") = "bai1"
End Code

<h2>bai1</h2>

<h2>@ViewData("Title")</h2>

<p>Click the button below to download the file:</p>

<a href="@Url.Action("bai1")" class="btn btn-primary">Download File</a>