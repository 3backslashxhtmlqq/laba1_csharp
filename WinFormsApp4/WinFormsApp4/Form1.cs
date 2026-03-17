namespace WinFormsApp4;

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
        int[] reverse_mas =  new int[5];

        mas[0] = Convert.ToInt32(textBox1.Text);
        mas[1] = Convert.ToInt32(textBox2.Text);
        mas[2] = Convert.ToInt32(textBox3.Text);
        mas[3] = Convert.ToInt32(textBox4.Text);
        mas[4] = Convert.ToInt32(textBox5.Text);

        for (int i = 0; i < mas.Length; i++)
        {
            reverse_mas[i] = mas[mas.Length - 1 - i];
        }

        listBox1.Items.Clear();
        
        listBox1.Items.Add("Исходный массив чисел: ");
        
        foreach (int i in mas)
        {
            listBox1.Items.Add(i + " ");
        }

        listBox1.Items.Add("Обратный массив чисел: ");
        
        foreach (int i in reverse_mas)
        {
            listBox1.Items.Add(i + " ");
        }
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        
        int[] mas = new int[5];
        int[] reverse_mas =  new int[5];

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

        for (int i = 0; i < mas.Length / 2; i++)
        {
            int temp = mas[i];
            mas[i] = mas[mas.Length - 1 - i];
            mas[mas.Length - 1 - i] = temp;
        }
        
        listBox1.Items.Add("Обратный массив чисел:");
        
        foreach (int i in mas)
        {
            listBox1.Items.Add(i);
        }
        
    }
}