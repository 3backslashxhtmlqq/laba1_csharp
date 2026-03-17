namespace WinFormsApp2;

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
        label2 = new System.Windows.Forms.Label();
        listBox1 = new System.Windows.Forms.ListBox();
        button1 = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(25, 40);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(186, 31);
        label1.TabIndex = 0;
        label1.Text = "Размер массива N:\r\n";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(191, 39);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(95, 27);
        textBox1.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.Location = new System.Drawing.Point(549, 28);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(91, 26);
        label2.TabIndex = 2;
        label2.Text = "Массив N\r\n";
        label2.Click += label2_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(480, 69);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(237, 264);
        listBox1.TabIndex = 3;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(42, 117);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(217, 43);
        button1.TabIndex = 4;
        button1.Text = "Заполнить массив";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(467, 336);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(312, 31);
        label3.TabIndex = 5;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(451, 367);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(312, 31);
        label4.TabIndex = 6;
        label4.Text = "\r\n";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(listBox1);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}