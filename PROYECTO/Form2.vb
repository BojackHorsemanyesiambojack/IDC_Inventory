Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Poo_InventarioDataSet.Tazas' Puede moverla o quitarla según sea necesario.
        Me.TazasTableAdapter.Fill(Me._Poo_InventarioDataSet.Tazas)
        PictureBox2.Parent = PictureBox1
        PictureBox2.BackColor = Color.Transparent

        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent


        'Quitar texto a botones
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button10.Text = ""
        'Bloquea el campo No
        _TextBox.ReadOnly = True
    End Sub
    Private Sub Form2BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Form2BindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TazasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TazasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Poo_InventarioDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _TextBox.Focus()
        TazasBindingSource.AddNew()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cat, des As String
        cat = TamañoTextBox.Text
        des = Fondo_ColorTextBox.Text

        If cat = "" Or des = "" Then
            MsgBox("Todos los campos son obligatorios.", vbCritical, "Error")

        Else
            On Error GoTo SaveErr
            TazasBindingSource.EndEdit()
            TazasTableAdapter.Update(_Poo_InventarioDataSet.Tazas)
            MsgBox("Registro guardado correctamente.", vbInformation, "Guardar")
SaveErr:
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
        End If
        On Error GoTo SaveErr
        TazasBindingSource.EndEdit()
        TazasTableAdapter.Update(_Poo_InventarioDataSet.Tazas)
        MsgBox("Registro guardado correctamente.", vbInformation, "Guardar")

        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String
        a = MsgBox("Está seguro de modificar los registros?", vbQuestion * vbYesNo, "Actualizar")
        If a = vbYes Then
            TazasBindingSource.EndEdit()
            TazasTableAdapter.Update(_Poo_InventarioDataSet.Tazas)
            MsgBox("Registro Actualizado.", vbInformation, "Actualizar")
        Else
            MsgBox("Se canceló la actualización.", vbInformation, "Actualizar")
            Me.TazasTableAdapter.Fill(Me._Poo_InventarioDataSet.Tazas)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String
        a = MsgBox("Realmente desea eliminar el registro?", vbQuestion * vbYesNo, "Eliminar")
        If a = vbYes Then
            TazasBindingSource.RemoveCurrent()
            TazasTableAdapter.Update(_Poo_InventarioDataSet.Tazas)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TazasBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TazasBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TazasBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TazasBindingSource.MoveLast()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim a As String
        a = InputBox("Ingrese categoria", "Buscar categoria")
        Me.TazasTableAdapter.FillBy(Me._Poo_InventarioDataSet.Tazas, a)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.TazasTableAdapter.Fill(Me._Poo_InventarioDataSet.Tazas)
    End Sub
End Class
