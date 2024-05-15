<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim _Label As System.Windows.Forms.Label
        Dim Código_productoLabel As System.Windows.Forms.Label
        Dim TamañoLabel As System.Windows.Forms.Label
        Dim Fondo_ColorLabel As System.Windows.Forms.Label
        Dim ExistenciaLabel As System.Windows.Forms.Label
        Dim Código_AlmacénLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._Poo_InventarioDataSet = New InventarioP._Poo_InventarioDataSet()
        Me.TazasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TazasTableAdapter = New InventarioP._Poo_InventarioDataSetTableAdapters.TazasTableAdapter()
        Me.TableAdapterManager = New InventarioP._Poo_InventarioDataSetTableAdapters.TableAdapterManager()
        Me._TextBox = New System.Windows.Forms.TextBox()
        Me.Código_productoTextBox = New System.Windows.Forms.TextBox()
        Me.TamañoTextBox = New System.Windows.Forms.TextBox()
        Me.Fondo_ColorTextBox = New System.Windows.Forms.TextBox()
        Me.ExistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Código_AlmacénTextBox = New System.Windows.Forms.TextBox()
        Me.TazasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        _Label = New System.Windows.Forms.Label()
        Código_productoLabel = New System.Windows.Forms.Label()
        TamañoLabel = New System.Windows.Forms.Label()
        Fondo_ColorLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        Código_AlmacénLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Poo_InventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TazasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TazasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(21, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TAZAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(535, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(262, 84)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(797, 88)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        '_Poo_InventarioDataSet
        '
        Me._Poo_InventarioDataSet.DataSetName = "_Poo_InventarioDataSet"
        Me._Poo_InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TazasBindingSource
        '
        Me.TazasBindingSource.DataMember = "Tazas"
        Me.TazasBindingSource.DataSource = Me._Poo_InventarioDataSet
        '
        'TazasTableAdapter
        '
        Me.TazasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlmacenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CamisetasTableAdapter = Nothing
        Me.TableAdapterManager.TazasTableAdapter = Me.TazasTableAdapter
        Me.TableAdapterManager.termosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = InventarioP._Poo_InventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ViniloTableAdapter = Nothing
        '
        '_Label
        '
        _Label.AutoSize = True
        _Label.Location = New System.Drawing.Point(32, 126)
        _Label.Name = "_Label"
        _Label.Size = New System.Drawing.Size(17, 13)
        _Label.TabIndex = 6
        _Label.Text = "#:"
        '
        '_TextBox
        '
        Me._TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TazasBindingSource, "#", True))
        Me._TextBox.Location = New System.Drawing.Point(126, 123)
        Me._TextBox.Name = "_TextBox"
        Me._TextBox.Size = New System.Drawing.Size(100, 20)
        Me._TextBox.TabIndex = 7
        '
        'Código_productoLabel
        '
        Código_productoLabel.AutoSize = True
        Código_productoLabel.Location = New System.Drawing.Point(32, 152)
        Código_productoLabel.Name = "Código_productoLabel"
        Código_productoLabel.Size = New System.Drawing.Size(88, 13)
        Código_productoLabel.TabIndex = 8
        Código_productoLabel.Text = "Código producto:"
        '
        'Código_productoTextBox
        '
        Me.Código_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TazasBindingSource, "Código producto", True))
        Me.Código_productoTextBox.Location = New System.Drawing.Point(126, 149)
        Me.Código_productoTextBox.Name = "Código_productoTextBox"
        Me.Código_productoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Código_productoTextBox.TabIndex = 9
        '
        'TamañoLabel
        '
        TamañoLabel.AutoSize = True
        TamañoLabel.Location = New System.Drawing.Point(32, 178)
        TamañoLabel.Name = "TamañoLabel"
        TamañoLabel.Size = New System.Drawing.Size(49, 13)
        TamañoLabel.TabIndex = 10
        TamañoLabel.Text = "Tamaño:"
        '
        'TamañoTextBox
        '
        Me.TamañoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TazasBindingSource, "Tamaño", True))
        Me.TamañoTextBox.Location = New System.Drawing.Point(126, 175)
        Me.TamañoTextBox.Name = "TamañoTextBox"
        Me.TamañoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TamañoTextBox.TabIndex = 11
        '
        'Fondo_ColorLabel
        '
        Fondo_ColorLabel.AutoSize = True
        Fondo_ColorLabel.Location = New System.Drawing.Point(32, 204)
        Fondo_ColorLabel.Name = "Fondo_ColorLabel"
        Fondo_ColorLabel.Size = New System.Drawing.Size(67, 13)
        Fondo_ColorLabel.TabIndex = 12
        Fondo_ColorLabel.Text = "Fondo Color:"
        '
        'Fondo_ColorTextBox
        '
        Me.Fondo_ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TazasBindingSource, "Fondo Color", True))
        Me.Fondo_ColorTextBox.Location = New System.Drawing.Point(126, 201)
        Me.Fondo_ColorTextBox.Name = "Fondo_ColorTextBox"
        Me.Fondo_ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Fondo_ColorTextBox.TabIndex = 13
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.Location = New System.Drawing.Point(32, 230)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(58, 13)
        ExistenciaLabel.TabIndex = 14
        ExistenciaLabel.Text = "Existencia:"
        '
        'ExistenciaTextBox
        '
        Me.ExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TazasBindingSource, "Existencia", True))
        Me.ExistenciaTextBox.Location = New System.Drawing.Point(126, 227)
        Me.ExistenciaTextBox.Name = "ExistenciaTextBox"
        Me.ExistenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExistenciaTextBox.TabIndex = 15
        '
        'Código_AlmacénLabel
        '
        Código_AlmacénLabel.AutoSize = True
        Código_AlmacénLabel.Location = New System.Drawing.Point(32, 256)
        Código_AlmacénLabel.Name = "Código_AlmacénLabel"
        Código_AlmacénLabel.Size = New System.Drawing.Size(87, 13)
        Código_AlmacénLabel.TabIndex = 16
        Código_AlmacénLabel.Text = "Código Almacén:"
        '
        'Código_AlmacénTextBox
        '
        Me.Código_AlmacénTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TazasBindingSource, "Código Almacén", True))
        Me.Código_AlmacénTextBox.Location = New System.Drawing.Point(126, 253)
        Me.Código_AlmacénTextBox.Name = "Código_AlmacénTextBox"
        Me.Código_AlmacénTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Código_AlmacénTextBox.TabIndex = 17
        '
        'TazasDataGridView
        '
        Me.TazasDataGridView.AllowUserToAddRows = False
        Me.TazasDataGridView.AllowUserToDeleteRows = False
        Me.TazasDataGridView.AutoGenerateColumns = False
        Me.TazasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TazasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TazasDataGridView.DataSource = Me.TazasBindingSource
        Me.TazasDataGridView.Location = New System.Drawing.Point(232, 227)
        Me.TazasDataGridView.Name = "TazasDataGridView"
        Me.TazasDataGridView.ReadOnly = True
        Me.TazasDataGridView.Size = New System.Drawing.Size(531, 220)
        Me.TazasDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "#"
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Código producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tamaño"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tamaño"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fondo Color"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fondo Color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Existencia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Existencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Código Almacén"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Código Almacén"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(519, 156)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(33, 39)
        Me.Button10.TabIndex = 37
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(476, 156)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(33, 39)
        Me.Button9.TabIndex = 36
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(437, 156)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(33, 39)
        Me.Button8.TabIndex = 35
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(398, 156)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(33, 39)
        Me.Button7.TabIndex = 34
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(359, 156)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(33, 39)
        Me.Button6.TabIndex = 33
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(320, 156)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(33, 39)
        Me.Button5.TabIndex = 32
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(437, 107)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 39)
        Me.Button4.TabIndex = 31
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(398, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 39)
        Me.Button3.TabIndex = 30
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(359, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 39)
        Me.Button2.TabIndex = 29
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(320, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 39)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 450)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TazasDataGridView)
        Me.Controls.Add(_Label)
        Me.Controls.Add(Me._TextBox)
        Me.Controls.Add(Código_productoLabel)
        Me.Controls.Add(Me.Código_productoTextBox)
        Me.Controls.Add(TamañoLabel)
        Me.Controls.Add(Me.TamañoTextBox)
        Me.Controls.Add(Fondo_ColorLabel)
        Me.Controls.Add(Me.Fondo_ColorTextBox)
        Me.Controls.Add(ExistenciaLabel)
        Me.Controls.Add(Me.ExistenciaTextBox)
        Me.Controls.Add(Código_AlmacénLabel)
        Me.Controls.Add(Me.Código_AlmacénTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Poo_InventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TazasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TazasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents _Poo_InventarioDataSet As _Poo_InventarioDataSet
    Friend WithEvents TazasBindingSource As BindingSource
    Friend WithEvents TazasTableAdapter As _Poo_InventarioDataSetTableAdapters.TazasTableAdapter
    Friend WithEvents TableAdapterManager As _Poo_InventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents _TextBox As TextBox
    Friend WithEvents Código_productoTextBox As TextBox
    Friend WithEvents TamañoTextBox As TextBox
    Friend WithEvents Fondo_ColorTextBox As TextBox
    Friend WithEvents ExistenciaTextBox As TextBox
    Friend WithEvents Código_AlmacénTextBox As TextBox
    Friend WithEvents TazasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
