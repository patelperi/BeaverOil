Imports System
Imports System.Threading
Imports System.Security.Principal
Imports Microsoft.VisualBasic

Public Class frmMainScreen

    Inherits System.Windows.Forms.Form

    Dim frm As Form
    Public Shared IsOld As Boolean = System.Configuration.ConfigurationSettings.AppSettings("IsOld")

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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents MainLink2 As System.Windows.Forms.LinkLabel
    Friend WithEvents MainLink1 As System.Windows.Forms.LinkLabel
    Friend WithEvents leftFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MainLink4 As System.Windows.Forms.LinkLabel
    Friend WithEvents MainLink3 As System.Windows.Forms.LinkLabel
    Friend WithEvents MainLink5 As System.Windows.Forms.LinkLabel
    Friend WithEvents MainLink7 As System.Windows.Forms.LinkLabel
    Friend WithEvents MainLink6 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHeader1 As System.Windows.Forms.Label
    Friend WithEvents MainLink8 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MainLink9 As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInvoicing As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.MainLink7 = New System.Windows.Forms.LinkLabel
        Me.MainLink4 = New System.Windows.Forms.LinkLabel
        Me.MainLink3 = New System.Windows.Forms.LinkLabel
        Me.MainLink2 = New System.Windows.Forms.LinkLabel
        Me.MainLink1 = New System.Windows.Forms.LinkLabel
        Me.leftFrame = New System.Windows.Forms.GroupBox
        Me.MainLink9 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.MainLink8 = New System.Windows.Forms.LinkLabel
        Me.MainLink5 = New System.Windows.Forms.LinkLabel
        Me.MainLink6 = New System.Windows.Forms.LinkLabel
        Me.lblHeader1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.mnuInvoicing = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem118 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.leftFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 510)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(804, 16)
        Me.StatusBar1.TabIndex = 6
        '
        'MainLink7
        '
        Me.MainLink7.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink7.ForeColor = System.Drawing.Color.Black
        Me.MainLink7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink7.LinkColor = System.Drawing.Color.Black
        Me.MainLink7.Location = New System.Drawing.Point(2, 312)
        Me.MainLink7.Name = "MainLink7"
        Me.MainLink7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink7.Size = New System.Drawing.Size(144, 26)
        Me.MainLink7.TabIndex = 8
        Me.MainLink7.TabStop = True
        Me.MainLink7.Text = "&Maintenance"
        Me.MainLink7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink4
        '
        Me.MainLink4.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink4.ForeColor = System.Drawing.Color.Black
        Me.MainLink4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink4.LinkColor = System.Drawing.Color.Black
        Me.MainLink4.Location = New System.Drawing.Point(2, 200)
        Me.MainLink4.Name = "MainLink4"
        Me.MainLink4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink4.Size = New System.Drawing.Size(144, 41)
        Me.MainLink4.TabIndex = 5
        Me.MainLink4.TabStop = True
        Me.MainLink4.Text = "Job Closing / &Invoicing"
        Me.MainLink4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink3
        '
        Me.MainLink3.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink3.ForeColor = System.Drawing.Color.Black
        Me.MainLink3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink3.LinkColor = System.Drawing.Color.Black
        Me.MainLink3.Location = New System.Drawing.Point(2, 176)
        Me.MainLink3.Name = "MainLink3"
        Me.MainLink3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink3.Size = New System.Drawing.Size(144, 26)
        Me.MainLink3.TabIndex = 3
        Me.MainLink3.TabStop = True
        Me.MainLink3.Text = "&Paperwork"
        Me.MainLink3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink2
        '
        Me.MainLink2.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink2.ForeColor = System.Drawing.Color.Black
        Me.MainLink2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink2.LinkColor = System.Drawing.Color.Black
        Me.MainLink2.Location = New System.Drawing.Point(2, 152)
        Me.MainLink2.Name = "MainLink2"
        Me.MainLink2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink2.Size = New System.Drawing.Size(144, 26)
        Me.MainLink2.TabIndex = 2
        Me.MainLink2.TabStop = True
        Me.MainLink2.Text = "&Job Board"
        Me.MainLink2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink1
        '
        Me.MainLink1.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink1.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink1.ForeColor = System.Drawing.Color.Black
        Me.MainLink1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink1.LinkColor = System.Drawing.Color.Black
        Me.MainLink1.Location = New System.Drawing.Point(2, 128)
        Me.MainLink1.Name = "MainLink1"
        Me.MainLink1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink1.Size = New System.Drawing.Size(144, 26)
        Me.MainLink1.TabIndex = 1
        Me.MainLink1.TabStop = True
        Me.MainLink1.Text = "&New Job"
        Me.MainLink1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'leftFrame
        '
        Me.leftFrame.BackColor = System.Drawing.Color.LightSteelBlue
        Me.leftFrame.Controls.Add(Me.MainLink9)
        Me.leftFrame.Controls.Add(Me.Label1)
        Me.leftFrame.Controls.Add(Me.MainLink8)
        Me.leftFrame.Controls.Add(Me.MainLink4)
        Me.leftFrame.Controls.Add(Me.MainLink3)
        Me.leftFrame.Controls.Add(Me.MainLink2)
        Me.leftFrame.Controls.Add(Me.MainLink1)
        Me.leftFrame.Controls.Add(Me.MainLink5)
        Me.leftFrame.Controls.Add(Me.MainLink6)
        Me.leftFrame.Controls.Add(Me.MainLink7)
        Me.leftFrame.Controls.Add(Me.lblHeader1)
        Me.leftFrame.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leftFrame.ForeColor = System.Drawing.Color.White
        Me.leftFrame.Location = New System.Drawing.Point(0, 0)
        Me.leftFrame.Name = "leftFrame"
        Me.leftFrame.Size = New System.Drawing.Size(147, 510)
        Me.leftFrame.TabIndex = 10
        Me.leftFrame.TabStop = False
        Me.leftFrame.Visible = False
        '
        'MainLink9
        '
        Me.MainLink9.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink9.ForeColor = System.Drawing.Color.Black
        Me.MainLink9.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink9.LinkColor = System.Drawing.Color.Black
        Me.MainLink9.Location = New System.Drawing.Point(2, 264)
        Me.MainLink9.Name = "MainLink9"
        Me.MainLink9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink9.Size = New System.Drawing.Size(144, 26)
        Me.MainLink9.TabIndex = 14
        Me.MainLink9.TabStop = True
        Me.MainLink9.Text = "&Payables"
        Me.MainLink9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 56)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Job Tracking System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink8
        '
        Me.MainLink8.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink8.ForeColor = System.Drawing.Color.Black
        Me.MainLink8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink8.LinkColor = System.Drawing.Color.Black
        Me.MainLink8.Location = New System.Drawing.Point(2, 336)
        Me.MainLink8.Name = "MainLink8"
        Me.MainLink8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink8.Size = New System.Drawing.Size(144, 26)
        Me.MainLink8.TabIndex = 9
        Me.MainLink8.TabStop = True
        Me.MainLink8.Text = "&Exit Application"
        Me.MainLink8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink5
        '
        Me.MainLink5.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink5.ForeColor = System.Drawing.Color.Black
        Me.MainLink5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink5.LinkColor = System.Drawing.Color.Black
        Me.MainLink5.Location = New System.Drawing.Point(2, 240)
        Me.MainLink5.Name = "MainLink5"
        Me.MainLink5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink5.Size = New System.Drawing.Size(144, 26)
        Me.MainLink5.TabIndex = 6
        Me.MainLink5.TabStop = True
        Me.MainLink5.Text = "Re&ceivables"
        Me.MainLink5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLink6
        '
        Me.MainLink6.ActiveLinkColor = System.Drawing.Color.White
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainLink6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainLink6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLink6.ForeColor = System.Drawing.Color.Black
        Me.MainLink6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MainLink6.LinkColor = System.Drawing.Color.Black
        Me.MainLink6.Location = New System.Drawing.Point(2, 288)
        Me.MainLink6.Name = "MainLink6"
        Me.MainLink6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainLink6.Size = New System.Drawing.Size(144, 26)
        Me.MainLink6.TabIndex = 7
        Me.MainLink6.TabStop = True
        Me.MainLink6.Text = "&Reports"
        Me.MainLink6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeader1
        '
        Me.lblHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.ForeColor = System.Drawing.Color.Navy
        Me.lblHeader1.Location = New System.Drawing.Point(8, 16)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(128, 24)
        Me.lblHeader1.TabIndex = 12
        Me.lblHeader1.Text = "Beaver Oil"
        Me.lblHeader1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.mnuInvoicing, Me.MenuItem5, Me.MenuItem9, Me.MenuItem6, Me.MenuItem7, Me.MenuItem118, Me.MenuItem8})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "New Job"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Job Board"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Paperwork"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Open Job Ticket"
        '
        'mnuInvoicing
        '
        Me.mnuInvoicing.Index = 4
        Me.mnuInvoicing.Text = "Invoicing"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Receivables"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Text = "Payables"
        Me.MenuItem9.Visible = False
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Reports"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        Me.MenuItem7.Text = "Maintenance"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Maintain Generators"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Maintain Disposal Facilities"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Maintain Transporters"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "Maintain Products"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 4
        Me.MenuItem14.Text = "Maintain Vendors"
        Me.MenuItem14.Visible = False
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "Cancel Jobs"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 9
        Me.MenuItem118.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18})
        Me.MenuItem118.Text = "Closed Job"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Closed JobTicket"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "Closed Invoice"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 10
        Me.MenuItem8.Text = "Exit Application"
        '
        'frmMainScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(804, 526)
        Me.Controls.Add(Me.leftFrame)
        Me.Controls.Add(Me.StatusBar1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMainScreen"
        Me.Text = "Main Options Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.leftFrame.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub MainLink1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink1.LinkClicked

        Me.Link1Clicked()

    End Sub

    Public Sub MainLink2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink2.LinkClicked

        Me.Link2Clicked()

    End Sub

    Public Sub MainLink3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink3.LinkClicked

        Me.Link3Clicked()

    End Sub

    Public Sub MainLink4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink4.LinkClicked

        Me.Link4Clicked()

    End Sub

    Public Sub MainLink5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink5.LinkClicked

        Me.Link5Clicked()

    End Sub

    Public Sub MainLink6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink6.LinkClicked

        Me.Link6Clicked()

    End Sub

    Public Sub MainLink7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink7.LinkClicked

        Me.Link7Clicked()

    End Sub

    Public Sub MainLink8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink8.LinkClicked

        Me.Link8Clicked()

    End Sub

    Private Sub MainLink9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainLink9.LinkClicked

        Me.Link9Clicked()

    End Sub

    Private Sub frmMainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsOld = True Then
            If MsgBox("You are about to use archive data. Are you sure you want to continue?", MsgBoxStyle.YesNo, "Archive Data") = MsgBoxResult.No Then
                Application.Exit()
            End If
            Me.ForeColor = Color.Red
        End If

        Me.StatusBar1.Text = "Current Date/Time : " & Date.Now
        Me.leftFrame.Height = Me.Height
        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmNewJob" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Sub
            End If
        End If
        'Me.ScheduleRecurringJobs()
        Dim child_frmMain As New frmNewJob
        child_frmMain.MdiParent = Me
        child_frmMain.Show()
        child_frmMain.Dock = DockStyle.Top
        child_frmMain.WindowState = FormWindowState.Maximized

        If IsOld = True Then
            child_frmMain.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub frmMainScreen_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub

    Public Function Link1Clicked()
        Me.Text = "New Job"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmNewJob" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmNewJob As New frmNewJob
        child_frmNewJob.MdiParent = Me
        child_frmNewJob.WindowState = FormWindowState.Maximized
        child_frmNewJob.Show()
        If IsOld = True Then
            child_frmNewJob.BackColor = Color.Yellow
        End If
        Me.MainLink1.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link2Clicked()

        Me.Text = "Job Board"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmJobBoard" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmJobBoard As New frmJobBoard
        child_frmJobBoard.MdiParent = Me
        child_frmJobBoard.Show()
        child_frmJobBoard.WindowState = FormWindowState.Maximized
        If IsOld = True Then
            child_frmJobBoard.BackColor = Color.Yellow
        End If

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link3Clicked()

        Me.Text = "Paper Work"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmPaperwork" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmPaperwork As New frmPaperwork
        child_frmPaperwork.MdiParent = Me
        child_frmPaperwork.Show()
        child_frmPaperwork.WindowState = FormWindowState.Maximized
        If IsOld = True Then
            child_frmPaperwork.BackColor = Color.Yellow
        End If

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link4Clicked()

        Me.Text = "Open JobTicket List"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmInvoicing" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmInvoicing As New frmInvoicing(False)
        child_frmInvoicing.MdiParent = Me
        child_frmInvoicing.Show()
        child_frmInvoicing.WindowState = FormWindowState.Maximized

        If IsOld = True Then
            child_frmInvoicing.BackColor = Color.Yellow
        End If

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link5Clicked()

        Me.Text = "Receivables"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmReceivables" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmReceivables As New frmReceivables
        child_frmReceivables.MdiParent = Me
        child_frmReceivables.Show()
        child_frmReceivables.WindowState = FormWindowState.Maximized

        If IsOld = True Then
            child_frmReceivables.BackColor = Color.Yellow
        End If

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link6Clicked()

        Me.Text = "Reports"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmSelectReport" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmReports As New frmSelectReport
        child_frmReports.MdiParent = Me
        child_frmReports.Show()
        child_frmReports.WindowState = FormWindowState.Maximized
        If IsOld = True Then
            child_frmReports.BackColor = Color.Yellow
        End If
        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link7Clicked()

        Me.Text = "Maintenance"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmMaintenance" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmMaintenance As New frmMaintenance
        child_frmMaintenance.MdiParent = Me
        child_frmMaintenance.Show()
        child_frmMaintenance.WindowState = FormWindowState.Maximized

        If IsOld = True Then
            child_frmMaintenance.BackColor = Color.Yellow

        End If

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Public Function Link8Clicked()

        If MsgBox("Are you sure you want to Exit Job Tracking System?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Application.Exit()

        End If

    End Function

    Public Function Link9Clicked()

        Me.Text = "Payables"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmPayable" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Function
            End If
        End If

        Dim child_frmPayable As New frmPayable
        child_frmPayable.MdiParent = Me
        child_frmPayable.Show()
        child_frmPayable.WindowState = FormWindowState.Maximized

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.SteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.Link1Clicked()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Link2Clicked()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.Link3Clicked()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Link4Clicked()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Me.Link5Clicked()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Me.Link6Clicked()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.Link7Clicked()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        Me.Link8Clicked()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Me.Link9Clicked()
    End Sub

    Function MaintainGenerator()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newGForm As New frmGenerator
        newGForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function MaintainTransporter()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newTForm As New frmTransporter
        newTForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function MaintainDisposal()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newDForm As New frmDisposalFacility
        newDForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function MaintainProducts()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newPForm As New frmProduct
        newPForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function MaintainVendors()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newVForm As New frmVendor
        newVForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function MaintainJobs()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newCForm As New frmCancelJobs
        newCForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click

        Me.MaintainGenerator()

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click

        Me.MaintainDisposal()

    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click

        Me.MaintainTransporter()

    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click

        Me.MaintainProducts()

    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click

        Me.MaintainVendors()

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click

        Me.MaintainJobs()

    End Sub

    'Function ScheduleRecurringJobs()

    '    Dim ds As DataSet
    '    Try
    '        Dim monDate As Date = DateAdd(DateInterval.Day, 1 - Now.DayOfWeek, Date.Now)
    '        monDate = monDate.ToShortDateString
    '        ds = DBHelper.GetDataSet("SELECT * FROM tblJobTickets_Recurring WHERE IsCancelled = False AND (JobStartDate <= #" & Date.Now.ToShortDateString & "# OR (JobStartDate  >= #" & Date.Now.ToShortDateString & "# AND JobStartDate <= #" & DateAdd(DateInterval.Day, 6, CDate(Date.Now.ToShortDateString)) & " #))", "tblRec")
    '        Dim iCount As Integer = ds.Tables(0).Rows.Count, i As Integer = 0
    '        Dim jtID As Long, JobDate As Date, strSQL As String, nextJTID As Long
    '        If iCount > 0 Then
    '            With ds.Tables(0)
    '                For i = 0 To iCount - 1
    '                    Select Case .Rows(i).Item("WeekDay")
    '                        Case "Sunday", "Sun"
    '                            JobDate = DateAdd(DateInterval.Day, 6, monDate)
    '                        Case "Monday", "Mon"
    '                            JobDate = monDate
    '                        Case "Tuesday", "Tue"
    '                            JobDate = DateAdd(DateInterval.Day, 1, monDate)
    '                        Case "Wednesday", "Wed"
    '                            JobDate = DateAdd(DateInterval.Day, 2, monDate)
    '                        Case "Thursday", "Thu"
    '                            JobDate = DateAdd(DateInterval.Day, 3, monDate)
    '                        Case "Friday", "Fri"
    '                            JobDate = DateAdd(DateInterval.Day, 4, monDate)
    '                        Case "Saturday", "Sat"
    '                            JobDate = DateAdd(DateInterval.Day, 5, monDate)
    '                    End Select
    '                    jtID = .Rows(i).Item("JobTicketID")
    '                    nextJTID = DBHelper.GetInteger("SELECT Max(JobTicketNo) FROM tblJobTickets")
    '                    nextJTID = IIf(nextJTID = 0, 1000, nextJTID + 1)
    '                    If DBHelper.GetRecordCount("SELECT Count(*) FROM tblJobTickets WHERE ScheduleDate = #" & JobDate & "# AND R_JobTicketID = " & jtID & "") <= 0 Then
    '                        strSQL = "INSERT INTO tblJobTickets (JobTicketNo, ProductID, ScheduleDate, NonHazardous, BillOfLading, Hazardous, JobTicket, Plant2Manifest, " _
    '                                                            & "TypeOfTruckID, IsBeaver, IsMultiStop, IsOutsideHauler, SpecialInstructions, ScheduledTime, TransporterID, " _
    '                                                            & "DisposalFacilityID, SpecialInstructions_T, Drums, JobPO, PrintFormC, R_JobTicketID) " _
    '                                    & " SELECT " & nextJTID & ", ProductID, #" & JobDate & "#, NonHazardous, BillOfLading, Hazardous, JobTicket, Plant2Manifest, " _
    '                                                            & "TypeOfTruckID, IsBeaver, IsMultiStop, IsOutsideHauler, SpecialInstructions, ScheduledTime, TransporterID, " _
    '                                                            & "DisposalFacilityID, SpecialInstructions_T, Drums, JobPO, PrintFormC, " & jtID & " FROM tblJobTickets_Recurring WHERE JobTicketID = " & jtID & ";"
    '                        DBHelper.ExecuteQuery(strSQL)
    '                    End If
    '                Next
    '            End With
    '        End If

    '    Catch ex As Exception

    '    Finally

    '        ds = Nothing

    '    End Try

    'End Function

    Private Sub mnuInvoicing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInvoicing.Click
        Me.Text = "Invoicing"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmInvoicingList" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Sub
            End If
        End If

        Dim child_frmInvoicingList As New frmInvoicingList(False)
        child_frmInvoicingList.MdiParent = Me
        child_frmInvoicingList.Show()
        child_frmInvoicingList.WindowState = FormWindowState.Maximized

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click

        Me.Text = "Closed JobTicket List"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmInvoicing" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Sub
            End If
        End If

        Dim child_frmInvoicing As New frmInvoicing(True)
        child_frmInvoicing.MdiParent = Me
        child_frmInvoicing.Show()
        child_frmInvoicing.WindowState = FormWindowState.Maximized

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Me.Text = "Invoicing"

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If IsNothing(Me.ActiveMdiChild) = False Then
            frm = Me.ActiveMdiChild
            If frm.Name <> "frmInvoicingList" Then
                If frm.WindowState <> FormWindowState.Minimized Then
                    frm.Close()
                End If
            Else
                Exit Sub
            End If
        End If

        Dim child_frmInvoicingList As New frmInvoicingList(True)
        child_frmInvoicingList.MdiParent = Me
        child_frmInvoicingList.Show()
        child_frmInvoicingList.WindowState = FormWindowState.Maximized

        Me.MainLink1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink4.BackColor = System.Drawing.Color.SlateGray
        Me.MainLink5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MainLink9.BackColor = System.Drawing.Color.LightSteelBlue

        Cursor.Current = System.Windows.Forms.Cursors.Default


    End Sub
    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Application.Exit()
    End Sub
End Class
