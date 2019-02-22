<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.frmMainTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.userInput = New System.Windows.Forms.TextBox()
        Me.lblDayNumber = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtFinalOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "&Enter"
        Me.frmMainTips.SetToolTip(Me.btnEnter, "Click to insert a new amount of items sold")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(197, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.frmMainTips.SetToolTip(Me.btnExit, "Click to Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(104, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.frmMainTips.SetToolTip(Me.btnReset, "Click to reset the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(33, 30)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(50, 20)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "&Units: "
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userInput
        '
        Me.userInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userInput.Location = New System.Drawing.Point(89, 27)
        Me.userInput.Name = "userInput"
        Me.userInput.Size = New System.Drawing.Size(100, 26)
        Me.userInput.TabIndex = 0
        Me.frmMainTips.SetToolTip(Me.userInput, "Input units sold during the current day")
        '
        'lblDayNumber
        '
        Me.lblDayNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayNumber.Location = New System.Drawing.Point(195, 30)
        Me.lblDayNumber.Name = "lblDayNumber"
        Me.lblDayNumber.Size = New System.Drawing.Size(70, 20)
        Me.lblDayNumber.TabIndex = 4
        Me.lblDayNumber.Text = "Day"
        Me.lblDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOutput
        '
        Me.txtOutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtOutput.Location = New System.Drawing.Point(37, 59)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(213, 120)
        Me.txtOutput.TabIndex = 5
        Me.txtOutput.TabStop = False
        Me.frmMainTips.SetToolTip(Me.txtOutput, "List of Units shipped")
        '
        'txtFinalOutput
        '
        Me.txtFinalOutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFinalOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalOutput.Location = New System.Drawing.Point(37, 185)
        Me.txtFinalOutput.Name = "txtFinalOutput"
        Me.txtFinalOutput.ReadOnly = True
        Me.txtFinalOutput.Size = New System.Drawing.Size(213, 26)
        Me.txtFinalOutput.TabIndex = 6
        Me.txtFinalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.frmMainTips.SetToolTip(Me.txtFinalOutput, "Output for Average units shipped")
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtFinalOutput)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblDayNumber)
        Me.Controls.Add(Me.userInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents frmMainTips As ToolTip
    Friend WithEvents lblUnits As Label
    Friend WithEvents userInput As TextBox
    Friend WithEvents lblDayNumber As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtFinalOutput As TextBox
End Class
