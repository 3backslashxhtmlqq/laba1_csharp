namespace WinFormsApp3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        
        int[] mas = new int[15];
        Random  rnd = new Random();
        
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rnd.Next(10, 51);
            listBox1.Items.Add("Элемент массива " + i + " - " + mas[i]);
        }

        int nechet = 0;
        int chet = 0;

        foreach (int i in mas)
        {
            if (i % 2 == 0)
            {
                label1.Text = "Четные: " + chet++;
            }
            else
            {
                label2.Text = "Нечетные: " + nechet++;
            }
        }

    }
}