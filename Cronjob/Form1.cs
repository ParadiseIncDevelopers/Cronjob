using System.Text.Json;

namespace Cronjob
{
    public partial class Form1 : Form
    {
        private static HttpClient httpClient = new();

        public static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "CronJob" + "\\" + "db.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new();
            form4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path))
            {
                return;
            }

            FileStream dbFile = null;
            List<Api>? lines;
            try
            {
                dbFile = File.OpenRead(Path);
                lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                if (lines?.Count != 0 || lines != null)
                {
                    dbFile.Close();
                    for (int i = 0; i < lines.Count; i++)
                    {
                        dataGridView1.Rows.Add(lines[i].BaseName, lines[i].Description, lines[i].Active, string.Format("{0}-{1}-{2} {3}:{4}:{5}", lines[i].LastRequest.Year, lines[i].LastRequest.Month, lines[i].LastRequest.Day, lines[i].LastRequest.Hour, lines[i].LastRequest.Minute, lines[i].LastRequest.Second), lines[i].Timeout);
                    }
                }
                else
                {
                    dbFile.Close();
                }
            }
            catch (Exception)
            {
                dbFile.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists(Path))
            {
                return;
            }

            FileStream dbFile = null;
            List<Api>? lines;
            try
            {
                dbFile = File.OpenRead(Path);
                lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                if (lines?.Count != 0 || lines != null)
                {
                    dbFile.Close();
                    for (int i = 0; i < lines.Count; i++)
                    {
                        dataGridView1.Rows.Add(lines[i].BaseName, lines[i].Description, lines[i].Active, string.Format("{0}-{1}-{2} {3}:{4}:{5}", lines[i].LastRequest.Year, lines[i].LastRequest.Month, lines[i].LastRequest.Day, lines[i].LastRequest.Hour, lines[i].LastRequest.Minute, lines[i].LastRequest.Second), lines[i].Timeout);
                    }
                }
                else
                {
                    dbFile.Close();
                }
            }
            catch (Exception)
            {
                dbFile.Close();
            }
        }

        private void UpdateApiKey(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == "GETIR")
            {
                Form2_1 theForm = new()
                {
                    UpdateIndex = e.RowIndex
                };
                theForm.Show();
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == "TRENDYOL")
            {
                Form4_1 theForm = new()
                {
                    UpdateIndex = e.RowIndex
                };
                theForm.Show();
            }
        }
    }
}