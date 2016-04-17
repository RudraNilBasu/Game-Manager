<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Entry_TimeLabel As System.Windows.Forms.Label
        Dim Exit_TimeLabel As System.Windows.Forms.Label
        Dim MondayLabel As System.Windows.Forms.Label
        Dim TuesdayLabel As System.Windows.Forms.Label
        Dim WednesdayLabel As System.Windows.Forms.Label
        Dim ThursdayLabel As System.Windows.Forms.Label
        Dim FridayLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employee))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DatabaseDataSet = New GameManager.DatabaseDataSet()
        Me.Employee_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_DetailsTableAdapter = New GameManager.DatabaseDataSetTableAdapters.Employee_DetailsTableAdapter()
        Me.TableAdapterManager = New GameManager.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Employee_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Employee_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Entry_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Exit_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MondayCheckBox = New System.Windows.Forms.CheckBox()
        Me.TuesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.WednesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.ThursdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.FridayCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExitTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MondayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TuesdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WednesdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ThursdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FridayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        NAMELabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Entry_TimeLabel = New System.Windows.Forms.Label()
        Exit_TimeLabel = New System.Windows.Forms.Label()
        MondayLabel = New System.Windows.Forms.Label()
        TuesdayLabel = New System.Windows.Forms.Label()
        WednesdayLabel = New System.Windows.Forms.Label()
        ThursdayLabel = New System.Windows.Forms.Label()
        FridayLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Employee_DetailsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        IDLabel.Location = New System.Drawing.Point(280, 254)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 8
        IDLabel.Text = "ID:"
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        NAMELabel.Location = New System.Drawing.Point(280, 282)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(51, 17)
        NAMELabel.TabIndex = 10
        NAMELabel.Text = "NAME:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        PositionLabel.Location = New System.Drawing.Point(280, 310)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(62, 17)
        PositionLabel.TabIndex = 12
        PositionLabel.Text = "Position:"
        '
        'Entry_TimeLabel
        '
        Entry_TimeLabel.AutoSize = True
        Entry_TimeLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Entry_TimeLabel.Location = New System.Drawing.Point(280, 339)
        Entry_TimeLabel.Name = "Entry_TimeLabel"
        Entry_TimeLabel.Size = New System.Drawing.Size(80, 17)
        Entry_TimeLabel.TabIndex = 14
        Entry_TimeLabel.Text = "Entry Time:"
        '
        'Exit_TimeLabel
        '
        Exit_TimeLabel.AutoSize = True
        Exit_TimeLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Exit_TimeLabel.Location = New System.Drawing.Point(280, 367)
        Exit_TimeLabel.Name = "Exit_TimeLabel"
        Exit_TimeLabel.Size = New System.Drawing.Size(69, 17)
        Exit_TimeLabel.TabIndex = 16
        Exit_TimeLabel.Text = "Exit Time:"
        '
        'MondayLabel
        '
        MondayLabel.AutoSize = True
        MondayLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        MondayLabel.Location = New System.Drawing.Point(280, 396)
        MondayLabel.Name = "MondayLabel"
        MondayLabel.Size = New System.Drawing.Size(62, 17)
        MondayLabel.TabIndex = 18
        MondayLabel.Text = "Monday:"
        '
        'TuesdayLabel
        '
        TuesdayLabel.AutoSize = True
        TuesdayLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        TuesdayLabel.Location = New System.Drawing.Point(280, 426)
        TuesdayLabel.Name = "TuesdayLabel"
        TuesdayLabel.Size = New System.Drawing.Size(67, 17)
        TuesdayLabel.TabIndex = 20
        TuesdayLabel.Text = "Tuesday:"
        '
        'WednesdayLabel
        '
        WednesdayLabel.AutoSize = True
        WednesdayLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        WednesdayLabel.Location = New System.Drawing.Point(280, 456)
        WednesdayLabel.Name = "WednesdayLabel"
        WednesdayLabel.Size = New System.Drawing.Size(87, 17)
        WednesdayLabel.TabIndex = 22
        WednesdayLabel.Text = "Wednesday:"
        '
        'ThursdayLabel
        '
        ThursdayLabel.AutoSize = True
        ThursdayLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        ThursdayLabel.Location = New System.Drawing.Point(280, 486)
        ThursdayLabel.Name = "ThursdayLabel"
        ThursdayLabel.Size = New System.Drawing.Size(72, 17)
        ThursdayLabel.TabIndex = 24
        ThursdayLabel.Text = "Thursday:"
        '
        'FridayLabel
        '
        FridayLabel.AutoSize = True
        FridayLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        FridayLabel.Location = New System.Drawing.Point(280, 516)
        FridayLabel.Name = "FridayLabel"
        FridayLabel.Size = New System.Drawing.Size(51, 17)
        FridayLabel.TabIndex = 26
        FridayLabel.Text = "Friday:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Assassin$", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(298, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Details"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All", "Programmer", "Graphics Designer", "Sound Designer"})
        Me.ComboBox1.Location = New System.Drawing.Point(157, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(69, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Position"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(626, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(131, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 107)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employee_DetailsBindingSource
        '
        Me.Employee_DetailsBindingSource.DataMember = "Employee Details"
        Me.Employee_DetailsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Employee_DetailsTableAdapter
        '
        Me.Employee_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_DetailsTableAdapter = Me.Employee_DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = GameManager.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Employee_DetailsBindingNavigator
        '
        Me.Employee_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Employee_DetailsBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Employee_DetailsBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Employee_DetailsBindingNavigator.BindingSource = Me.Employee_DetailsBindingSource
        Me.Employee_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Employee_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Employee_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Employee_DetailsBindingNavigatorSaveItem})
        Me.Employee_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Employee_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Employee_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Employee_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Employee_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Employee_DetailsBindingNavigator.Name = "Employee_DetailsBindingNavigator"
        Me.Employee_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Employee_DetailsBindingNavigator.Size = New System.Drawing.Size(1104, 27)
        Me.Employee_DetailsBindingNavigator.TabIndex = 7
        Me.Employee_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Employee_DetailsBindingNavigatorSaveItem
        '
        Me.Employee_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Employee_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Employee_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Employee_DetailsBindingNavigatorSaveItem.Name = "Employee_DetailsBindingNavigatorSaveItem"
        Me.Employee_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Employee_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_DetailsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(373, 251)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDTextBox.TabIndex = 9
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_DetailsBindingSource, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(373, 279)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(200, 22)
        Me.NAMETextBox.TabIndex = 11
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_DetailsBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(373, 307)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PositionTextBox.TabIndex = 13
        '
        'Entry_TimeDateTimePicker
        '
        Me.Entry_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Employee_DetailsBindingSource, "Entry Time", True))
        Me.Entry_TimeDateTimePicker.Location = New System.Drawing.Point(373, 335)
        Me.Entry_TimeDateTimePicker.Name = "Entry_TimeDateTimePicker"
        Me.Entry_TimeDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Entry_TimeDateTimePicker.TabIndex = 15
        '
        'Exit_TimeDateTimePicker
        '
        Me.Exit_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Employee_DetailsBindingSource, "Exit Time", True))
        Me.Exit_TimeDateTimePicker.Location = New System.Drawing.Point(373, 363)
        Me.Exit_TimeDateTimePicker.Name = "Exit_TimeDateTimePicker"
        Me.Exit_TimeDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Exit_TimeDateTimePicker.TabIndex = 17
        '
        'MondayCheckBox
        '
        Me.MondayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Employee_DetailsBindingSource, "Monday", True))
        Me.MondayCheckBox.Location = New System.Drawing.Point(373, 391)
        Me.MondayCheckBox.Name = "MondayCheckBox"
        Me.MondayCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.MondayCheckBox.TabIndex = 19
        Me.MondayCheckBox.Text = "CheckBox1"
        Me.MondayCheckBox.UseVisualStyleBackColor = True
        '
        'TuesdayCheckBox
        '
        Me.TuesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Employee_DetailsBindingSource, "Tuesday", True))
        Me.TuesdayCheckBox.Location = New System.Drawing.Point(373, 421)
        Me.TuesdayCheckBox.Name = "TuesdayCheckBox"
        Me.TuesdayCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.TuesdayCheckBox.TabIndex = 21
        Me.TuesdayCheckBox.Text = "CheckBox1"
        Me.TuesdayCheckBox.UseVisualStyleBackColor = True
        '
        'WednesdayCheckBox
        '
        Me.WednesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Employee_DetailsBindingSource, "Wednesday", True))
        Me.WednesdayCheckBox.Location = New System.Drawing.Point(373, 451)
        Me.WednesdayCheckBox.Name = "WednesdayCheckBox"
        Me.WednesdayCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.WednesdayCheckBox.TabIndex = 23
        Me.WednesdayCheckBox.Text = "CheckBox1"
        Me.WednesdayCheckBox.UseVisualStyleBackColor = True
        '
        'ThursdayCheckBox
        '
        Me.ThursdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Employee_DetailsBindingSource, "Thursday", True))
        Me.ThursdayCheckBox.Location = New System.Drawing.Point(373, 481)
        Me.ThursdayCheckBox.Name = "ThursdayCheckBox"
        Me.ThursdayCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ThursdayCheckBox.TabIndex = 25
        Me.ThursdayCheckBox.Text = "CheckBox1"
        Me.ThursdayCheckBox.UseVisualStyleBackColor = True
        '
        'FridayCheckBox
        '
        Me.FridayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Employee_DetailsBindingSource, "Friday", True))
        Me.FridayCheckBox.Location = New System.Drawing.Point(373, 511)
        Me.FridayCheckBox.Name = "FridayCheckBox"
        Me.FridayCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.FridayCheckBox.TabIndex = 27
        Me.FridayCheckBox.Text = "CheckBox1"
        Me.FridayCheckBox.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.EntryTimeDataGridViewTextBoxColumn, Me.ExitTimeDataGridViewTextBoxColumn, Me.MondayDataGridViewCheckBoxColumn, Me.TuesdayDataGridViewCheckBoxColumn, Me.WednesdayDataGridViewCheckBoxColumn, Me.ThursdayDataGridViewCheckBoxColumn, Me.FridayDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.Employee_DetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 584)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1025, 282)
        Me.DataGridView1.TabIndex = 28
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'EntryTimeDataGridViewTextBoxColumn
        '
        Me.EntryTimeDataGridViewTextBoxColumn.DataPropertyName = "Entry Time"
        Me.EntryTimeDataGridViewTextBoxColumn.HeaderText = "Entry Time"
        Me.EntryTimeDataGridViewTextBoxColumn.Name = "EntryTimeDataGridViewTextBoxColumn"
        '
        'ExitTimeDataGridViewTextBoxColumn
        '
        Me.ExitTimeDataGridViewTextBoxColumn.DataPropertyName = "Exit Time"
        Me.ExitTimeDataGridViewTextBoxColumn.HeaderText = "Exit Time"
        Me.ExitTimeDataGridViewTextBoxColumn.Name = "ExitTimeDataGridViewTextBoxColumn"
        '
        'MondayDataGridViewCheckBoxColumn
        '
        Me.MondayDataGridViewCheckBoxColumn.DataPropertyName = "Monday"
        Me.MondayDataGridViewCheckBoxColumn.HeaderText = "Monday"
        Me.MondayDataGridViewCheckBoxColumn.Name = "MondayDataGridViewCheckBoxColumn"
        '
        'TuesdayDataGridViewCheckBoxColumn
        '
        Me.TuesdayDataGridViewCheckBoxColumn.DataPropertyName = "Tuesday"
        Me.TuesdayDataGridViewCheckBoxColumn.HeaderText = "Tuesday"
        Me.TuesdayDataGridViewCheckBoxColumn.Name = "TuesdayDataGridViewCheckBoxColumn"
        '
        'WednesdayDataGridViewCheckBoxColumn
        '
        Me.WednesdayDataGridViewCheckBoxColumn.DataPropertyName = "Wednesday"
        Me.WednesdayDataGridViewCheckBoxColumn.HeaderText = "Wednesday"
        Me.WednesdayDataGridViewCheckBoxColumn.Name = "WednesdayDataGridViewCheckBoxColumn"
        '
        'ThursdayDataGridViewCheckBoxColumn
        '
        Me.ThursdayDataGridViewCheckBoxColumn.DataPropertyName = "Thursday"
        Me.ThursdayDataGridViewCheckBoxColumn.HeaderText = "Thursday"
        Me.ThursdayDataGridViewCheckBoxColumn.Name = "ThursdayDataGridViewCheckBoxColumn"
        '
        'FridayDataGridViewCheckBoxColumn
        '
        Me.FridayDataGridViewCheckBoxColumn.DataPropertyName = "Friday"
        Me.FridayDataGridViewCheckBoxColumn.HeaderText = "Friday"
        Me.FridayDataGridViewCheckBoxColumn.Name = "FridayDataGridViewCheckBoxColumn"
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1104, 916)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(Me.NAMETextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Entry_TimeLabel)
        Me.Controls.Add(Me.Entry_TimeDateTimePicker)
        Me.Controls.Add(Exit_TimeLabel)
        Me.Controls.Add(Me.Exit_TimeDateTimePicker)
        Me.Controls.Add(MondayLabel)
        Me.Controls.Add(Me.MondayCheckBox)
        Me.Controls.Add(TuesdayLabel)
        Me.Controls.Add(Me.TuesdayCheckBox)
        Me.Controls.Add(WednesdayLabel)
        Me.Controls.Add(Me.WednesdayCheckBox)
        Me.Controls.Add(ThursdayLabel)
        Me.Controls.Add(Me.ThursdayCheckBox)
        Me.Controls.Add(FridayLabel)
        Me.Controls.Add(Me.FridayCheckBox)
        Me.Controls.Add(Me.Employee_DetailsBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "employee"
        Me.Text = "employee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Employee_DetailsBindingNavigator.ResumeLayout(False)
        Me.Employee_DetailsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DatabaseDataSet As GameManager.DatabaseDataSet
    Friend WithEvents Employee_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_DetailsTableAdapter As GameManager.DatabaseDataSetTableAdapters.Employee_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As GameManager.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Employee_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Employee_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Entry_TimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Exit_TimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MondayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TuesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WednesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ThursdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FridayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExitTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MondayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TuesdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WednesdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ThursdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FridayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
