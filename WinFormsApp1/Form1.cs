
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {   
        Form f;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� ������ ��� ����������? \n" +
                            "��� ���������� ������������ ���������� � �������� ���� ��� ���������, ������� ���������:\n" +
                            "1. ���������\n" +
                            "2. ������ � ������������ �����\n" +
                            "3. ����\n");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {   

           // MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
            MessageBox.Show(Raschet.FirstIterat(dateTimePicker1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            //DateTime.MinValue = DateTime.Now;
            
            if (dateTimePicker1.Value < DateTime.Today) {
                MessageBox.Show("������ ������� ���� ������� ��� ������!!");
                dateTimePicker1.Value = DateTime.Today;
            }
        }
    }
}