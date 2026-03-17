namespace WinFormsApp6;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();

        string[] s = textBox1.Text.Split(' ');
        int[] mas = new int[10];

        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = Convert.ToInt32(s[i]);
        }

        for (int i = 0; i < mas.Length; i++)
        {
            int temp = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[i] == mas[j])
                {
                    temp++;
                }
            }

            bool shown = false;
            for (int k = 0; k < i; k++)
            {
                if (mas[i] == mas[k])
                {
                    shown = true;
                    break;
                }
            }

            if (!shown)
            {
                listBox1.Items.Add("Число " + mas[i] + " встречается " + temp + " раз");
            }
        }
    }
}