namespace WinFormsApp1;

public partial class Form1 : Form
{
    private TextBox[] textBoxes;
    
    public Form1()
    {
        InitializeComponent();
        textBoxes = new TextBox[]
        {
            textBox1, textBox2, textBox3,
            textBox4, textBox5, textBox6,
            textBox7, textBox8, textBox9,
            textBox10
        };
    }

    private void label4_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    
    private void label11_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button_Click(object sender, EventArgs e)
    {
        int[] mas = new int[10];
        int sum = 0;

        mas[0] = Convert.ToInt32(textBox1.Text);
        mas[1] = Convert.ToInt32(textBox2.Text);
        mas[2] = Convert.ToInt32(textBox3.Text);
        mas[3] = Convert.ToInt32(textBox4.Text);
        mas[4] = Convert.ToInt32(textBox5.Text);
        mas[5] = Convert.ToInt32(textBox6.Text);
        mas[6] = Convert.ToInt32(textBox7.Text);
        mas[7] = Convert.ToInt32(textBox8.Text);
        mas[8] = Convert.ToInt32(textBox9.Text);
        mas[9] = Convert.ToInt32(textBox10.Text);

        for (int i = 0; i < mas.Length; i++)
        {
            sum = sum + mas[i];
        }
        
        label11.Text = "Сумма массивов: " + sum.ToString();
    }
}
