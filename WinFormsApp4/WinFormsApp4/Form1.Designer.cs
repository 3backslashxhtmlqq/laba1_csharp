namespace WinFormsApp4;

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
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox5 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(35, 26);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(74, 23);
        label1.TabIndex = 0;
        label1.Text = "Число 1:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(35, 71);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(74, 23);
        label2.TabIndex = 1;
        label2.Text = "Число 2:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(35, 115);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(74, 23);
        label3.TabIndex = 2;
        label3.Text = "Число 3:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(35, 161);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(74, 23);
        label4.TabIndex = 3;
        label4.Text = "Число 4:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(35, 211);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(74, 23);
        label5.TabIndex = 4;
        label5.Text = "Число 5:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(107, 25);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(61, 27);
        textBox1.TabIndex = 5;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(107, 68);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(61, 27);
        textBox2.TabIndex = 6;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(107, 112);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(61, 27);
        textBox3.TabIndex = 7;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(107, 157);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(61, 27);
        textBox4.TabIndex = 8;
        // 
        // textBox5
        // 
        textBox5.Location = new System.Drawing.Point(107, 207);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(61, 27);
        textBox5.TabIndex = 9;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(440, 25);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(172, 48);
        button1.TabIndex = 10;
        button1.Text = "Вывод массивов на экран";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(440, 112);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(172, 49);
        button2.TabIndex = 11;
        button2.Text = "Усложенный вариант";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(75, 291);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(513, 264);
        listBox1.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(698, 582);
        Controls.Add(listBox1);
        Controls.Add(button2);
        Controls.Add(button1);
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
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Button button1;

    #endregion
}