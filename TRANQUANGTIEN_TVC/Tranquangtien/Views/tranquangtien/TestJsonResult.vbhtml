@Code
    ViewData("Title") = "TestJsonResult"
End Code

@ModelType List(Of trantien)

@For Each student In Model
@student.id  @student.name  @student.classname
Next
