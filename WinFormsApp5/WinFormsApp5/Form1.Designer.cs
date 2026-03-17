namespace WinFormsApp5;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox5 = new System.Windows.Forms.TextBox();
        listBox1 = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(465, 37);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(198, 50);
        button1.TabIndex = 0;
        button1.Text = "Сдвинуть массив вправо";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(30, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(71, 21);
        label1.TabIndex = 1;
        label1.Text = "Число 1:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(30, 72);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(71, 21);
        label2.TabIndex = 2;
        label2.Text = "Число 2:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(30, 105);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(71, 21);
        label3.TabIndex = 3;
        label3.Text = "Число 3:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(30, 137);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(71, 21);
        label4.TabIndex = 4;
        label4.Text = "Число 4:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(30, 170);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(71, 21);
        label5.TabIndex = 5;
        label5.Text = "Число 5:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(107, 32);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(51, 27);
        textBox1.TabIndex = 6;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(107, 66);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(51, 27);
        textBox2.TabIndex = 7;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(107, 99);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(51, 27);
        textBox3.TabIndex = 8;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(107, 131);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(51, 27);
        textBox4.TabIndex = 9;
        // 
        // textBox5
        // 
        textBox5.Location = new System.Drawing.Point(107, 164);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(51, 27);
        textBox5.TabIndex = 10;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(407, 116);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(315, 244);
        listBox1.TabIndex = 11;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(listBox1);
        Controls.Add(textBox5);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    #endregion
}