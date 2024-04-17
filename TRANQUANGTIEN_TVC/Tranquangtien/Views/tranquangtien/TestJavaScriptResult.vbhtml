@Code
    ViewData("Title") = "TestJavaScriptResult"
End Code
@ModelType String

<script type="text/javascript">
    @Html.Raw(Model)
</script>

