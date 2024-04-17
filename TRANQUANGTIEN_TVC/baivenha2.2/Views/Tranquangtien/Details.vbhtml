@Code
    ViewData("Title") = "Details"
End Code

ModelType tranquangtien

<h2>Chi tiết bài hát</h2>

<p>Tên bài hát: @Model.Name</p>
<p>Mô tả: @Model.Description</p>

<a href="@Model.Url" class="btn btn-primary">Tải về</a>

