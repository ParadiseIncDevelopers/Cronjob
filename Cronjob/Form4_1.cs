using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Cronjob
{
    public partial class Form4_1 : Form
    {
        public Form4_1()
        {
            InitializeComponent();
        }

        public int UpdateIndex
        {
            get; set;
        }

        private static HttpClient HttpClient
        {
            get
            {
                return new();
            }
            set
            {

            }
        }

        public static List<Api>? Lines { get; set; }

        private void UpdateButton(object sender, EventArgs e)
        {
            FileStream dbFile = null;

            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };

            Regex web_links = new(@"^[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$");
            Regex description = new(@"^(.)+$");
            Regex keys = new(@"^([A-Za-z-0-9]){20}$");

            if (File.Exists(Form1.Path))
            {
                try
                {
                    dbFile = File.OpenRead(Form1.Path);
                    Lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                    Lines[UpdateIndex].Active = trendyol_form_isactive.Checked;
                    Lines[UpdateIndex].RestaurantSecretKey = trendyol_form_apikey.Text;
                    Lines[UpdateIndex].Description = trendyol_form_description.Text;
                    Lines[UpdateIndex].OrderPostUrl = trendyol_form_orderposturl.Text;
                    Lines[UpdateIndex].ProductPostUrl = trendyol_form_productposturl.Text;
                    Lines[UpdateIndex].AppSecretKey = trendyol_form_appsecretkey.Text;
                    Lines[UpdateIndex].Timeout = Convert.ToInt16(trendyol_form_timeout.Text);
                    Lines[UpdateIndex].SupplierId = trendyol_form_supplierid.Text;

                    bool regexChecker = web_links.IsMatch(Lines[UpdateIndex].OrderPostUrl) && web_links.IsMatch(Lines[UpdateIndex].ProductPostUrl) && keys.IsMatch(Lines[UpdateIndex].RestaurantSecretKey) && keys.IsMatch(Lines[UpdateIndex].AppSecretKey) && description.IsMatch(Lines[UpdateIndex].Description);

                    if (regexChecker)
                    {
                        dbFile.Close();
                        File.WriteAllLines(Form1.Path, new List<string> { JsonSerializer.Serialize(Lines, options) });
                    }
                    else
                    {
                        MessageBox.Show("You have an error in your inputs please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    dbFile.Close();
                }
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream dbFile = null;

            if (File.Exists(Form1.Path))
            {
                try
                {
                    dbFile = File.OpenRead(Form1.Path);
                    Lines = JsonSerializer.Deserialize<List<Api>>(dbFile);
                    var tok = TokenGetter(UpdateIndex, Lines[UpdateIndex].AppSecretKey, Lines[UpdateIndex].RestaurantSecretKey);
                    ApiRequester(UpdateIndex, Lines[UpdateIndex].ProductPostUrl, tok);
                }
                catch (Exception)
                {
                    dbFile.Close();
                }
            }
        }

        private static string TokenGetter(int index, string appSecretKey, string restaurantSecretKey)
        {
            string authUri = "";

            if (Lines[index].BaseName == "TRENDYOL")
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(restaurantSecretKey + ":" + appSecretKey));
            }
            else
            {
                return authUri;
            }
        }

        private static void ApiRequester(int index, string postApi, string token)
        {
            string requestString(string baseName)
            {
                return baseName switch
                {
                    "GETIR" => "https://food-external-api-gateway.development.getirapi.com/restaurants/menu",
                    "TRENDYOL" => "https://api.trendyol.com/mealgw/suppliers/" + Lines[index].SupplierId + "/packages",
                    _ => "",
                };
            }

            string reqString = requestString(Lines[index].BaseName);

            if (Lines[index].BaseName == "TRENDYOL")
            {
                var request = new HttpRequestMessage(new HttpMethod("GET"), reqString);
                request.Headers.TryAddWithoutValidation("authorization", "Basic " + token);
                request.Headers.TryAddWithoutValidation("cache-control", "no-cache");
                request.Headers.TryAddWithoutValidation("x-agentname", "test");
                request.Headers.TryAddWithoutValidation("x-executor-user", "test");

                var response = HttpClient.SendAsync(request).Result.Content.ReadAsStringAsync().Result;

                if (Lines?.Count == 0 || Lines == null)
                {
                    return;
                }

                HttpClient.Dispose();
                HttpClient = new HttpClient();

                StringContent? payload = new(response, Encoding.UTF8, "application/x-www-form-urlencoded");
                string? newToken = HttpClient.PostAsync(postApi, payload).Result.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return;
            }
        }

        private void Form4_1_Load(object sender, EventArgs e)
        {
            FileStream dbFile = null;

            if (File.Exists(Form1.Path))
            {
                try
                {
                    dbFile = File.OpenRead(Form1.Path);
                    Lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                    trendyol_form_isactive.Checked = (bool)Lines[UpdateIndex].Active;
                    trendyol_form_apikey.Text = Lines[UpdateIndex].RestaurantSecretKey;
                    trendyol_form_description.Text = Lines[UpdateIndex].Description;
                    trendyol_form_orderposturl.Text = Lines[UpdateIndex].OrderPostUrl;
                    trendyol_form_productposturl.Text = Lines[UpdateIndex].ProductPostUrl;
                    trendyol_form_appsecretkey.Text = Lines[UpdateIndex].AppSecretKey;
                    trendyol_form_supplierid.Text = Lines[UpdateIndex].SupplierId;
                    trendyol_form_timeout.Text = Convert.ToString(Lines[UpdateIndex].Timeout);
                }
                catch (Exception)
                {
                    dbFile.Close();
                }
            }
        }
    }
}
