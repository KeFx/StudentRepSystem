<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRepVotes
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
        Me.btnMissingVotes = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnFindWinner = New System.Windows.Forms.Button()
        Me.btnMoreResults = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMissingVotes
        '
        Me.btnMissingVotes.Location = New System.Drawing.Point(32, 32)
        Me.btnMissingVotes.Name = "btnMissingVotes"
        Me.btnMissingVotes.Size = New System.Drawing.Size(135, 57)
        Me.btnMissingVotes.TabIndex = 0
        Me.btnMissingVotes.Text = "Missing Votes "
        Me.btnMissingVotes.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(32, 115)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(135, 57)
        Me.btnStats.TabIndex = 1
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(32, 198)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(135, 57)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnFindWinner
        '
        Me.btnFindWinner.Location = New System.Drawing.Point(32, 282)
        Me.btnFindWinner.Name = "btnFindWinner"
        Me.btnFindWinner.Size = New System.Drawing.Size(135, 57)
        Me.btnFindWinner.TabIndex = 3
        Me.btnFindWinner.Text = "Find Winner"
        Me.btnFindWinner.UseVisualStyleBackColor = True
        '
        'btnMoreResults
        '
        Me.btnMoreResults.Location = New System.Drawing.Point(32, 367)
        Me.btnMoreResults.Name = "btnMoreResults"
        Me.btnMoreResults.Size = New System.Drawing.Size(135, 57)
        Me.btnMoreResults.TabIndex = 4
        Me.btnMoreResults.Text = "More Results"
        Me.btnMoreResults.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(196, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(623, 392)
        Me.DataGridView1.TabIndex = 5
        '
        'StudentRepVotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 460)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMoreResults)
        Me.Controls.Add(Me.btnFindWinner)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnMissingVotes)
        Me.Name = "StudentRepVotes"
        Me.Text = "Student Rep Votes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMissingVotes As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnFindWinner As Button
    Friend WithEvents btnMoreResults As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
