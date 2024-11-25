using System.Xml;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] student = new String[5];
            {
                student[0] = "���";
                student[1] = "�ͤ��";
                student[2] = "ࢵ��";
                student[3] = "⪡ع";
                student[4] = "�鹡���";
                String test = "";
                int n = student.Length; //�Ң�Ҵ�ͧ Array
                for (int i = 0; i < n; i++)
                {
                    test += student[i] + Environment.NewLine;
                }
                MessageBox.Show(test);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] Fruits = { "���", "�����¹", "�С͡", "�ѡ��", "��ҡ����" };
            String myFruit = "";
            foreach (String str in Fruits)
            {
                myFruit += str + ", ";
            }
            MessageBox.Show(myFruit, "�����ͧ�ѹ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;  //�Ӣ��������к�÷Ѵ����������
            string result = "";
            foreach (String str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }

            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    result += x.ToString() + Environment.NewLine;
                    sum += x;
                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "������ͧ����Ţ");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "�ͻ�";
            student[0, 1] = "�֧���";
            student[1, 0] = "���";
            student[1, 1] = "�ش�";
            student[2, 0] = "����";
            student[2, 1] = "˹ͧ�������";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j];
                    if (j < n - 1)
                    {
                        ResultData += "-";
                    }
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "�ʴ�������� Array 2 �Ե�");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Fruits = { "���", "�����¹", "�С͡", "�ѡ��", "��ҡ����" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + ".";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + ".";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
