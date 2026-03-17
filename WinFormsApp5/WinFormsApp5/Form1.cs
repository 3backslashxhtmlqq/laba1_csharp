namespace WinFormsApp5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();

        int[] mas = new int[5];
        
        mas[0] = Convert.ToInt32(textBox1.Text);
        mas[1] = Convert.ToInt32(textBox2.Text);
        mas[2] = Convert.ToInt32(textBox3.Text);
        mas[3] = Convert.ToInt32(textBox4.Text);
        mas[4] = Convert.ToInt32(textBox5.Text);

        listBox1.Items.Add("Исходный массив чисел:");
        
        foreach (int i in mas)
        {
            listBox1.Items.Add(i);
        }
        
        listBox1.Items.Add("Сдвинутый вправо массив чисел:");
        
        int last = mas[mas.Length - 1];
        for (int i = mas.Length - 1; i > 0; i--)
        {
            mas[i] = mas[i - 1];
        }

        mas[0] = last;

        foreach (int i in mas)
        {
            listBox1.Items.Add(i);
        }

    }
}