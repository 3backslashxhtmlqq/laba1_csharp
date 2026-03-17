namespace WinFormsApp2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        int sum = Convert.ToInt32(textBox1.Text);
        int[] mas =  new int[sum];
        Random random = new Random();

        for (int i = 0; i < sum; i++)
        {
            mas[i] = random.Next(1, 101);
            listBox1.Items.Add("Элемент массива " + i + " - " + mas[i]);
        }

        int max = mas[0];
        int min = mas[0];

        int index_max = 0;
        int index_min = 0;

        for (int i = 0; i < sum; i++)
        {
            if (mas[i] > max)
            {
                max = mas[i];
                index_max = i;
            }

            if (mas[i] < min)
            {
                min = mas[i];
                index_min = i;
            }
        }

        label3.Text = "Максимальный элемент массива: " + max;
        label4.Text = "Минимальный элемент массива: " + min;

    }
}