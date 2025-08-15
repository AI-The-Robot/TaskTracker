namespace TaskTracker;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        enterButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // enterButton
        // 
        enterButton.AutoSize = true;
        enterButton.Location = new System.Drawing.Point(146, 172);
        enterButton.Name = "enterButton";
        enterButton.Size = new System.Drawing.Size(75, 25);
        enterButton.TabIndex = 0;
        enterButton.Text = "Enter";
        enterButton.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(639, 428);
        Controls.Add(enterButton);
        Text = "Task Tracker";
        Click += Form1_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button enterButton;

    #endregion
}