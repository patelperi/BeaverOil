Public Class frmMaintenance
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMaintainG As System.Windows.Forms.Button
    Friend WithEvents btnMaintainT As System.Windows.Forms.Button
    Friend WithEvents btnMaintainD As System.Windows.Forms.Button
    Friend WithEvents btnMaintainP As System.Windows.Forms.Button
    Friend WithEvents btnMaintainV As System.Windows.Forms.Button
    Friend WithEvents btnCancelJobs As System.Windows.Forms.Button
    Friend WithEvents btnDescs As System.Windows.Forms.Button
    Friend WithEvents btnPrintJ As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnMaintainG = New System.Windows.Forms.Button
        Me.btnMaintainT = New System.Windows.Forms.Button
        Me.btnMaintainD = New System.Windows.Forms.Button
        Me.btnMaintainP = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnMaintainV = New System.Windows.Forms.Button
        Me.btnCancelJobs = New System.Windows.Forms.Button
        Me.btnDescs = New System.Windows.Forms.Button
        Me.btnPrintJ = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnMaintainG
        '
        Me.btnMaintainG.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMaintainG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintainG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintainG.Location = New System.Drawing.Point(176, 80)
        Me.btnMaintainG.Name = "btnMaintainG"
        Me.btnMaintainG.Size = New System.Drawing.Size(208, 24)
        Me.btnMaintainG.TabIndex = 1
        Me.btnMaintainG.Text = "Maintain &Generators"
        '
        'btnMaintainT
        '
        Me.btnMaintainT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMaintainT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintainT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintainT.Location = New System.Drawing.Point(176, 128)
        Me.btnMaintainT.Name = "btnMaintainT"
        Me.btnMaintainT.Size = New System.Drawing.Size(208, 24)
        Me.btnMaintainT.TabIndex = 2
        Me.btnMaintainT.Text = "Maintain &Transporters"
        '
        'btnMaintainD
        '
        Me.btnMaintainD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMaintainD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintainD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintainD.Location = New System.Drawing.Point(176, 176)
        Me.btnMaintainD.Name = "btnMaintainD"
        Me.btnMaintainD.Size = New System.Drawing.Size(208, 24)
        Me.btnMaintainD.TabIndex = 3
        Me.btnMaintainD.Text = "Maintain &Disposal Facilities"
        '
        'btnMaintainP
        '
        Me.btnMaintainP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMaintainP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintainP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintainP.Location = New System.Drawing.Point(176, 224)
        Me.btnMaintainP.Name = "btnMaintainP"
        Me.btnMaintainP.Size = New System.Drawing.Size(208, 24)
        Me.btnMaintainP.TabIndex = 4
        Me.btnMaintainP.Text = "Maintain &Products"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Maintenance Screen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMaintainV
        '
        Me.btnMaintainV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMaintainV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintainV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintainV.Location = New System.Drawing.Point(176, 272)
        Me.btnMaintainV.Name = "btnMaintainV"
        Me.btnMaintainV.Size = New System.Drawing.Size(208, 24)
        Me.btnMaintainV.TabIndex = 5
        Me.btnMaintainV.Text = "Maintain &Vendors"
        '
        'btnCancelJobs
        '
        Me.btnCancelJobs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelJobs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelJobs.Location = New System.Drawing.Point(176, 320)
        Me.btnCancelJobs.Name = "btnCancelJobs"
        Me.btnCancelJobs.Size = New System.Drawing.Size(208, 24)
        Me.btnCancelJobs.TabIndex = 29
        Me.btnCancelJobs.Text = "&Cancel Jobs"
        '
        'btnDescs
        '
        Me.btnDescs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDescs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescs.Location = New System.Drawing.Point(176, 368)
        Me.btnDescs.Name = "btnDescs"
        Me.btnDescs.Size = New System.Drawing.Size(208, 24)
        Me.btnDescs.TabIndex = 30
        Me.btnDescs.Text = "Maintain D&escriptions"
        '
        'btnPrintJ
        '
        Me.btnPrintJ.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintJ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintJ.Location = New System.Drawing.Point(176, 416)
        Me.btnPrintJ.Name = "btnPrintJ"
        Me.btnPrintJ.Size = New System.Drawing.Size(208, 24)
        Me.btnPrintJ.TabIndex = 31
        Me.btnPrintJ.Text = "Print Multi-Stop Job Tickets"
        '
        'frmMaintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 445)
        Me.Controls.Add(Me.btnPrintJ)
        Me.Controls.Add(Me.btnDescs)
        Me.Controls.Add(Me.btnCancelJobs)
        Me.Controls.Add(Me.btnMaintainV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMaintainP)
        Me.Controls.Add(Me.btnMaintainD)
        Me.Controls.Add(Me.btnMaintainT)
        Me.Controls.Add(Me.btnMaintainG)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMaintenance"
        Me.Text = "Maintenance"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnMaintainG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintainG.Click

        Me.MaintainGenerator()

    End Sub

    Function MaintainGenerator()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newGForm As New frmGenerator
        newGForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnMaintainT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintainT.Click

        Me.MaintainTransporter()

    End Sub

    Function MaintainTransporter()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newTForm As New frmTransporter
        newTForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnMaintainD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintainD.Click

        Me.MaintainDisposal()

    End Sub

    Function MaintainDisposal()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newDForm As New frmDisposalFacility
        newDForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnMaintainP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintainP.Click

        Me.MaintainProducts()

    End Sub

    Function MaintainProducts()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newPForm As New frmProduct
        newPForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnMaintainV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintainV.Click

        Me.MaintainVendors()

    End Sub

    Function MaintainVendors()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newVForm As New frmVendor
        newVForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnCancelJobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelJobs.Click

        Me.MaintainJobs()

    End Sub

    Function MaintainJobs()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newCForm As New frmCancelJobs
        newCForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnDescs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescs.Click

        Me.MaintainDescs()

    End Sub

    Function MaintainDescs()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newDForm As New frmDescriptions
        newDForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btnPrintJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintJ.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newJForm As New frmMultiStops
        newJForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

End Class
