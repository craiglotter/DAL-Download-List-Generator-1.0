Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim WithEvents File_Generator1 As File_Generator
    Public Delegate Sub FileGeneratorhHandler(ByVal Result As String)
    Public Delegate Sub FGProgresshHandler(ByVal Result As String)

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        File_Generator1 = New File_Generator
        AddHandler File_Generator1.FGComplete, AddressOf FileGeneratorHandler
        AddHandler File_Generator1.FGProgress, AddressOf FGProgressHandler
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents start_counter_numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents end_counter_numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents step_counter_numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents URL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Help_Panel As System.Windows.Forms.Panel
    Friend WithEvents About_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents String_Length As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.start_counter_numeric = New System.Windows.Forms.NumericUpDown
        Me.end_counter_numeric = New System.Windows.Forms.NumericUpDown
        Me.step_counter_numeric = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.URL = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Help_Panel = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.About_Panel = New System.Windows.Forms.Panel
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.String_Length = New System.Windows.Forms.NumericUpDown
        Me.Label30 = New System.Windows.Forms.Label
        CType(Me.start_counter_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.end_counter_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.step_counter_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Help_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.About_Panel.SuspendLayout()
        CType(Me.String_Length, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Wheat
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(200, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 18)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Generate File"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "dal"
        Me.SaveFileDialog1.Filter = "DAL files|*.dal|All files|*.*"
        Me.SaveFileDialog1.Title = "Save DAL file to..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 240)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(168, 18)
        Me.ProgressBar1.TabIndex = 10
        Me.ProgressBar1.Visible = False
        '
        'start_counter_numeric
        '
        Me.start_counter_numeric.BackColor = System.Drawing.Color.OldLace
        Me.start_counter_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.start_counter_numeric.Location = New System.Drawing.Point(88, 136)
        Me.start_counter_numeric.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.start_counter_numeric.Name = "start_counter_numeric"
        Me.start_counter_numeric.Size = New System.Drawing.Size(40, 20)
        Me.start_counter_numeric.TabIndex = 11
        Me.start_counter_numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'end_counter_numeric
        '
        Me.end_counter_numeric.BackColor = System.Drawing.Color.OldLace
        Me.end_counter_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.end_counter_numeric.Location = New System.Drawing.Point(130, 136)
        Me.end_counter_numeric.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.end_counter_numeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.end_counter_numeric.Name = "end_counter_numeric"
        Me.end_counter_numeric.Size = New System.Drawing.Size(40, 20)
        Me.end_counter_numeric.TabIndex = 12
        Me.end_counter_numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'step_counter_numeric
        '
        Me.step_counter_numeric.BackColor = System.Drawing.Color.OldLace
        Me.step_counter_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.step_counter_numeric.Location = New System.Drawing.Point(172, 136)
        Me.step_counter_numeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.step_counter_numeric.Name = "step_counter_numeric"
        Me.step_counter_numeric.Size = New System.Drawing.Size(40, 20)
        Me.step_counter_numeric.TabIndex = 13
        Me.step_counter_numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(86, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Start"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(128, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "End"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(170, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Step"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(24, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Counter:"
        '
        'URL
        '
        Me.URL.BackColor = System.Drawing.Color.OldLace
        Me.URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.URL.ForeColor = System.Drawing.Color.Black
        Me.URL.Location = New System.Drawing.Point(24, 192)
        Me.URL.Multiline = True
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(251, 40)
        Me.URL.TabIndex = 15
        Me.URL.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(425, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Exit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "URL:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 64)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "To generate a DAL download list, adjust the counter accordingly, enter a valid UR" & _
        "L into the URL textbox and click on the 'Generate File' button. Remember that th" & _
        "e '@' character is the delimiter character used in generating a file series and " & _
        "';' is the delimiter for multiple URLs."
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(352, 24)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "DAL Download List Generator 1.0 "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(425, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Help"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(425, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "About"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Help_Panel
        '
        Me.Help_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Help_Panel.BackgroundImage = CType(resources.GetObject("Help_Panel.BackgroundImage"), System.Drawing.Image)
        Me.Help_Panel.Controls.Add(Me.Label12)
        Me.Help_Panel.Controls.Add(Me.Panel1)
        Me.Help_Panel.Controls.Add(Me.Panel2)
        Me.Help_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Help_Panel.Name = "Help_Panel"
        Me.Help_Panel.Size = New System.Drawing.Size(1, 1)
        Me.Help_Panel.TabIndex = 33
        Me.Help_Panel.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(24, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(352, 24)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "DAL Download List Generator 1.0 "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(16, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 256)
        Me.Panel1.TabIndex = 33
        Me.Panel1.Visible = False
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(4, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(408, 28)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "The string length variable allows you to adjust the string length of the counter " & _
        "by adding zeros to the front of the number."
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(352, 236)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 46
        Me.Label26.Text = "<< BACK"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 202)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(408, 48)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Once you have successfully set up your downloads, click on the ‘Generate File’ bu" & _
        "tton to begin the actual process. A save file dialog will appear, asking you to " & _
        "select the destination for the generated .dal list."
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(270, 132)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(140, 20)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "http://www.images.com/3.jpg;"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(138, 132)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 20)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "http://www.images.com/2.jpg;"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(344, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "(Page 2/2)"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(4, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(408, 40)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "To add multiple URLS for download, simply delimit them using the ‘;’ character. F" & _
        "or example, http://www.images.com/@.jpg; http://www.images.com/file@.bmp will re" & _
        "sult in 10 files being made available for download."
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(4, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 20)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "http://www.images.com/1.jpg;"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(4, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(412, 56)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "The second step is the input of the actual download URL. The delimiter character " & _
        "used to input the counter variable for a series download is ‘@’. In other words," & _
        " inputting an URL such as http://www.images.com/@.jpg with the series listing ab" & _
        "ove will result in the following file download list:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(4, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 24)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Help "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(16, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 256)
        Me.Panel2.TabIndex = 43
        Me.Panel2.Visible = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(352, 236)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "NEXT >>"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(344, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "(Page 1/2)"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(4, 186)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(408, 56)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "To use the program is simple enough. There is a start, end and step counter contr" & _
        "ol which allows you to control the series numbering. Thus, a choice of a start v" & _
        "alue of 1 and an end value of 3 with a step value of 1 will result in a series l" & _
        "ooking like: 1,2,3."
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(4, 108)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(396, 72)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "For instance, an image gallery may host 15 files (in series) at the following add" & _
        "ress: http://www.images.com/1.jpg, http://www.images.com/2.jpg, etc... Now by se" & _
        "tting the counter variables correctly and inputting the URL in the correct forma" & _
        "t, we can generate a single .dal file for later use with DAP. This generated .da" & _
        "l file will then contain download information for all 15 images."
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(4, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(408, 56)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "The download manager program, Download Accelerator Plus (DAP), can load files for" & _
        " download from its custom formal .dal file. DAL Download List Generator 1.0 is a" & _
        " program for generating .dal lists, specifically suited towards the creation of " & _
        "file series downloads."
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(4, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 24)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Help "
        '
        'About_Panel
        '
        Me.About_Panel.BackColor = System.Drawing.Color.Transparent
        Me.About_Panel.BackgroundImage = CType(resources.GetObject("About_Panel.BackgroundImage"), System.Drawing.Image)
        Me.About_Panel.Controls.Add(Me.Label32)
        Me.About_Panel.Controls.Add(Me.Label33)
        Me.About_Panel.Controls.Add(Me.Label34)
        Me.About_Panel.Controls.Add(Me.Label35)
        Me.About_Panel.Controls.Add(Me.Label36)
        Me.About_Panel.Controls.Add(Me.Label37)
        Me.About_Panel.Controls.Add(Me.Label38)
        Me.About_Panel.Controls.Add(Me.Label39)
        Me.About_Panel.Controls.Add(Me.Label28)
        Me.About_Panel.Controls.Add(Me.Label29)
        Me.About_Panel.Location = New System.Drawing.Point(0, 0)
        Me.About_Panel.Name = "About_Panel"
        Me.About_Panel.Size = New System.Drawing.Size(500, 500)
        Me.About_Panel.TabIndex = 33
        Me.About_Panel.Visible = False
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(112, 104)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 16)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "1.0.5"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(112, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 48
        Me.Label33.Text = "Craig Lotter"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(40, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 16)
        Me.Label34.TabIndex = 47
        Me.Label34.Text = "Version:"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(40, 136)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 16)
        Me.Label35.TabIndex = 46
        Me.Label35.Text = "Developer:"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(40, 120)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 16)
        Me.Label36.TabIndex = 45
        Me.Label36.Text = "Created:"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(112, 120)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(104, 16)
        Me.Label37.TabIndex = 44
        Me.Label37.Text = "2004/11/15"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(40, 104)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 16)
        Me.Label38.TabIndex = 43
        Me.Label38.Text = "Build:"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(112, 88)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(216, 16)
        Me.Label39.TabIndex = 42
        Me.Label39.Text = "DAL Download List Generator 1.0"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(24, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(352, 24)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "DAL Download List Generator 1.0 "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(20, 54)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 24)
        Me.Label29.TabIndex = 41
        Me.Label29.Text = "About"
        '
        'String_Length
        '
        Me.String_Length.BackColor = System.Drawing.Color.OldLace
        Me.String_Length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.String_Length.Location = New System.Drawing.Point(224, 136)
        Me.String_Length.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.String_Length.Name = "String_Length"
        Me.String_Length.Size = New System.Drawing.Size(32, 20)
        Me.String_Length.TabIndex = 14
        Me.String_Length.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(222, 160)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "String Length"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(481, 302)
        Me.Controls.Add(Me.Help_Panel)
        Me.Controls.Add(Me.About_Panel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.step_counter_numeric)
        Me.Controls.Add(Me.end_counter_numeric)
        Me.Controls.Add(Me.start_counter_numeric)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.String_Length)
        Me.Controls.Add(Me.Label30)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(481, 302)
        Me.MinimumSize = New System.Drawing.Size(481, 302)
        Me.Name = "Form1"
        Me.Text = "DAL Download List Generator 1.0"
        CType(Me.start_counter_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.end_counter_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.step_counter_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Help_Panel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.About_Panel.ResumeLayout(False)
        CType(Me.String_Length, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If (m.Result.ToInt32 = HTCLIENT) Then
                    m.Result = IntPtr.op_Explicit(HTCAPTION)
                End If
                Exit Sub
        End Select

        MyBase.WndProc(m)
    End Sub

    Private Sub error_handler(ByVal message As String)
        Try
            If message.Length > 0 Then
                MsgBox("Sorry, but DAL Download List Generator 1.0 has trapped the following error: " & vbCrLf & message, MsgBoxStyle.Exclamation, "DAL Download List Generator 1.0")
            End If
        Catch ex As Exception
            MsgBox("Sorry, but DAL Download List Generator 1.0 has trapped the following error: " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "DAL Download List Generator 1.0")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim result As DialogResult = SaveFileDialog1.ShowDialog()
            If result = DialogResult.OK And URL.Text.Length > 0 Then
                ProgressBar1.Visible = True
                Label2.Text = "Generating file..."
                Button1.Enabled = False

                File_Generator1.Save_File_Input = SaveFileDialog1.FileName
                SaveFileDialog1.Dispose()
                File_Generator1.Input_URL_Input = URL.Text
                File_Generator1.Count_Start_Input = start_counter_numeric.Value
                File_Generator1.Count_End_Input = end_counter_numeric.Value
                File_Generator1.Count_Step_Input = step_counter_numeric.Value
                File_Generator1.Count_String_Length_Input = String_Length.Value
                File_Generator1.ChooseThreads(1)

            End If
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub





    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Try
            Application.Exit()
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub

    Public Sub FileGeneratorHandler(ByVal Result As String)
        Try
            ' Displays the returned value in the appropriate label.
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0
            Label2.Text = Result

            If URL.Text.Length > 0 Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub

    Public Sub FGProgressHandler(ByVal value As Integer)
        Try
            ' Displays the returned value in the appropriate label.
            ProgressBar1.Value = value

        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub



    Private Sub URL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles URL.TextChanged
        Try
            If URL.Text.Length > 0 Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub







    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        Try
            Panel2.Visible = True
            Panel1.Visible = False
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        Try
            Panel1.Visible = True
            Panel2.Visible = False
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Try

            Dim si As Size
            Panel1.Visible = False
            Panel2.Visible = True
            If Help_Panel.Visible = True Then

                si = New Size(1, 1)
                Help_Panel.Size = si
                Help_Panel.Visible = False
            Else
                If About_Panel.Visible = True Then
                    si = New Size(1, 1)
                    About_Panel.Size = si
                    About_Panel.Visible = False
                End If
                si = New Size(424, 302)
                Help_Panel.Size = si

                Help_Panel.Visible = True


            End If
        Catch ex As Exception
            error_handler(ex.Message)
        End Try

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Try

            Dim si As Size
            
            If About_Panel.Visible = True Then

                si = New Size(1, 1)
                About_Panel.Size = si
                About_Panel.Visible = False
            Else
                If Help_Panel.Visible = True Then
                    Panel1.Visible = False
                    Panel2.Visible = True
                    si = New Size(1, 1)
                    Help_Panel.Size = si
                    Help_Panel.Visible = False
                End If
                si = New Size(424, 302)
                About_Panel.Size = si
                About_Panel.Visible = True

            End If
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub
End Class
