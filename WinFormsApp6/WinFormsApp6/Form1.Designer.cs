namespace WinFormsApp6;

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
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        listBox1 = new System.Windows.Forms.ListBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(24, 40);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(127, 28);
        label1.TabIndex = 0;
        label1.Text = "Ввод чисел:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(122, 37);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(419, 27);
        textBox1.TabIndex = 1;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(34, 82);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(506, 244);
        listBox1.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(577, 39);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(169, 43);
        button1.TabIndex = 3;
        button1.Text = "Отправить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(listBox1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;

    #endregion
}