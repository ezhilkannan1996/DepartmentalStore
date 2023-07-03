Public Class UserForm
    Dim DataContext As New DSMSEntities

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As New List(Of spGetAllFromUser_Result)
        lst = DataContext.spGetAllFromUser().ToList()
        UserGrid.DataSource = lst
        'For Each item As String In UserGrid.Columns(0).HeaderText.ToList()
        '    If item.Contains("_") Then
        '        UserGrid.Columns.Remove(item)
        '        item.Replace("_", " ")
        '        UserGrid.Columns.Add(item, item)
        '    Else
        '        UserGrid.Columns.Add(item, item)
        '    End If
        'Next
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click

    End Sub
End Class
