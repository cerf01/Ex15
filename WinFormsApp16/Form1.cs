using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            TaskRunner((int)numericUpDown3.Value, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            MinMaxAVG();
        }

        private void Show(object obj = null)
        {
            int[] arr = ((int[])obj);
            int min = arr != null ? arr[0] : 0;
            int max = arr != null ? arr[1] : 51;
            int tCount = arr != null ? arr.Length > 2 ? arr[2] : 0 : 0;

            string tabs = new string('\t', tCount);
            Thread thread = new Thread(() =>
            {
                for (int i = min; i < max - 1; i++)
                    if (richTextBox1.InvokeRequired)
                        richTextBox1.Invoke(delegate { richTextBox1.Text += $"{tabs} | {i} |\n"; });

            });
            thread.Start();
        }

        private void TaskRunner(int count, int min, int max)
        {
            if (max < min)
                return;
            if (count < 1)
                count = 1;

            int elemsCount = max / count;
            int[] arr = new int[3];

            arr[0] = min;
            arr[1] = elemsCount;

            for (int i = 0; i < count; i++)
                richTextBox3.Text += $"Thread {i + 1}|"; ;


            for (int i = 0; i < count - 1; i++)
            {
                arr[0] = min + elemsCount * i;
                arr[1] = min + elemsCount * (i + 1);
                arr[2] = i;

                Show(arr);
            }
            arr[0] = min + elemsCount * count - 1;
            arr[1] = max + 1;
            arr[2] = count;
            Show(arr);
        }
        private void MinMaxAVG()
        {
            double avg = 0;

            int max = 0;
            int min = 0;

            var list = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 1000; i++)
            {
                list.Add(r.Next(-50, 100));
                richTextBox2.Text += $"{list[i]} ";
            }


            Thread minimalValue = new Thread(() =>
            {
                min = 0;
                foreach (var value in list)
                    if (value < min)
                        min = value;
                if (label1.InvokeRequired)
                    label1.Invoke(delegate { label1.Text = $"Min: {min}"; });
            });
            Thread maximalValue = new Thread(() =>
            {
                max = list[0];
                foreach (var value in list)
                    if (value > max)
                        max = value;
                if (label2.InvokeRequired)
                    label2.Invoke(delegate { label2.Text = $"Max: {max}"; });
            });
            Thread averageValue = new Thread(() =>
            {
                foreach (var value in list)
                    avg += value;
                avg /= list.Count;
                if (label3.InvokeRequired)
                    label3.Invoke(delegate { label3.Text = $"Avg: {avg}"; });
            });

            averageValue.Start();
            minimalValue.Start();
            maximalValue.Start();

            Thread saveResult = new Thread(() =>
            {
                string textToSave = $"______{DateTime.Now}_______\n Values: ";
                string path = Directory.GetCurrentDirectory() + @"\" + "log.txt";

                foreach (var item in list)
                    textToSave += $"{item} ";
                textToSave += $"\nMin: {min};\nMax: {max};\nAvg: {avg}\n";

                if (!File.Exists(path))
                    File.Create(path).Close();

                File.AppendAllText(path, textToSave);

            });



            saveResult.Start();

        }
    }
}
