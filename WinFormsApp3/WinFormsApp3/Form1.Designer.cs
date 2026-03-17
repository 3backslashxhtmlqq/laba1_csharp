namespace WinFormsApp3;

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
        button1 = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(77, 39);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(188, 47);
        button1.TabIndex = 0;
        button1.Text = "Создать массив\r\n";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(445, 21);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(279, 264);
        listBox1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(404, 301);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(320, 23);
        label1.TabIndex = 2;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(404, 340);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(323, 23);
        label2.TabIndex = 3;
        label2.Text = "\r\n";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(listBox1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;

    #endregion
}