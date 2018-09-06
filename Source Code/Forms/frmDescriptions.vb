Public Class frmDescriptions
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblVendorLabel As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DADescs As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectDESCs As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsDescriptions1 As BeaverOil.DSDescriptions
    Friend WithEvents DGStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnCancelV As System.Windows.Forms.Button
    Friend WithEvents btnSaveV As System.Windows.Forms.Button
    Friend WithEvents DelDesc As System.Data.OleDb.OleDbCommand
    Friend WithEvents InsertDesc As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateDesc As System.Data.OleDb.OleDbCommand
    Friend WithEvents dgDESCs As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblVendorLabel = New System.Windows.Forms.Label
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DADescs = New System.Data.OleDb.OleDbDataAdapter
        Me.DelDesc = New System.Data.OleDb.OleDbCommand
        Me.InsertDesc = New System.Data.OleDb.OleDbCommand
        Me.SelectDESCs = New System.Data.OleDb.OleDbCommand
        Me.UpdateDesc = New System.Data.OleDb.OleDbCommand
        Me.DsDescriptions1 = New BeaverOil.DSDescriptions
        Me.dgDESCs = New System.Windows.Forms.DataGrid
        Me.DGStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnCancelV = New System.Windows.Forms.Button
        Me.btnSaveV = New System.Windows.Forms.Button
        CType(Me.DsDescriptions1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDESCs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVendorLabel
        '
        Me.lblVendorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendorLabel.Location = New System.Drawing.Point(72, 8)
        Me.lblVendorLabel.Name = "lblVendorLabel"
        Me.lblVendorLabel.Size = New System.Drawing.Size(488, 16)
        Me.lblVendorLabel.TabIndex = 34
        Me.lblVendorLabel.Text = "Maintain Descriptions:"
        Me.lblVendorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""Z:\VB.NET Apps\BeaverOil" & _
        "\bin\JobTrackingSystem.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global B" & _
        "ulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=" & _
        ";Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Dat" & _
        "abase Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Loca" & _
        "le on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin" & _
        ";Jet OLEDB:Encrypt Database=False"
        '
        'DADescs
        '
        Me.DADescs.DeleteCommand = Me.DelDesc
        Me.DADescs.InsertCommand = Me.InsertDesc
        Me.DADescs.SelectCommand = Me.SelectDESCs
        Me.DADescs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblHWNumberDESCs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DescriptionsID", "DescriptionsID"), New System.Data.Common.DataColumnMapping("HWNumber", "HWNumber"), New System.Data.Common.DataColumnMapping("ProductDescription", "ProductDescription"), New System.Data.Common.DataColumnMapping("ProductDescription1", "ProductDescription1"), New System.Data.Common.DataColumnMapping("ManifestDescription", "ManifestDescription")})})
        Me.DADescs.UpdateCommand = Me.UpdateDesc
        '
        'DelDesc
        '
        Me.DelDesc.CommandText = "DELETE FROM tblHWNumberDESCs WHERE DescriptionsID = ?"
        Me.DelDesc.Connection = Me.OleDbConnection1
        Me.DelDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("DescriptionsID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescriptionsID", System.Data.DataRowVersion.Original, Nothing))
        '
        'InsertDesc
        '
        Me.InsertDesc.CommandText = "INSERT INTO tblHWNumberDESCs (HWNumber, ProductDescription, ProductDescription1, " & _
        "ManifestDescription) VALUES (?, ?, ?, ?)"
        Me.InsertDesc.Connection = Me.OleDbConnection1
        Me.InsertDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("HWNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "HWNumber"))
        Me.InsertDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductDescription", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductDescription"))
        Me.InsertDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductDescription1", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductDescription1"))
        Me.InsertDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManifestDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "ManifestDescription"))
        '
        'SelectDESCs
        '
        Me.SelectDESCs.CommandText = "SELECT tblHWNumberDESCs.* FROM tblHWNumberDESCs ORDER BY HWNumber"
        Me.SelectDESCs.Connection = Me.OleDbConnection1
        '
        'UpdateDesc
        '
        Me.UpdateDesc.CommandText = "UPDATE tblHWNumberDESCs SET HWNumber = ?, ProductDescription = ?, ProductDescript" & _
        "ion1 = ?, ManifestDescription = ? WHERE (DescriptionsID = ?)"
        Me.UpdateDesc.Connection = Me.OleDbConnection1
        Me.UpdateDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("HWNumber", System.Data.OleDb.OleDbType.VarWChar, 50, "HWNumber"))
        Me.UpdateDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductDescription", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductDescription"))
        Me.UpdateDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductDescription1", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductDescription1"))
        Me.UpdateDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("ManifestDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "ManifestDescription"))
        Me.UpdateDesc.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DescriptionsID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescriptionsID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsDescriptions1
        '
        Me.DsDescriptions1.DataSetName = "DSDescriptions"
        Me.DsDescriptions1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dgDESCs
        '
        Me.dgDESCs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDESCs.CaptionVisible = False
        Me.dgDESCs.DataMember = "tblHWNumberDESCs"
        Me.dgDESCs.DataSource = Me.DsDescriptions1
        Me.dgDESCs.FlatMode = True
        Me.dgDESCs.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDESCs.Location = New System.Drawing.Point(0, 32)
        Me.dgDESCs.Name = "dgDESCs"
        Me.dgDESCs.Size = New System.Drawing.Size(624, 296)
        Me.dgDESCs.TabIndex = 35
        Me.dgDESCs.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGStyle1})
        '
        'DGStyle1
        '
        Me.DGStyle1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DGStyle1.DataGrid = Me.dgDESCs
        Me.DGStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DGStyle1.GridLineColor = System.Drawing.Color.Black
        Me.DGStyle1.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.DGStyle1.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DGStyle1.MappingName = "tblHWNumberDESCs"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "DescriptionsID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Desc Title"
        Me.DataGridTextBoxColumn2.MappingName = "HWNumber"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Product Description 1"
        Me.DataGridTextBoxColumn3.MappingName = "ProductDescription"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 140
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Product Description 2"
        Me.DataGridTextBoxColumn4.MappingName = "ProductDescription1"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 140
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Manifest Description"
        Me.DataGridTextBoxColumn5.MappingName = "ManifestDescription"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 220
        '
        'btnCancelV
        '
        Me.btnCancelV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelV.Location = New System.Drawing.Point(312, 336)
        Me.btnCancelV.Name = "btnCancelV"
        Me.btnCancelV.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelV.TabIndex = 37
        Me.btnCancelV.Text = "&Cancel"
        '
        'btnSaveV
        '
        Me.btnSaveV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveV.Location = New System.Drawing.Point(184, 336)
        Me.btnSaveV.Name = "btnSaveV"
        Me.btnSaveV.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveV.TabIndex = 36
        Me.btnSaveV.Text = "&Save"
        '
        'frmDescriptions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 373)
        Me.Controls.Add(Me.btnCancelV)
        Me.Controls.Add(Me.btnSaveV)
        Me.Controls.Add(Me.dgDESCs)
        Me.Controls.Add(Me.lblVendorLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDescriptions"
        Me.Text = "frmDescriptions"
        CType(Me.DsDescriptions1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDESCs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDescriptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.InitialLoad()

    End Sub

    Function InitialLoad()

        Try

            If Me.OleDbConnection1.State = ConnectionState.Open Then Me.OleDbConnection1.Close()
            Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
            Me.OleDbConnection1.Open()
            Me.SelectDESCs.Connection = Me.OleDbConnection1
            Me.DelDesc.Connection = Me.OleDbConnection1
            Me.InsertDesc.Connection = Me.OleDbConnection1
            Me.UpdateDesc.Connection = Me.OleDbConnection1
            'Load the data into datagrid
            Me.LoadData()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Ocurred---")

        Finally

            If Me.OleDbConnection1.State = ConnectionState.Open Then Me.OleDbConnection1.Close()

        End Try

    End Function

    Function LoadData()

        Try

            If Me.OleDbConnection1.State = ConnectionState.Closed Then Me.OleDbConnection1.Open()

            'Fill the dataset
            Me.DADescs.Fill(Me.DsDescriptions1)
            'Fill the datagrid
            Me.dgDESCs.DataSource = Me.DsDescriptions1
            Me.dgDESCs.Refresh()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Ocurred---")

        Finally

            If Me.OleDbConnection1.State = ConnectionState.Open Then Me.OleDbConnection1.Close()

        End Try

    End Function

    Private Sub btnCancelV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelV.Click

        Me.Close()

    End Sub

    Private Sub btnSaveV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveV.Click

        Try

            If Me.OleDbConnection1.State = ConnectionState.Closed Then Me.OleDbConnection1.Open()
            'Update Changes
            Me.DADescs.Update(Me.DsDescriptions1)
            MsgBox("Saved successfully.", MsgBoxStyle.Information, "Save")
            'Reload changes
            Me.LoadData()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Ocurred while saving.")

        Finally

            If Me.OleDbConnection1.State = ConnectionState.Open Then Me.OleDbConnection1.Close()

        End Try

    End Sub

End Class
