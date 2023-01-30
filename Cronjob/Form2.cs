using System.Text.Json;
using System.Text.RegularExpressions;

namespace Cronjob
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SubmitForm(object sender, EventArgs e)
        {
            Regex web_links = new(@"^[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$");
            Regex description = new(@"^(.)+$");
            Regex keys = new(@"^([a-f0-9]){40}$");

            Api api = new()
            {
                Active = getir_form_isactive.Checked,
                AppSecretKey = getir_form_appsecretkey.Text,
                Description = getir_form_description.Text,
                OrderPostUrl = getir_form_orderposturl.Text,
                ProductPostUrl = getir_form_productposturl.Text,
                RestaurantSecretKey = getir_form_restaurantsecretkey.Text,
                Timeout = Convert.ToInt16(getir_form_timeout.Text),
                LastRequest = DateTime.Now
            };

            bool regexChecker = web_links.IsMatch(api.OrderPostUrl) && web_links.IsMatch(api.ProductPostUrl) && keys.IsMatch(api.AppSecretKey) && keys.IsMatch(api.RestaurantSecretKey) && description.IsMatch(api.Description);

            if (regexChecker)
            {
                JsonSerializerOptions options = new()
                {
                    WriteIndented = true
                };

                if (File.Exists(Form1.Path))
                {
                    FileStream dbFile = null;
                    List<Api>? lines;
                    try
                    {
                        dbFile = File.OpenRead(Form1.Path);
                        lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                        if (lines?.Count == 0 || lines == null)
                        {

                            var setLines = JsonSerializer.Serialize(new List<Api> { api }, options);
                            dbFile.Close();
                            File.AppendAllLines(Form1.Path, new List<string> { setLines });
                        }
                        else
                        {
                            lines.Add(api);
                            dbFile.Close();
                            File.WriteAllLines(Form1.Path, new List<string> { JsonSerializer.Serialize(lines, options) });
                        }
                    }
                    catch (Exception)
                    {
                        dbFile.Close();
                        var setLines = JsonSerializer.Serialize(new List<Api> { api }, options);
                        File.AppendAllLines(Form1.Path, new List<string> { setLines });
                    }
                }
                else
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "CronJob");
                    File.Create(Form1.Path).Close();

                    FileStream dbFile = null;
                    List<Api>? lines;
                    try
                    {
                        dbFile = File.OpenRead(Form1.Path);
                        lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                        if (lines?.Count == 0 || lines == null)
                        {
                            var setLines = JsonSerializer.Serialize(new List<Api> { api }, options);
                            dbFile.Close();
                            File.AppendAllLines(Form1.Path, new List<string> { setLines });
                        }
                        else
                        {
                            lines.Add(api);
                            dbFile.Close();
                            File.WriteAllLines(Form1.Path, new List<string> { JsonSerializer.Serialize(lines, options) });
                        }
                    }
                    catch (Exception)
                    {
                        dbFile.Close();
                        var setLines = JsonSerializer.Serialize(new List<Api> { api }, options);
                        File.AppendAllLines(Form1.Path, new List<string> { setLines });
                    }
                }
                Close();
            }
            else 
            {
                MessageBox.Show("You have an error in your inputs please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
