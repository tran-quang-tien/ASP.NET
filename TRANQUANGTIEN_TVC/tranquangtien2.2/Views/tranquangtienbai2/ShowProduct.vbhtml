@Code
    ViewData("Title") = "ShowProduct"
End Code
<h2>xin chào mn</h2>
<h2>Danh Sách Sản Phẩm</h2>

<table class="table table-bordered">
    <thead>
        <tr>
            <th>Mã Sản Phẩm</th>
            <th>Tên Sản Phẩm</th>
            <th>Lựa Chọn</th>
        </tr>
    </thead>
    <tbody>
        @For (Int(i) = 1; i < 10; i++)
{
                <td>@i</td>
                   <td> sản Phẩm Thứ @i</td>
                @Html.ActionLink("Chi Tiết", "DetailsProduct", New With {.productName = "Sản Phẩm Thứ " + Function(i), .productId = Function(i)})
                @Html.ActionLink("Sửa", "EditProduct", New With {.productId = Function(i)})
                                }
     </tbody>
</table>
Next

