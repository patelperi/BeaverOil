Public Class frmJobBoard

    Inherits System.Windows.Forms.Form

    Dim thisDate As Date, monDate As Date, tueDate As Date, wedDate As Date, thuDate As Date, friDate As Date, satDate As Date, sunDate As Date
    Dim rCount As Integer, curWeekMonDate As Date
    Dim dsrptJobBoard As DataSet = New DataSet

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        thisDate = Date.Now.ToShortDateString
        curWeekMonDate = DateAdd(DateInterval.Day, 1 - thisDate.DayOfWeek, thisDate)
        monDate = DateAdd(DateInterval.Day, 1 - thisDate.DayOfWeek, thisDate)
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
    Friend WithEvents dgJobBoard As System.Windows.Forms.DataGrid
    Friend WithEvents btnMonday As System.Windows.Forms.Button
    Friend WithEvents btnTuesday As System.Windows.Forms.Button
    Friend WithEvents btnWednesday As System.Windows.Forms.Button
    Friend WithEvents btnThursday As System.Windows.Forms.Button
    Friend WithEvents btnFriday As System.Windows.Forms.Button
    Friend WithEvents btnRecurring As System.Windows.Forms.Button
    Friend WithEvents DsJobBoard1 As BeaverOil.DSJobBoard
    Friend WithEvents DAJobBoard As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectJobBoard As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateJobBoard As System.Data.OleDb.OleDbCommand
    Friend WithEvents DARecurringJobs As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectRecurringJobs As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsRecurringJobs1 As BeaverOil.DSRecurringJobs
    Friend WithEvents cmbWhatWeek As System.Windows.Forms.ComboBox
    Friend WithEvents lblWhichWeek As System.Windows.Forms.Label
    Friend WithEvents btnHauler As System.Windows.Forms.Button
    Friend WithEvents btnMultiStop As System.Windows.Forms.Button
    Friend WithEvents btnSaturday As System.Windows.Forms.Button
    Friend WithEvents btnSunday As System.Windows.Forms.Button
    Friend WithEvents DAMultiStops As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectMultiStop As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DGMultiStops As System.Windows.Forms.DataGrid
    Friend WithEvents DAOutsideHaulers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectOutsideHaulers As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsMultiStops1 As BeaverOil.DSMultiStops
    Friend WithEvents DsOutsideHaulers1 As BeaverOil.DSOutsideHaulers
    Friend WithEvents DGOutsideHaulers As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ts_dgGrids As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_dgGrids_J As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_G As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_P As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_D As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_SD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ts_OutsideHaulers As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_Outsidehaulers_JID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Outsidehaulers_G As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Outsidehaulers_P As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Outsidehaulers_H As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Outsidehaulers_SD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_SI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_ST As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_Drums As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_OutsideHaulers_Drums As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_dgGrids_JD As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_OutsideHaulers_JD As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_dgGrids_SI_J As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_TT As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_OutsideHaulers_TT As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgGrids_C As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRecurringJobs As System.Windows.Forms.DataGrid
    Friend WithEvents dgStyle_R As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents UpdateRecurring As System.Data.OleDb.OleDbCommand
    Friend WithEvents col_OccursEvery As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_R_G As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_R_JS As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_R_JSC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_R_PN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_R_JSD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_R_CAN As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_M_JID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_M_GN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_M_C As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_M_PN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_M_DN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_M_SD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_TS_MultiStops As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_M_TT As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_M_JD As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_M_Drums As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Upd_O_H As System.Data.OleDb.OleDbCommand
    Friend WithEvents col_Cancell As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_R_JED As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents col_Special As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnPrintOutside As System.Windows.Forms.Button
    Friend WithEvents btnPrintMultiStop As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DGOutsideHaulers = New System.Windows.Forms.DataGrid
        Me.DsOutsideHaulers1 = New BeaverOil.DSOutsideHaulers
        Me.ts_OutsideHaulers = New System.Windows.Forms.DataGridTableStyle
        Me.col_Outsidehaulers_JID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Outsidehaulers_G = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Outsidehaulers_P = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Outsidehaulers_H = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Outsidehaulers_SD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_OutsideHaulers_Drums = New System.Windows.Forms.DataGridBoolColumn
        Me.col_OutsideHaulers_TT = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_OutsideHaulers_JD = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DGMultiStops = New System.Windows.Forms.DataGrid
        Me.DsMultiStops1 = New BeaverOil.DSMultiStops
        Me.dg_TS_MultiStops = New System.Windows.Forms.DataGridTableStyle
        Me.col_M_JID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_GN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_C = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_PN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_DN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_SD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_Drums = New System.Windows.Forms.DataGridBoolColumn
        Me.col_M_TT = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_M_JD = New System.Windows.Forms.DataGridBoolColumn
        Me.col_Special = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRecurringJobs = New System.Windows.Forms.DataGrid
        Me.DsRecurringJobs1 = New BeaverOil.DSRecurringJobs
        Me.dgStyle_R = New System.Windows.Forms.DataGridTableStyle
        Me.col_R_G = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_R_JS = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_R_JSC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_R_PN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_R_JSD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_R_JED = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_OccursEvery = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_R_CAN = New System.Windows.Forms.DataGridBoolColumn
        Me.dgJobBoard = New System.Windows.Forms.DataGrid
        Me.DsJobBoard1 = New BeaverOil.DSJobBoard
        Me.ts_dgGrids = New System.Windows.Forms.DataGridTableStyle
        Me.col_dgGrids_J = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_G = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_C = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_P = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_SI = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_ST = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_D = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_Drums = New System.Windows.Forms.DataGridBoolColumn
        Me.col_dgGrids_TT = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_SD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgGrids_JD = New System.Windows.Forms.DataGridBoolColumn
        Me.col_Cancell = New System.Windows.Forms.DataGridBoolColumn
        Me.col_dgGrids_SI_J = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnMonday = New System.Windows.Forms.Button
        Me.btnTuesday = New System.Windows.Forms.Button
        Me.btnWednesday = New System.Windows.Forms.Button
        Me.btnThursday = New System.Windows.Forms.Button
        Me.btnFriday = New System.Windows.Forms.Button
        Me.btnRecurring = New System.Windows.Forms.Button
        Me.DAJobBoard = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectJobBoard = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.UpdateJobBoard = New System.Data.OleDb.OleDbCommand
        Me.DARecurringJobs = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectRecurringJobs = New System.Data.OleDb.OleDbCommand
        Me.UpdateRecurring = New System.Data.OleDb.OleDbCommand
        Me.cmbWhatWeek = New System.Windows.Forms.ComboBox
        Me.lblWhichWeek = New System.Windows.Forms.Label
        Me.btnHauler = New System.Windows.Forms.Button
        Me.btnMultiStop = New System.Windows.Forms.Button
        Me.btnSaturday = New System.Windows.Forms.Button
        Me.btnSunday = New System.Windows.Forms.Button
        Me.DAMultiStops = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectMultiStop = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand5 = New System.Data.OleDb.OleDbCommand
        Me.DAOutsideHaulers = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectOutsideHaulers = New System.Data.OleDb.OleDbCommand
        Me.Upd_O_H = New System.Data.OleDb.OleDbCommand
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnPrintOutside = New System.Windows.Forms.Button
        Me.btnPrintMultiStop = New System.Windows.Forms.Button
        CType(Me.DGOutsideHaulers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsOutsideHaulers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMultiStops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMultiStops1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRecurringJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRecurringJobs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgJobBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsJobBoard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGOutsideHaulers
        '
        Me.DGOutsideHaulers.CaptionText = "Outside Haulers"
        Me.DGOutsideHaulers.DataMember = "tblJobTickets"
        Me.DGOutsideHaulers.DataSource = Me.DsOutsideHaulers1
        Me.DGOutsideHaulers.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGOutsideHaulers.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGOutsideHaulers.Location = New System.Drawing.Point(1, 40)
        Me.DGOutsideHaulers.Name = "DGOutsideHaulers"
        Me.DGOutsideHaulers.ParentRowsVisible = False
        Me.DGOutsideHaulers.RowHeadersVisible = False
        Me.DGOutsideHaulers.Size = New System.Drawing.Size(1027, 602)
        Me.DGOutsideHaulers.TabIndex = 4
        Me.DGOutsideHaulers.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_OutsideHaulers})
        '
        'DsOutsideHaulers1
        '
        Me.DsOutsideHaulers1.DataSetName = "DSOutsideHaulers"
        Me.DsOutsideHaulers1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_OutsideHaulers
        '
        Me.ts_OutsideHaulers.AlternatingBackColor = System.Drawing.Color.Silver
        Me.ts_OutsideHaulers.BackColor = System.Drawing.Color.White
        Me.ts_OutsideHaulers.DataGrid = Me.DGOutsideHaulers
        Me.ts_OutsideHaulers.ForeColor = System.Drawing.Color.Black
        Me.ts_OutsideHaulers.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_Outsidehaulers_JID, Me.col_Outsidehaulers_G, Me.col_Outsidehaulers_P, Me.col_Outsidehaulers_H, Me.col_Outsidehaulers_SD, Me.col_OutsideHaulers_Drums, Me.col_OutsideHaulers_TT, Me.col_OutsideHaulers_JD, Me.DataGridTextBoxColumn3})
        Me.ts_OutsideHaulers.GridLineColor = System.Drawing.Color.Black
        Me.ts_OutsideHaulers.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.ts_OutsideHaulers.HeaderFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_OutsideHaulers.HeaderForeColor = System.Drawing.Color.White
        Me.ts_OutsideHaulers.MappingName = "tblJobTickets"
        Me.ts_OutsideHaulers.RowHeadersVisible = False
        '
        'col_Outsidehaulers_JID
        '
        Me.col_Outsidehaulers_JID.Format = ""
        Me.col_Outsidehaulers_JID.FormatInfo = Nothing
        Me.col_Outsidehaulers_JID.HeaderText = "JID"
        Me.col_Outsidehaulers_JID.MappingName = "JobTicketID"
        Me.col_Outsidehaulers_JID.Width = 0
        '
        'col_Outsidehaulers_G
        '
        Me.col_Outsidehaulers_G.Format = ""
        Me.col_Outsidehaulers_G.FormatInfo = Nothing
        Me.col_Outsidehaulers_G.HeaderText = "Generator"
        Me.col_Outsidehaulers_G.MappingName = "GeneratorName"
        Me.col_Outsidehaulers_G.NullText = ""
        Me.col_Outsidehaulers_G.ReadOnly = True
        Me.col_Outsidehaulers_G.Width = 175
        '
        'col_Outsidehaulers_P
        '
        Me.col_Outsidehaulers_P.Format = ""
        Me.col_Outsidehaulers_P.FormatInfo = Nothing
        Me.col_Outsidehaulers_P.HeaderText = "Product"
        Me.col_Outsidehaulers_P.MappingName = "ProductName"
        Me.col_Outsidehaulers_P.NullText = ""
        Me.col_Outsidehaulers_P.ReadOnly = True
        Me.col_Outsidehaulers_P.Width = 150
        '
        'col_Outsidehaulers_H
        '
        Me.col_Outsidehaulers_H.Format = ""
        Me.col_Outsidehaulers_H.FormatInfo = Nothing
        Me.col_Outsidehaulers_H.HeaderText = "Hauler"
        Me.col_Outsidehaulers_H.MappingName = "TransporterName"
        Me.col_Outsidehaulers_H.NullText = ""
        Me.col_Outsidehaulers_H.ReadOnly = True
        Me.col_Outsidehaulers_H.Width = 160
        '
        'col_Outsidehaulers_SD
        '
        Me.col_Outsidehaulers_SD.Format = "d"
        Me.col_Outsidehaulers_SD.FormatInfo = Nothing
        Me.col_Outsidehaulers_SD.HeaderText = "Sch. Date"
        Me.col_Outsidehaulers_SD.MappingName = "ScheduleDate"
        Me.col_Outsidehaulers_SD.NullText = ""
        Me.col_Outsidehaulers_SD.Width = 110
        '
        'col_OutsideHaulers_Drums
        '
        Me.col_OutsideHaulers_Drums.AllowNull = False
        Me.col_OutsideHaulers_Drums.FalseValue = False
        Me.col_OutsideHaulers_Drums.HeaderText = "Drums"
        Me.col_OutsideHaulers_Drums.MappingName = "Drums"
        Me.col_OutsideHaulers_Drums.NullText = ""
        Me.col_OutsideHaulers_Drums.NullValue = "False"
        Me.col_OutsideHaulers_Drums.ReadOnly = True
        Me.col_OutsideHaulers_Drums.TrueValue = True
        Me.col_OutsideHaulers_Drums.Width = 50
        '
        'col_OutsideHaulers_TT
        '
        Me.col_OutsideHaulers_TT.Format = ""
        Me.col_OutsideHaulers_TT.FormatInfo = Nothing
        Me.col_OutsideHaulers_TT.HeaderText = "Type of Truck"
        Me.col_OutsideHaulers_TT.MappingName = "TypeOfTruck"
        Me.col_OutsideHaulers_TT.NullText = ""
        Me.col_OutsideHaulers_TT.ReadOnly = True
        Me.col_OutsideHaulers_TT.Width = 110
        '
        'col_OutsideHaulers_JD
        '
        Me.col_OutsideHaulers_JD.AllowNull = False
        Me.col_OutsideHaulers_JD.FalseValue = False
        Me.col_OutsideHaulers_JD.HeaderText = "Done?"
        Me.col_OutsideHaulers_JD.MappingName = "JobDone"
        Me.col_OutsideHaulers_JD.NullText = ""
        Me.col_OutsideHaulers_JD.NullValue = "False"
        Me.col_OutsideHaulers_JD.TrueValue = True
        Me.col_OutsideHaulers_JD.Width = 50
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Customer Name"
        Me.DataGridTextBoxColumn3.MappingName = "CustomerName"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 180
        '
        'DGMultiStops
        '
        Me.DGMultiStops.CaptionText = "Multi-Stops"
        Me.DGMultiStops.DataMember = "tblJobTickets"
        Me.DGMultiStops.DataSource = Me.DsMultiStops1
        Me.DGMultiStops.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGMultiStops.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGMultiStops.Location = New System.Drawing.Point(0, 40)
        Me.DGMultiStops.Name = "DGMultiStops"
        Me.DGMultiStops.ParentRowsVisible = False
        Me.DGMultiStops.RowHeadersVisible = False
        Me.DGMultiStops.Size = New System.Drawing.Size(1026, 604)
        Me.DGMultiStops.TabIndex = 5
        Me.DGMultiStops.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dg_TS_MultiStops})
        '
        'DsMultiStops1
        '
        Me.DsMultiStops1.DataSetName = "DSMultiStops"
        Me.DsMultiStops1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dg_TS_MultiStops
        '
        Me.dg_TS_MultiStops.AlternatingBackColor = System.Drawing.Color.Silver
        Me.dg_TS_MultiStops.DataGrid = Me.DGMultiStops
        Me.dg_TS_MultiStops.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_M_JID, Me.col_M_GN, Me.col_M_C, Me.col_M_PN, Me.col_M_DN, Me.col_M_SD, Me.col_M_Drums, Me.col_M_TT, Me.col_M_JD, Me.col_Special})
        Me.dg_TS_MultiStops.GridLineColor = System.Drawing.Color.Black
        Me.dg_TS_MultiStops.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.dg_TS_MultiStops.HeaderFont = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_TS_MultiStops.HeaderForeColor = System.Drawing.Color.White
        Me.dg_TS_MultiStops.MappingName = "tblJobTickets"
        Me.dg_TS_MultiStops.RowHeadersVisible = False
        '
        'col_M_JID
        '
        Me.col_M_JID.Format = ""
        Me.col_M_JID.FormatInfo = Nothing
        Me.col_M_JID.HeaderText = "Job Ticket ID"
        Me.col_M_JID.MappingName = "JobTicketID"
        Me.col_M_JID.NullText = ""
        Me.col_M_JID.ReadOnly = True
        Me.col_M_JID.Width = 0
        '
        'col_M_GN
        '
        Me.col_M_GN.Format = ""
        Me.col_M_GN.FormatInfo = Nothing
        Me.col_M_GN.HeaderText = "Generator"
        Me.col_M_GN.MappingName = "GeneratorName"
        Me.col_M_GN.NullText = ""
        Me.col_M_GN.ReadOnly = True
        Me.col_M_GN.Width = 180
        '
        'col_M_C
        '
        Me.col_M_C.Format = ""
        Me.col_M_C.FormatInfo = Nothing
        Me.col_M_C.HeaderText = "City"
        Me.col_M_C.MappingName = "JobSiteCity"
        Me.col_M_C.NullText = ""
        Me.col_M_C.ReadOnly = True
        Me.col_M_C.Width = 120
        '
        'col_M_PN
        '
        Me.col_M_PN.Format = ""
        Me.col_M_PN.FormatInfo = Nothing
        Me.col_M_PN.HeaderText = "Product"
        Me.col_M_PN.MappingName = "ProductName"
        Me.col_M_PN.NullText = ""
        Me.col_M_PN.ReadOnly = True
        Me.col_M_PN.Width = 150
        '
        'col_M_DN
        '
        Me.col_M_DN.Format = ""
        Me.col_M_DN.FormatInfo = Nothing
        Me.col_M_DN.HeaderText = "Driver"
        Me.col_M_DN.MappingName = "DriverName"
        Me.col_M_DN.NullText = ""
        Me.col_M_DN.Width = 125
        '
        'col_M_SD
        '
        Me.col_M_SD.Format = "d"
        Me.col_M_SD.FormatInfo = Nothing
        Me.col_M_SD.HeaderText = "Sch. Date"
        Me.col_M_SD.MappingName = "ScheduleDate"
        Me.col_M_SD.NullText = ""
        Me.col_M_SD.Width = 110
        '
        'col_M_Drums
        '
        Me.col_M_Drums.AllowNull = False
        Me.col_M_Drums.FalseValue = False
        Me.col_M_Drums.HeaderText = "Drums"
        Me.col_M_Drums.MappingName = "Drums"
        Me.col_M_Drums.NullText = ""
        Me.col_M_Drums.NullValue = "False"
        Me.col_M_Drums.ReadOnly = True
        Me.col_M_Drums.TrueValue = True
        Me.col_M_Drums.Width = 75
        '
        'col_M_TT
        '
        Me.col_M_TT.Format = ""
        Me.col_M_TT.FormatInfo = Nothing
        Me.col_M_TT.HeaderText = "Type of Truck"
        Me.col_M_TT.MappingName = "TypeOfTruck"
        Me.col_M_TT.NullText = ""
        Me.col_M_TT.ReadOnly = True
        Me.col_M_TT.Width = 125
        '
        'col_M_JD
        '
        Me.col_M_JD.AllowNull = False
        Me.col_M_JD.FalseValue = False
        Me.col_M_JD.HeaderText = "Done?"
        Me.col_M_JD.MappingName = "JobDone"
        Me.col_M_JD.NullText = ""
        Me.col_M_JD.NullValue = "False"
        Me.col_M_JD.TrueValue = True
        Me.col_M_JD.Width = 70
        '
        'col_Special
        '
        Me.col_Special.Format = ""
        Me.col_Special.FormatInfo = Nothing
        Me.col_Special.HeaderText = "Special Instruction"
        Me.col_Special.MappingName = "SpecialInstructions"
        Me.col_Special.NullText = ""
        Me.col_Special.Width = 130
        '
        'dgRecurringJobs
        '
        Me.dgRecurringJobs.CaptionText = "Recurring Jobs"
        Me.dgRecurringJobs.DataMember = "tblJobTickets_Recurring"
        Me.dgRecurringJobs.DataSource = Me.DsRecurringJobs1
        Me.dgRecurringJobs.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRecurringJobs.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRecurringJobs.Location = New System.Drawing.Point(0, 40)
        Me.dgRecurringJobs.Name = "dgRecurringJobs"
        Me.dgRecurringJobs.ParentRowsVisible = False
        Me.dgRecurringJobs.RowHeadersVisible = False
        Me.dgRecurringJobs.Size = New System.Drawing.Size(1028, 602)
        Me.dgRecurringJobs.TabIndex = 16
        Me.dgRecurringJobs.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgStyle_R})
        '
        'DsRecurringJobs1
        '
        Me.DsRecurringJobs1.DataSetName = "DSRecurringJobs"
        Me.DsRecurringJobs1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dgStyle_R
        '
        Me.dgStyle_R.AlternatingBackColor = System.Drawing.Color.Silver
        Me.dgStyle_R.BackColor = System.Drawing.Color.White
        Me.dgStyle_R.DataGrid = Me.dgRecurringJobs
        Me.dgStyle_R.ForeColor = System.Drawing.Color.Black
        Me.dgStyle_R.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_R_G, Me.col_R_JS, Me.col_R_JSC, Me.col_R_PN, Me.col_R_JSD, Me.col_R_JED, Me.col_OccursEvery, Me.col_R_CAN})
        Me.dgStyle_R.GridLineColor = System.Drawing.Color.Black
        Me.dgStyle_R.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.dgStyle_R.HeaderFont = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgStyle_R.HeaderForeColor = System.Drawing.Color.White
        Me.dgStyle_R.MappingName = "tblJobTickets_Recurring"
        Me.dgStyle_R.RowHeadersVisible = False
        '
        'col_R_G
        '
        Me.col_R_G.Format = ""
        Me.col_R_G.FormatInfo = Nothing
        Me.col_R_G.MappingName = "JobTicketID"
        Me.col_R_G.ReadOnly = True
        Me.col_R_G.Width = 0
        '
        'col_R_JS
        '
        Me.col_R_JS.Format = ""
        Me.col_R_JS.FormatInfo = Nothing
        Me.col_R_JS.HeaderText = "Generator"
        Me.col_R_JS.MappingName = "JobSite"
        Me.col_R_JS.NullText = ""
        Me.col_R_JS.ReadOnly = True
        Me.col_R_JS.Width = 185
        '
        'col_R_JSC
        '
        Me.col_R_JSC.Format = ""
        Me.col_R_JSC.FormatInfo = Nothing
        Me.col_R_JSC.HeaderText = "City"
        Me.col_R_JSC.MappingName = "JobSiteCity"
        Me.col_R_JSC.NullText = ""
        Me.col_R_JSC.ReadOnly = True
        Me.col_R_JSC.Width = 125
        '
        'col_R_PN
        '
        Me.col_R_PN.Format = ""
        Me.col_R_PN.FormatInfo = Nothing
        Me.col_R_PN.HeaderText = "Product"
        Me.col_R_PN.MappingName = "ProductName"
        Me.col_R_PN.NullText = ""
        Me.col_R_PN.ReadOnly = True
        Me.col_R_PN.Width = 185
        '
        'col_R_JSD
        '
        Me.col_R_JSD.Format = "d"
        Me.col_R_JSD.FormatInfo = Nothing
        Me.col_R_JSD.HeaderText = "Start Date"
        Me.col_R_JSD.MappingName = "JobStartDate"
        Me.col_R_JSD.NullText = ""
        Me.col_R_JSD.ReadOnly = True
        Me.col_R_JSD.Width = 125
        '
        'col_R_JED
        '
        Me.col_R_JED.Format = "d"
        Me.col_R_JED.FormatInfo = Nothing
        Me.col_R_JED.HeaderText = "End Date"
        Me.col_R_JED.MappingName = "JobEndDate"
        Me.col_R_JED.NullText = ""
        Me.col_R_JED.ReadOnly = True
        Me.col_R_JED.Width = 125
        '
        'col_OccursEvery
        '
        Me.col_OccursEvery.Format = ""
        Me.col_OccursEvery.FormatInfo = Nothing
        Me.col_OccursEvery.HeaderText = "Occurs Every"
        Me.col_OccursEvery.MappingName = "WeekDay"
        Me.col_OccursEvery.NullText = ""
        Me.col_OccursEvery.Width = 110
        '
        'col_R_CAN
        '
        Me.col_R_CAN.AllowNull = False
        Me.col_R_CAN.FalseValue = False
        Me.col_R_CAN.HeaderText = "Cancel Job?"
        Me.col_R_CAN.MappingName = "IsCancelled"
        Me.col_R_CAN.NullText = "False"
        Me.col_R_CAN.NullValue = False
        Me.col_R_CAN.TrueValue = True
        Me.col_R_CAN.Width = 120
        '
        'dgJobBoard
        '
        Me.dgJobBoard.CaptionText = "Job Board"
        Me.dgJobBoard.DataMember = "tblJobTickets"
        Me.dgJobBoard.DataSource = Me.DsJobBoard1
        Me.dgJobBoard.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgJobBoard.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgJobBoard.Location = New System.Drawing.Point(0, 40)
        Me.dgJobBoard.Name = "dgJobBoard"
        Me.dgJobBoard.ParentRowsVisible = False
        Me.dgJobBoard.RowHeadersVisible = False
        Me.dgJobBoard.Size = New System.Drawing.Size(1030, 600)
        Me.dgJobBoard.TabIndex = 4
        Me.dgJobBoard.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgGrids})
        '
        'DsJobBoard1
        '
        Me.DsJobBoard1.DataSetName = "DSJobBoard"
        Me.DsJobBoard1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_dgGrids
        '
        Me.ts_dgGrids.AlternatingBackColor = System.Drawing.Color.Silver
        Me.ts_dgGrids.DataGrid = Me.dgJobBoard
        Me.ts_dgGrids.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_dgGrids_J, Me.col_dgGrids_G, Me.col_dgGrids_C, Me.col_dgGrids_P, Me.col_dgGrids_SI, Me.col_dgGrids_ST, Me.col_dgGrids_D, Me.col_dgGrids_Drums, Me.col_dgGrids_TT, Me.col_dgGrids_SD, Me.col_dgGrids_JD, Me.col_Cancell, Me.col_dgGrids_SI_J})
        Me.ts_dgGrids.GridLineColor = System.Drawing.Color.Black
        Me.ts_dgGrids.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.ts_dgGrids.HeaderFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_dgGrids.HeaderForeColor = System.Drawing.Color.White
        Me.ts_dgGrids.MappingName = "tblJobTickets"
        Me.ts_dgGrids.PreferredRowHeight = 32
        Me.ts_dgGrids.RowHeadersVisible = False
        '
        'col_dgGrids_J
        '
        Me.col_dgGrids_J.Format = ""
        Me.col_dgGrids_J.FormatInfo = Nothing
        Me.col_dgGrids_J.HeaderText = "JobTicket"
        Me.col_dgGrids_J.MappingName = "JobTicketID"
        Me.col_dgGrids_J.NullText = ""
        Me.col_dgGrids_J.ReadOnly = True
        Me.col_dgGrids_J.Width = 0
        '
        'col_dgGrids_G
        '
        Me.col_dgGrids_G.Format = ""
        Me.col_dgGrids_G.FormatInfo = Nothing
        Me.col_dgGrids_G.HeaderText = "Generator"
        Me.col_dgGrids_G.MappingName = "GeneratorName"
        Me.col_dgGrids_G.NullText = ""
        Me.col_dgGrids_G.ReadOnly = True
        Me.col_dgGrids_G.Width = 150
        '
        'col_dgGrids_C
        '
        Me.col_dgGrids_C.Format = ""
        Me.col_dgGrids_C.FormatInfo = Nothing
        Me.col_dgGrids_C.HeaderText = "City"
        Me.col_dgGrids_C.MappingName = "JobSiteCity"
        Me.col_dgGrids_C.NullText = ""
        Me.col_dgGrids_C.ReadOnly = True
        Me.col_dgGrids_C.Width = 80
        '
        'col_dgGrids_P
        '
        Me.col_dgGrids_P.Format = ""
        Me.col_dgGrids_P.FormatInfo = Nothing
        Me.col_dgGrids_P.HeaderText = "Product"
        Me.col_dgGrids_P.MappingName = "ProductName"
        Me.col_dgGrids_P.NullText = ""
        Me.col_dgGrids_P.ReadOnly = True
        Me.col_dgGrids_P.Width = 115
        '
        'col_dgGrids_SI
        '
        Me.col_dgGrids_SI.Format = ""
        Me.col_dgGrids_SI.FormatInfo = Nothing
        Me.col_dgGrids_SI.HeaderText = "Special Instructions"
        Me.col_dgGrids_SI.MappingName = "SpecialInstructions"
        Me.col_dgGrids_SI.NullText = ""
        Me.col_dgGrids_SI.Width = 150
        '
        'col_dgGrids_ST
        '
        Me.col_dgGrids_ST.Format = ""
        Me.col_dgGrids_ST.FormatInfo = Nothing
        Me.col_dgGrids_ST.HeaderText = "Sch. Time"
        Me.col_dgGrids_ST.MappingName = "ScheduledTime"
        Me.col_dgGrids_ST.NullText = ""
        Me.col_dgGrids_ST.Width = 70
        '
        'col_dgGrids_D
        '
        Me.col_dgGrids_D.Format = ""
        Me.col_dgGrids_D.FormatInfo = Nothing
        Me.col_dgGrids_D.HeaderText = "Driver"
        Me.col_dgGrids_D.MappingName = "DriverName"
        Me.col_dgGrids_D.NullText = ""
        Me.col_dgGrids_D.Width = 85
        '
        'col_dgGrids_Drums
        '
        Me.col_dgGrids_Drums.AllowNull = False
        Me.col_dgGrids_Drums.FalseValue = False
        Me.col_dgGrids_Drums.HeaderText = "Drums"
        Me.col_dgGrids_Drums.MappingName = "Drums"
        Me.col_dgGrids_Drums.NullText = ""
        Me.col_dgGrids_Drums.NullValue = "False"
        Me.col_dgGrids_Drums.ReadOnly = True
        Me.col_dgGrids_Drums.TrueValue = True
        Me.col_dgGrids_Drums.Width = 50
        '
        'col_dgGrids_TT
        '
        Me.col_dgGrids_TT.Format = ""
        Me.col_dgGrids_TT.FormatInfo = Nothing
        Me.col_dgGrids_TT.HeaderText = "Type of Truck"
        Me.col_dgGrids_TT.MappingName = "TypeOfTruck"
        Me.col_dgGrids_TT.NullText = ""
        Me.col_dgGrids_TT.ReadOnly = True
        Me.col_dgGrids_TT.Width = 95
        '
        'col_dgGrids_SD
        '
        Me.col_dgGrids_SD.Format = "d"
        Me.col_dgGrids_SD.FormatInfo = Nothing
        Me.col_dgGrids_SD.HeaderText = "Sch. Date"
        Me.col_dgGrids_SD.MappingName = "ScheduleDate"
        Me.col_dgGrids_SD.NullText = ""
        Me.col_dgGrids_SD.Width = 110
        '
        'col_dgGrids_JD
        '
        Me.col_dgGrids_JD.AllowNull = False
        Me.col_dgGrids_JD.FalseValue = False
        Me.col_dgGrids_JD.HeaderText = "Done?"
        Me.col_dgGrids_JD.MappingName = "JobDone"
        Me.col_dgGrids_JD.NullText = ""
        Me.col_dgGrids_JD.NullValue = "False"
        Me.col_dgGrids_JD.TrueValue = True
        Me.col_dgGrids_JD.Width = 50
        '
        'col_Cancell
        '
        Me.col_Cancell.AllowNull = False
        Me.col_Cancell.FalseValue = False
        Me.col_Cancell.HeaderText = "Cancel ?"
        Me.col_Cancell.MappingName = "IsCancelled"
        Me.col_Cancell.NullText = ""
        Me.col_Cancell.NullValue = "False"
        Me.col_Cancell.TrueValue = True
        Me.col_Cancell.Width = 60
        '
        'col_dgGrids_SI_J
        '
        Me.col_dgGrids_SI_J.Format = ""
        Me.col_dgGrids_SI_J.FormatInfo = Nothing
        Me.col_dgGrids_SI_J.HeaderText = "Job Ticket Instructions"
        Me.col_dgGrids_SI_J.MappingName = "SpecialInstructions_T"
        Me.col_dgGrids_SI_J.NullText = ""
        Me.col_dgGrids_SI_J.Width = 0
        '
        'btnMonday
        '
        Me.btnMonday.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMonday.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMonday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonday.Location = New System.Drawing.Point(0, 648)
        Me.btnMonday.Name = "btnMonday"
        Me.btnMonday.Size = New System.Drawing.Size(145, 24)
        Me.btnMonday.TabIndex = 8
        Me.btnMonday.Text = "Monday"
        '
        'btnTuesday
        '
        Me.btnTuesday.BackColor = System.Drawing.Color.SlateGray
        Me.btnTuesday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTuesday.Location = New System.Drawing.Point(146, 648)
        Me.btnTuesday.Name = "btnTuesday"
        Me.btnTuesday.Size = New System.Drawing.Size(145, 24)
        Me.btnTuesday.TabIndex = 9
        Me.btnTuesday.Text = "Tuesday"
        '
        'btnWednesday
        '
        Me.btnWednesday.BackColor = System.Drawing.Color.SlateGray
        Me.btnWednesday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWednesday.Location = New System.Drawing.Point(290, 648)
        Me.btnWednesday.Name = "btnWednesday"
        Me.btnWednesday.Size = New System.Drawing.Size(145, 24)
        Me.btnWednesday.TabIndex = 10
        Me.btnWednesday.Text = "Wednesday"
        '
        'btnThursday
        '
        Me.btnThursday.BackColor = System.Drawing.Color.SlateGray
        Me.btnThursday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThursday.Location = New System.Drawing.Point(434, 648)
        Me.btnThursday.Name = "btnThursday"
        Me.btnThursday.Size = New System.Drawing.Size(145, 24)
        Me.btnThursday.TabIndex = 11
        Me.btnThursday.Text = "Thursday"
        '
        'btnFriday
        '
        Me.btnFriday.BackColor = System.Drawing.Color.SlateGray
        Me.btnFriday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriday.Location = New System.Drawing.Point(578, 648)
        Me.btnFriday.Name = "btnFriday"
        Me.btnFriday.Size = New System.Drawing.Size(145, 24)
        Me.btnFriday.TabIndex = 12
        Me.btnFriday.Text = "Friday"
        '
        'btnRecurring
        '
        Me.btnRecurring.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnRecurring.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecurring.ForeColor = System.Drawing.Color.White
        Me.btnRecurring.Location = New System.Drawing.Point(224, 8)
        Me.btnRecurring.Name = "btnRecurring"
        Me.btnRecurring.Size = New System.Drawing.Size(136, 24)
        Me.btnRecurring.TabIndex = 1
        Me.btnRecurring.Text = "Recurring Pickups"
        Me.btnRecurring.Visible = False
        '
        'DAJobBoard
        '
        Me.DAJobBoard.SelectCommand = Me.SelectJobBoard
        Me.DAJobBoard.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("DriverName", "DriverName"), New System.Data.Common.DataColumnMapping("ScheduleDate", "ScheduleDate"), New System.Data.Common.DataColumnMapping("SpecialInstructions", "SpecialInstructions"), New System.Data.Common.DataColumnMapping("ScheduledTime", "ScheduledTime"), New System.Data.Common.DataColumnMapping("TypeOfTruck", "TypeOfTruck"), New System.Data.Common.DataColumnMapping("Drums", "Drums"), New System.Data.Common.DataColumnMapping("JobDone", "JobDone"), New System.Data.Common.DataColumnMapping("SpecialInstructions_T", "SpecialInstructions_T")})})
        Me.DAJobBoard.UpdateCommand = Me.UpdateJobBoard
        '
        'SelectJobBoard
        '
        Me.SelectJobBoard.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGene" & _
        "rators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTic" & _
        "kets.ScheduleDate, tblJobTickets.SpecialInstructions, tblJobTickets.ScheduledTim" & _
        "e, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.Drums, tblJobTickets.JobDone AS Jo" & _
        "bDone, tblJobTickets.SpecialInstructions_T, tblJobTickets.IsCancelled, tblJobTic" & _
        "kets.TransporterID, tblTransporters.TransporterName FROM ((tblTypeOfTrucks INNER" & _
        " JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblP" & _
        "roducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobT" & _
        "ickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID" & _
        ") INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.Tr" & _
        "ansporterID) WHERE (tblJobTickets.IsBeaver = TRUE)"
        Me.SelectJobBoard.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""\\beaverone\Data\Job Tracking Database\JobTrackingSys" & _
        "tem.mdb"";Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OL" & _
        "EDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=Fa" & _
        "lse;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLED" & _
        "B:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't " & _
        "Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'UpdateJobBoard
        '
        Me.UpdateJobBoard.CommandText = "UPDATE tblJobTickets SET ScheduleDate = ?, DriverName = ?, SpecialInstructions = " & _
        "?, SpecialInstructions_T = ?, ScheduledTime = ?, JobDone = ?, IsCancelled = ? WH" & _
        "ERE (JobTicketID = ?)"
        Me.UpdateJobBoard.Connection = Me.OleDbConnection1
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("ScheduleDate", System.Data.OleDb.OleDbType.DBDate, 0, "ScheduleDate"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, "DriverName"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecialInstructions", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecialInstructions"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecialInstructions_T", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecialInstructions_T"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("ScheduledTime", System.Data.OleDb.OleDbType.VarWChar, 50, "ScheduledTime"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobDone", System.Data.OleDb.OleDbType.Boolean, 2, "JobDone"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("IsCancelled", System.Data.OleDb.OleDbType.Boolean, 2, "IsCancelled"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobTicketID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DARecurringJobs
        '
        Me.DARecurringJobs.SelectCommand = Me.SelectRecurringJobs
        Me.DARecurringJobs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets_Recurring", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("IsCancelled", "IsCancelled"), New System.Data.Common.DataColumnMapping("JobStartDate", "JobStartDate"), New System.Data.Common.DataColumnMapping("WeekDay", "WeekDay")})})
        Me.DARecurringJobs.UpdateCommand = Me.UpdateRecurring
        '
        'SelectRecurringJobs
        '
        Me.SelectRecurringJobs.CommandText = "SELECT tblJobTickets_Recurring.JobTicketID, tblGenerators.JobSite, tblGenerators." & _
        "JobSiteCity, tblProducts.ProductName, tblJobTickets_Recurring.IsCancelled, tblJo" & _
        "bTickets_Recurring.JobStartDate, tblJobTickets_Recurring.WeekDay, tblJobTickets_" & _
        "Recurring.JobEndDate FROM ((tblGenerators INNER JOIN tblProducts ON tblGenerator" & _
        "s.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets_Recurring ON t" & _
        "blProducts.ProductID = tblJobTickets_Recurring.ProductID) WHERE (tblJobTickets_R" & _
        "ecurring.IsCancelled = False)"
        Me.SelectRecurringJobs.Connection = Me.OleDbConnection1
        '
        'UpdateRecurring
        '
        Me.UpdateRecurring.CommandText = "UPDATE tblJobTickets_Recurring SET WeekDay = ?, IsCancelled = ? WHERE (JobTicketI" & _
        "D = ?)"
        Me.UpdateRecurring.Connection = Me.OleDbConnection1
        Me.UpdateRecurring.Parameters.Add(New System.Data.OleDb.OleDbParameter("WeekDay", System.Data.OleDb.OleDbType.VarWChar, 10, "WeekDay"))
        Me.UpdateRecurring.Parameters.Add(New System.Data.OleDb.OleDbParameter("IsCancelled", System.Data.OleDb.OleDbType.Boolean, 2, "IsCancelled"))
        Me.UpdateRecurring.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobTicketID", System.Data.DataRowVersion.Original, Nothing))
        '
        'cmbWhatWeek
        '
        Me.cmbWhatWeek.Items.AddRange(New Object() {"Current Week", "Past Week", "Next Week", "2 Weeks Later", "3 Weeks Later", "4 Weeks Later"})
        Me.cmbWhatWeek.Location = New System.Drawing.Point(96, 8)
        Me.cmbWhatWeek.Name = "cmbWhatWeek"
        Me.cmbWhatWeek.Size = New System.Drawing.Size(120, 21)
        Me.cmbWhatWeek.TabIndex = 0
        Me.cmbWhatWeek.Text = "Current Week"
        '
        'lblWhichWeek
        '
        Me.lblWhichWeek.Location = New System.Drawing.Point(8, 12)
        Me.lblWhichWeek.Name = "lblWhichWeek"
        Me.lblWhichWeek.Size = New System.Drawing.Size(80, 16)
        Me.lblWhichWeek.TabIndex = 10
        Me.lblWhichWeek.Text = "Pick a Week:"
        '
        'btnHauler
        '
        Me.btnHauler.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnHauler.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHauler.ForeColor = System.Drawing.Color.White
        Me.btnHauler.Location = New System.Drawing.Point(360, 8)
        Me.btnHauler.Name = "btnHauler"
        Me.btnHauler.Size = New System.Drawing.Size(128, 24)
        Me.btnHauler.TabIndex = 2
        Me.btnHauler.Text = "Outside Haulers"
        Me.btnHauler.Visible = False
        '
        'btnMultiStop
        '
        Me.btnMultiStop.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnMultiStop.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiStop.ForeColor = System.Drawing.Color.White
        Me.btnMultiStop.Location = New System.Drawing.Point(488, 8)
        Me.btnMultiStop.Name = "btnMultiStop"
        Me.btnMultiStop.Size = New System.Drawing.Size(128, 24)
        Me.btnMultiStop.TabIndex = 3
        Me.btnMultiStop.Text = "Multi-Stop"
        Me.btnMultiStop.Visible = False
        '
        'btnSaturday
        '
        Me.btnSaturday.BackColor = System.Drawing.Color.SlateGray
        Me.btnSaturday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaturday.Location = New System.Drawing.Point(722, 648)
        Me.btnSaturday.Name = "btnSaturday"
        Me.btnSaturday.Size = New System.Drawing.Size(145, 24)
        Me.btnSaturday.TabIndex = 13
        Me.btnSaturday.Text = "Saturday"
        '
        'btnSunday
        '
        Me.btnSunday.BackColor = System.Drawing.Color.SlateGray
        Me.btnSunday.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSunday.Location = New System.Drawing.Point(866, 648)
        Me.btnSunday.Name = "btnSunday"
        Me.btnSunday.Size = New System.Drawing.Size(145, 24)
        Me.btnSunday.TabIndex = 14
        Me.btnSunday.Text = "Sunday"
        '
        'DAMultiStops
        '
        Me.DAMultiStops.SelectCommand = Me.SelectMultiStop
        Me.DAMultiStops.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("DriverName", "DriverName"), New System.Data.Common.DataColumnMapping("ScheduleDate", "ScheduleDate"), New System.Data.Common.DataColumnMapping("TypeOfTruck", "TypeOfTruck"), New System.Data.Common.DataColumnMapping("JobDone", "JobDone"), New System.Data.Common.DataColumnMapping("Drums", "Drums")})})
        Me.DAMultiStops.UpdateCommand = Me.OleDbCommand5
        '
        'SelectMultiStop
        '
        Me.SelectMultiStop.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGene" & _
        "rators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTic" & _
        "kets.ScheduleDate, tblJobTickets.JobDone, tblJobTickets.Drums, tblJobTickets.Spe" & _
        "cialInstructions FROM (tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tbl" & _
        "Products ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJ" & _
        "obTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks" & _
        ".TypeOfTruckID = tblJobTickets.TypeOfTruckID) WHERE (tblJobTickets.IsMultiStop =" & _
        " True)"
        Me.SelectMultiStop.Connection = Me.OleDbConnection1
        '
        'OleDbCommand5
        '
        Me.OleDbCommand5.CommandText = "UPDATE tblJobTickets SET ScheduleDate = ?, DriverName = ?, JobDone = ?, SpecialIn" & _
        "structions = ? WHERE (JobTicketID = ?)"
        Me.OleDbCommand5.Connection = Me.OleDbConnection1
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ScheduleDate", System.Data.OleDb.OleDbType.DBDate, 0, "ScheduleDate"))
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, "DriverName"))
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobDone", System.Data.OleDb.OleDbType.Boolean, 2, "JobDone"))
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecialInstructions", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecialInstructions"))
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobTicketID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAOutsideHaulers
        '
        Me.DAOutsideHaulers.SelectCommand = Me.SelectOutsideHaulers
        Me.DAOutsideHaulers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("DriverName", "DriverName"), New System.Data.Common.DataColumnMapping("ScheduleDate", "ScheduleDate"), New System.Data.Common.DataColumnMapping("TypeOfTruck", "TypeOfTruck"), New System.Data.Common.DataColumnMapping("JobDone", "JobDone"), New System.Data.Common.DataColumnMapping("Hauler", "Hauler"), New System.Data.Common.DataColumnMapping("Drums", "Drums")})})
        Me.DAOutsideHaulers.UpdateCommand = Me.Upd_O_H
        '
        'SelectOutsideHaulers
        '
        Me.SelectOutsideHaulers.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGene" & _
        "rators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTic" & _
        "kets.ScheduleDate, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.JobDone, tblDispos" & _
        "alFacilities.DisposalFacilityName AS Hauler, tblJobTickets.Drums, tblGenerators." & _
        "GeneratorName AS CustomerName, tblTransporters.TransporterName AS TransporterNam" & _
        "e FROM (((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON t" & _
        "blGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON " & _
        "tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckI" & _
        "D = tblJobTickets.TypeOfTruckID) INNER JOIN tblDisposalFacilities ON tblJobTicke" & _
        "ts.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) INNER JOIN tbl" & _
        "Transporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHE" & _
        "RE (tblJobTickets.IsOutsideHauler = True)"
        Me.SelectOutsideHaulers.Connection = Me.OleDbConnection1
        '
        'Upd_O_H
        '
        Me.Upd_O_H.CommandText = "UPDATE tblJobTickets SET ScheduleDate = ?, JobDone = ? WHERE (JobTicketID = ?)"
        Me.Upd_O_H.Connection = Me.OleDbConnection1
        Me.Upd_O_H.Parameters.Add(New System.Data.OleDb.OleDbParameter("ScheduleDate", System.Data.OleDb.OleDbType.DBDate, 0, "ScheduleDate"))
        Me.Upd_O_H.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobDone", System.Data.OleDb.OleDbType.Boolean, 2, "JobDone"))
        Me.Upd_O_H.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobTicketID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "JobTicketID"
        Me.DataGridTextBoxColumn1.MappingName = "JobTicketID"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DGOutsideHaulers
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "JobTicket"
        Me.DataGridTextBoxColumn2.MappingName = "JobTicketID"
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(616, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Print Job Board"
        Me.Button1.Visible = False
        '
        'btnPrintOutside
        '
        Me.btnPrintOutside.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPrintOutside.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOutside.ForeColor = System.Drawing.Color.White
        Me.btnPrintOutside.Location = New System.Drawing.Point(728, 8)
        Me.btnPrintOutside.Name = "btnPrintOutside"
        Me.btnPrintOutside.Size = New System.Drawing.Size(132, 24)
        Me.btnPrintOutside.TabIndex = 18
        Me.btnPrintOutside.Text = "Print Outside Haulers"
        Me.btnPrintOutside.Visible = False
        '
        'btnPrintMultiStop
        '
        Me.btnPrintMultiStop.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPrintMultiStop.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintMultiStop.ForeColor = System.Drawing.Color.White
        Me.btnPrintMultiStop.Location = New System.Drawing.Point(860, 8)
        Me.btnPrintMultiStop.Name = "btnPrintMultiStop"
        Me.btnPrintMultiStop.Size = New System.Drawing.Size(132, 24)
        Me.btnPrintMultiStop.TabIndex = 19
        Me.btnPrintMultiStop.Text = "Print Multi-Stop"
        Me.btnPrintMultiStop.Visible = False
        '
        'frmJobBoard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 724)
        Me.Controls.Add(Me.btnPrintMultiStop)
        Me.Controls.Add(Me.btnPrintOutside)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSunday)
        Me.Controls.Add(Me.btnSaturday)
        Me.Controls.Add(Me.btnMultiStop)
        Me.Controls.Add(Me.btnHauler)
        Me.Controls.Add(Me.lblWhichWeek)
        Me.Controls.Add(Me.cmbWhatWeek)
        Me.Controls.Add(Me.btnRecurring)
        Me.Controls.Add(Me.btnFriday)
        Me.Controls.Add(Me.btnThursday)
        Me.Controls.Add(Me.btnWednesday)
        Me.Controls.Add(Me.btnTuesday)
        Me.Controls.Add(Me.btnMonday)
        Me.Controls.Add(Me.DGOutsideHaulers)
        Me.Controls.Add(Me.dgRecurringJobs)
        Me.Controls.Add(Me.dgJobBoard)
        Me.Controls.Add(Me.DGMultiStops)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmJobBoard"
        Me.Text = "JOB BOARD"
        CType(Me.DGOutsideHaulers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsOutsideHaulers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMultiStops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMultiStops1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRecurringJobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRecurringJobs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgJobBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsJobBoard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmJobBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        'Me.Initialize()

    End Sub

    Function Initialize()

        'update Week Dates
        updateWeekDates()
        'Intialize buttons
        updateBackButtons(thisDate.DayOfWeek)

    End Function

    Private Sub btnMonday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonday.Click
        'updateBackButtons(1)
    End Sub

    Private Sub btnTuesday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTuesday.Click
        updateBackButtons(2)
    End Sub

    Private Sub btnWednesday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWednesday.Click
        updateBackButtons(3)
    End Sub

    Private Sub btnThursday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThursday.Click
        updateBackButtons(4)
    End Sub

    Private Sub btnFriday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFriday.Click
        updateBackButtons(5)
    End Sub

    Private Sub btnSaturday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaturday.Click
        updateBackButtons(6)
    End Sub

    Private Sub btnSunday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSunday.Click
        updateBackButtons(7)
    End Sub

    Private Sub btnRecurring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurring.Click
        updateBackButtons(8)
    End Sub

    Private Sub btnHauler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHauler.Click
        updateBackButtons(9)
    End Sub

    Private Sub btnMultiStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiStop.Click
        updateBackButtons(10)
    End Sub

    'Function to generate Back Color of buttons
    Function updateBackButtons(ByVal whatBtn As Integer)
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.DsJobBoard1.Tables(0).Rows.Count > 0 Then
                If Me.DsJobBoard1.HasChanges = True Then
                    Me.DAJobBoard.Update(Me.DsJobBoard1)
                End If
            End If
            If Me.DsRecurringJobs1.Tables(0).Rows.Count > 0 Then
                If Me.DsRecurringJobs1.HasChanges = True Then
                    Me.DARecurringJobs.Update(Me.DsRecurringJobs1)
                End If
            End If
            If Me.DsMultiStops1.Tables(0).Rows.Count > 0 Then
                If Me.DsMultiStops1.HasChanges = True Then
                    Me.DAMultiStops.Update(Me.DsMultiStops1)
                End If
            End If
            If Me.DsOutsideHaulers1.Tables(0).Rows.Count > 0 Then
                If Me.DsOutsideHaulers1.HasChanges = True Then
                    Me.DAOutsideHaulers.Update(Me.DsOutsideHaulers1)
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            Me.btnMonday.BackColor = IIf(whatBtn = 1, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnMonday.FlatStyle = IIf(whatBtn = 1, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnTuesday.BackColor = IIf(whatBtn = 2, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnTuesday.FlatStyle = IIf(whatBtn = 2, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnWednesday.BackColor = IIf(whatBtn = 3, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnWednesday.FlatStyle = IIf(whatBtn = 3, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnThursday.BackColor = IIf(whatBtn = 4, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnThursday.FlatStyle = IIf(whatBtn = 4, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnFriday.BackColor = IIf(whatBtn = 5, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnFriday.FlatStyle = IIf(whatBtn = 5, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnSaturday.BackColor = IIf(whatBtn = 6, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnSaturday.FlatStyle = IIf(whatBtn = 6, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnSunday.BackColor = IIf(whatBtn = 7, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnSunday.FlatStyle = IIf(whatBtn = 7, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnRecurring.BackColor = IIf(whatBtn = 8, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnRecurring.FlatStyle = IIf(whatBtn = 8, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnHauler.BackColor = IIf(whatBtn = 9, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnHauler.FlatStyle = IIf(whatBtn = 9, FlatStyle.Popup, FlatStyle.Standard)
            Me.btnMultiStop.BackColor = IIf(whatBtn = 10, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SlateGray)
            Me.btnMultiStop.FlatStyle = IIf(whatBtn = 10, FlatStyle.Popup, FlatStyle.Standard)
            Me.populateDatagrid(whatBtn)
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function updateWeekDates()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        monDate = DateAdd(DateInterval.Day, 1 - thisDate.DayOfWeek, thisDate)
        tueDate = DateAdd(DateInterval.Day, 1, monDate)
        wedDate = DateAdd(DateInterval.Day, 2, monDate)
        thuDate = DateAdd(DateInterval.Day, 3, monDate)
        friDate = DateAdd(DateInterval.Day, 4, monDate)
        satDate = DateAdd(DateInterval.Day, 5, monDate)
        sunDate = DateAdd(DateInterval.Day, 6, monDate)
        Me.btnMonday.Text = "Mon-" & Me.monDate.Month & "/" & Me.monDate.Day & "/" & Mid(Me.monDate.Year, 3)
        Me.btnTuesday.Text = "Tue-" & Me.tueDate.Month & "/" & Me.tueDate.Day & "/" & Mid(Me.tueDate.Year, 3)
        Me.btnWednesday.Text = "Wed-" & Me.wedDate.Month & "/" & Me.wedDate.Day & "/" & Mid(Me.wedDate.Year, 3)
        Me.btnThursday.Text = "Thu-" & Me.thuDate.Month & "/" & Me.thuDate.Day & "/" & Mid(Me.thuDate.Year, 3)
        Me.btnFriday.Text = "Fri-" & Me.friDate.Month & "/" & Me.friDate.Day & "/" & Mid(Me.friDate.Year, 3)
        Me.btnSaturday.Text = "Sat-" & Me.satDate.Month & "/" & Me.satDate.Day & "/" & Mid(Me.satDate.Year, 3)
        Me.btnSunday.Text = "Sun-" & Me.sunDate.Month & "/" & Me.sunDate.Day & "/" & Mid(Me.sunDate.Year, 3)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function populateDatagrid(ByVal whatBtn As Integer)
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim curDate As Date = IIf(whatBtn = 1, monDate, IIf(whatBtn = 2, tueDate, IIf(whatBtn = 3, wedDate, IIf(whatBtn = 4, thuDate, IIf(whatBtn = 5, friDate, IIf(whatBtn = 6, satDate, IIf(whatBtn = 7, sunDate, thisDate)))))))
        Try
            If whatBtn <= 7 Then
                Me.Bind_Daily(curDate)
            ElseIf whatBtn = 8 Then
                Me.BindRecurringJobs()
            ElseIf whatBtn = 9 Then
                Me.Bind_OutsideHaulers()
            ElseIf whatBtn = 10 Then
                Me.Bind_Multistops()
            End If
            Me.DatagridHideUnHide(whatBtn)
            'End
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Function

    Function Bind_Daily(ByVal curDate As Date)
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim aConn As OleDb.OleDbConnection = Nothing

        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectJobBoard.Connection = aConn
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Me.SelectJobBoard.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblJobTickets.SpecialInstructions, tblJobTickets.ScheduledTime, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.Drums, tblJobTickets.JobDone AS JobDone,tblJobTickets.IsCancelled AS IsCancelled, tblJobTickets.SpecialInstructions_T, tblJobTickets.TransporterID, tblTransporters.TransporterName FROM ((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHERE (tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "#) AND (tblJobTickets.IsBeaver = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblTypeOfTrucks.DisplayOrder, tblJobTickets.JobTicketID"
            Me.SelectJobBoard.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblJobTickets.SpecialInstructions, tblJobTickets.ScheduledTime, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.Drums, tblJobTickets.JobDone AS JobDone,tblJobTickets.IsCancelled AS IsCancelled, tblJobTickets.SpecialInstructions_T, tblJobTickets.TransporterID, tblTransporters.TransporterName FROM ((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHERE (tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "#) AND (tblJobTickets.IsBeaver = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblTypeOfTrucks.DisplayOrder, tblJobTickets.JobTicketID"

            Me.DsJobBoard1.Clear()
            Me.DAJobBoard.Fill(Me.DsJobBoard1, "tblJobTickets")
            Me.dsrptJobBoard = Me.DsJobBoard1.Copy
            rCount = Me.DsJobBoard1.Tables(0).Rows.Count
            Me.dgJobBoard.DataSource = Me.DsJobBoard1
            Me.dgJobBoard.DataMember = "tblJobTickets"
            Me.dgJobBoard.Refresh()
            '#ReadOnly
            If rCount = 0 Then
                Me.dgJobBoard.ReadOnly = True
            Else
                Me.dgJobBoard.ReadOnly = False
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function Bind_Multistops()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim aConn As OleDb.OleDbConnection = Nothing

        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectMultiStop.Connection = aConn
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Me.SelectMultiStop.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblJobTickets.JobDone, tblJobTickets.Drums,tblJobTickets.SpecialInstructions FROM (tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) WHERE (tblJobTickets.IsMultiStop = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.ScheduleDate ASC"
            Me.SelectMultiStop.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblJobTickets.JobDone, tblJobTickets.Drums,tblJobTickets.SpecialInstructions FROM (tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) WHERE (tblJobTickets.IsMultiStop = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.ScheduleDate ASC"
            Me.DsMultiStops1.Clear()
            Me.DAMultiStops.Fill(Me.DsMultiStops1, "tblJobTickets")
            rCount = Me.DsMultiStops1.Tables(0).Rows.Count
            Me.DGMultiStops.DataSource = Me.DsMultiStops1
            Me.DGMultiStops.DataMember = "tblJobTickets"
            Me.DGMultiStops.Refresh()
            '#ReadOnly
            If rCount = 0 Then
                Me.DGMultiStops.ReadOnly = True
            Else
                Me.DGMultiStops.ReadOnly = False
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function Bind_OutsideHaulers()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim aConn As OleDb.OleDbConnection = Nothing
        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectOutsideHaulers.Connection = aConn
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Me.SelectOutsideHaulers.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.JobDone, tblDisposalFacilities.DisposalFacilityName AS Hauler, tblJobTickets.Drums,tblGenerators.GeneratorName as CustomerName,tblTransporters.TransporterName AS TransporterName FROM (((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) INNER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHERE (tblJobTickets.IsOutsideHauler = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.ScheduleDate ASC"
            Me.SelectOutsideHaulers.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.JobDone, tblDisposalFacilities.DisposalFacilityName AS Hauler, tblJobTickets.Drums,tblGenerators.GeneratorName as CustomerName,tblTransporters.TransporterName AS TransporterName FROM (((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) INNER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHERE (tblJobTickets.IsOutsideHauler = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.ScheduleDate ASC"

            Me.DsOutsideHaulers1.Clear()
            Me.DAOutsideHaulers.Fill(Me.DsOutsideHaulers1, "tblJobTickets")
            rCount = Me.DsOutsideHaulers1.Tables(0).Rows.Count
            Me.DGOutsideHaulers.DataSource = Me.DsOutsideHaulers1
            Me.DGOutsideHaulers.DataMember = "tblJobTickets"
            Me.DGOutsideHaulers.Refresh()
            '#ReadOnly
            If rCount = 0 Then
                Me.DGOutsideHaulers.ReadOnly = True
            Else
                Me.DGOutsideHaulers.ReadOnly = False
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function BindRecurringJobs()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim aConn As OleDb.OleDbConnection = Nothing
        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectRecurringJobs.Connection = aConn
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Me.SelectRecurringJobs.CommandText = "SELECT tblJobTickets_Recurring.JobTicketID, tblGenerators.JobSite, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets_Recurring.IsCancelled, tblJobTickets_Recurring.JobStartDate,tblJobTickets_Recurring.JobEndDate, tblJobTickets_Recurring.WeekDay FROM ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets_Recurring ON tblProducts.ProductID = tblJobTickets_Recurring.ProductID) WHERE (tblJobTickets_Recurring.IsCancelled = False) ORDER BY JobTicketID"
            Me.SelectRecurringJobs.CommandText = "SELECT tblJobTickets_Recurring.JobTicketID, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets_Recurring.IsCancelled, tblJobTickets_Recurring.JobStartDate,tblJobTickets_Recurring.JobEndDate, tblJobTickets_Recurring.WeekDay FROM ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets_Recurring ON tblProducts.ProductID = tblJobTickets_Recurring.ProductID) WHERE (tblJobTickets_Recurring.IsCancelled = False) ORDER BY JobTicketID"
            Me.DsRecurringJobs1.Clear()
            Me.DARecurringJobs.Fill(Me.DsRecurringJobs1, "tblJobTickets_Recurring")
            rCount = Me.DsRecurringJobs1.Tables(0).Rows.Count
            Me.dgRecurringJobs.DataSource = Me.DsRecurringJobs1
            Me.dgRecurringJobs.DataMember = "tblJobTickets_Recurring"
            Me.dgRecurringJobs.Refresh()
            '#ReadOnly
            If rCount = 0 Then
                Me.dgRecurringJobs.ReadOnly = True
            Else
                Me.dgRecurringJobs.ReadOnly = False
            End If
            Me.dgRecurringJobs.Visible = True
            Me.dgJobBoard.Visible = False

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub frmJobBoard_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If Me.DsJobBoard1.Tables(0).Rows.Count > 0 Then
            If Me.DsJobBoard1.HasChanges = True Then
                Me.DAJobBoard.Update(Me.DsJobBoard1)
            End If
        End If
        If Me.DsRecurringJobs1.Tables(0).Rows.Count > 0 Then
            If Me.DsRecurringJobs1.HasChanges = True Then
                Me.DARecurringJobs.Update(Me.DsRecurringJobs1)
            End If
        End If
        If Me.DsMultiStops1.Tables(0).Rows.Count > 0 Then
            If Me.DsMultiStops1.HasChanges = True Then
                Me.DARecurringJobs.Update(Me.DsMultiStops1)
            End If
        End If
        If Me.DsOutsideHaulers1.Tables(0).Rows.Count > 0 Then
            If Me.DsOutsideHaulers1.HasChanges = True Then
                Me.DAOutsideHaulers.Update(Me.DsOutsideHaulers1)
            End If
        End If

    End Sub

    Public Shared Function GetNewDataGridTextBoxColumn(ByVal MappingName As String) As DataGridTextBoxColumn

        Dim TextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn
        With TextBoxColumn
            .MappingName = MappingName
            .HeaderText = MappingName
            .ReadOnly = False
            .Width = 200
        End With
        Return TextBoxColumn

    End Function

    Private Sub dgJobBoard_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgJobBoard.CurrentCellChanged
        Try
            If Me.dgJobBoard.CurrentCell.RowNumber < rCount Then
                Select Case Me.dgJobBoard.CurrentCell.ColumnNumber ' Select the column that u want to make as read only
                    Case 0
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(0).ReadOnly = True
                    Case 1
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(1).ReadOnly = True
                    Case 2
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(2).ReadOnly = True
                    Case 3
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(3).ReadOnly = False
                    Case 4
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(4).ReadOnly = False
                End Select
            Else
                Select Case Me.dgJobBoard.CurrentCell.ColumnNumber ' Select the column that u want to make as read only
                    Case 0
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(0).ReadOnly = True
                    Case 1
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(1).ReadOnly = True
                    Case 2
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(2).ReadOnly = True
                    Case 3
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(3).ReadOnly = True
                    Case 4
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(4).ReadOnly = True
                End Select

            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DGMultiStops_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGMultiStops.CurrentCellChanged
        Try
            If Me.DGMultiStops.CurrentCell.RowNumber < rCount Then
                Select Case Me.DGMultiStops.CurrentCell.ColumnNumber ' Select the column that u want to make as read only
                    Case 0
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(0).ReadOnly = True
                    Case 1
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(1).ReadOnly = True
                    Case 2
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(2).ReadOnly = True
                    Case 3
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(3).ReadOnly = False
                    Case 4
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(4).ReadOnly = False
                End Select
            Else
                Select Case Me.DGMultiStops.CurrentCell.ColumnNumber ' Select the column that u want to make as read only
                    Case 0
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(0).ReadOnly = True
                    Case 1
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(1).ReadOnly = True
                    Case 2
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(2).ReadOnly = True
                    Case 3
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(3).ReadOnly = True
                    Case 4
                        DGMultiStops.TableStyles.Item(0).GridColumnStyles.Item(4).ReadOnly = True
                End Select

            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DGOutsideHaulers_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGOutsideHaulers.CurrentCellChanged
        Try
            If Me.DGOutsideHaulers.CurrentCell.RowNumber < rCount Then
                If Me.DGOutsideHaulers.CurrentCell.ColumnNumber = 4 Then
                    DGOutsideHaulers.TableStyles.Item(0).GridColumnStyles.Item(4).ReadOnly = False
                End If
            Else
                If Me.DGOutsideHaulers.CurrentCell.ColumnNumber = 4 Then
                    DGOutsideHaulers.TableStyles.Item(0).GridColumnStyles.Item(4).ReadOnly = True
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgRecurringJobs_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.dgRecurringJobs.CurrentCell.RowNumber < rCount Then
                dgRecurringJobs.TableStyles.Item(0).GridColumnStyles.Item(5).ReadOnly = False
                dgRecurringJobs.TableStyles.Item(0).GridColumnStyles.Item(6).ReadOnly = False
            Else
                dgRecurringJobs.TableStyles.Item(0).GridColumnStyles.Item(5).ReadOnly = True
                dgRecurringJobs.TableStyles.Item(0).GridColumnStyles.Item(6).ReadOnly = True
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbWhatWeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWhatWeek.SelectedIndexChanged

        If Me.cmbWhatWeek.Text = "" Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If Me.cmbWhatWeek.Text = "Current Week" Then
            thisDate = Me.curWeekMonDate
        ElseIf Me.cmbWhatWeek.Text = "Next Week" Then
            thisDate = DateAdd(DateInterval.Day, 7, Me.curWeekMonDate)
        ElseIf Me.cmbWhatWeek.Text = "2 Weeks Later" Then
            thisDate = DateAdd(DateInterval.Day, 14, Me.curWeekMonDate)
        ElseIf Me.cmbWhatWeek.Text = "3 Weeks Later" Then
            thisDate = DateAdd(DateInterval.Day, 21, Me.curWeekMonDate)
        ElseIf Me.cmbWhatWeek.Text = "4 Weeks Later" Then
            thisDate = DateAdd(DateInterval.Day, 28, Me.curWeekMonDate)
        Else
            thisDate = DateAdd(DateInterval.Day, -7, Me.curWeekMonDate)
        End If

        Me.Initialize()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Function DatagridHideUnHide(ByVal whatBtn As Integer)

        If whatBtn <= 7 Then
            Me.dgJobBoard.Visible = True
            Me.DGMultiStops.Visible = False
            Me.DGOutsideHaulers.Visible = False
            Me.dgRecurringJobs.Visible = False
        ElseIf whatBtn = 8 Then
            Me.dgRecurringJobs.Visible = True
            Me.dgJobBoard.Visible = False
            Me.DGMultiStops.Visible = False
            Me.DGOutsideHaulers.Visible = False
        ElseIf whatBtn = 9 Then
            Me.DGOutsideHaulers.Visible = True
            Me.dgRecurringJobs.Visible = False
            Me.DGMultiStops.Visible = False
            Me.dgJobBoard.Visible = False
        ElseIf whatBtn = 10 Then
            Me.DGMultiStops.Visible = True
            Me.dgRecurringJobs.Visible = False
            Me.DGOutsideHaulers.Visible = False
            Me.dgJobBoard.Visible = False
        End If

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Not Me.dsrptJobBoard Is Nothing Then
                Dim objR As New rptJobBoard
                objR.SetDataSource(Me.dsrptJobBoard)
                DBHelper.Authenticate(objR)
                Dim frmR As New frmReport
                frmR.Text = "Job Board"
                frmR.WindowState = FormWindowState.Maximized
                frmR.CrystalReportViewer1.ReportSource = objR
                frmR.CrystalReportViewer1.RefreshReport()
                frmR.ShowDialog(Me)
                frmR = Nothing
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnPrintOutside_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOutside.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim aConn As OleDb.OleDbConnection = Nothing
        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectOutsideHaulers.Connection = aConn
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Me.SelectOutsideHaulers.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.JobDone, tblDisposalFacilities.DisposalFacilityName AS Hauler, tblJobTickets.Drums,tblGenerators.GeneratorName as CustomerName,tblTransporters.TransporterName AS TransporterName FROM (((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) INNER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHERE (tblJobTickets.IsOutsideHauler = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.ScheduleDate DESC"
            Me.SelectOutsideHaulers.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblTypeOfTrucks.TypeOfTruck, tblJobTickets.JobDone, tblDisposalFacilities.DisposalFacilityName AS Hauler, tblJobTickets.Drums,tblGenerators.GeneratorName as CustomerName,tblTransporters.TransporterName AS TransporterName FROM (((tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) INNER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) WHERE (tblJobTickets.IsOutsideHauler = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.ScheduleDate DESC"

            Me.DsOutsideHaulers1.Clear()
            Me.DAOutsideHaulers.Fill(Me.DsOutsideHaulers1, "tblJobTickets")

            Dim objR As New rpt_OutsideHaulers
            objR.SetDataSource(Me.DsOutsideHaulers1)
            DBHelper.Authenticate(objR)
            Dim frmR As New frmReport
            frmR.Text = "Outside Haulers"
            frmR.WindowState = FormWindowState.Maximized
            frmR.CrystalReportViewer1.ReportSource = objR
            frmR.CrystalReportViewer1.RefreshReport()
            frmR.ShowDialog(Me)
            frmR = Nothing

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnPrintMultiStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintMultiStop.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim aConn As OleDb.OleDbConnection = Nothing
        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectMultiStop.Connection = aConn
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Me.SelectMultiStop.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.JobSite AS GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblJobTickets.JobDone, tblJobTickets.Drums,tblJobTickets.SpecialInstructions FROM (tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) WHERE (tblJobTickets.IsMultiStop = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.JobTicketID"
            Me.SelectMultiStop.CommandText = "SELECT tblJobTickets.JobTicketID, tblGenerators.GeneratorName, tblGenerators.JobSiteCity, tblProducts.ProductName, tblJobTickets.DriverName, tblJobTickets.ScheduleDate, tblJobTickets.JobDone, tblJobTickets.Drums,tblJobTickets.SpecialInstructions FROM (tblTypeOfTrucks INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblTypeOfTrucks.TypeOfTruckID = tblJobTickets.TypeOfTruckID) WHERE (tblJobTickets.IsMultiStop = True) AND (IsCancelled = False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.JobTicketID"
            Me.DsMultiStops1.Clear()
            Me.DAMultiStops.Fill(Me.DsMultiStops1, "tblJobTickets")
            Dim objR As New rptMultiStop
            objR.SetDataSource(Me.DsMultiStops1)
            DBHelper.Authenticate(objR)
            Dim frmR As New frmReport
            frmR.Text = "Multi-Stop"
            frmR.WindowState = FormWindowState.Maximized
            frmR.CrystalReportViewer1.ReportSource = objR
            frmR.CrystalReportViewer1.RefreshReport()
            frmR.ShowDialog(Me)
            frmR = Nothing

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

End Class
