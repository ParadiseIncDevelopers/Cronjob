using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Cronjob
{
    public partial class Form2_1 : Form
    {
        public Form2_1()
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
            Regex keys = new(@"^([a-f0-9]){40}$");

            if (File.Exists(Form1.Path))
            {
                try
                {
                    dbFile = File.OpenRead(Form1.Path);
                    Lines = JsonSerializer.Deserialize<List<Api>>(dbFile);
                        
                    Lines[UpdateIndex].Active = getir_form_isactive.Checked;
                    Lines[UpdateIndex].AppSecretKey = getir_form_appsecretkey.Text;
                    Lines[UpdateIndex].Description = getir_form_description.Text;
                    Lines[UpdateIndex].OrderPostUrl = getir_form_orderposturl.Text;
                    Lines[UpdateIndex].ProductPostUrl = getir_form_productposturl.Text;
                    Lines[UpdateIndex].RestaurantSecretKey = getir_form_restaurantsecretkey.Text;
                    Lines[UpdateIndex].Timeout = Convert.ToInt16(getir_form_timeout.Text);
                    Lines[UpdateIndex].SupplierId = "";

                    bool regexChecker = web_links.IsMatch(Lines[UpdateIndex].OrderPostUrl) && web_links.IsMatch(Lines[UpdateIndex].ProductPostUrl) && keys.IsMatch(Lines[UpdateIndex].AppSecretKey) && keys.IsMatch(Lines[UpdateIndex].RestaurantSecretKey) && description.IsMatch(Lines[UpdateIndex].Description);

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

        private void Form2_1_Load(object sender, EventArgs e)
        {
            FileStream dbFile = null;

            if (File.Exists(Form1.Path))
            {
                try
                {
                    dbFile = File.OpenRead(Form1.Path);
                    Lines = JsonSerializer.Deserialize<List<Api>>(dbFile);

                    getir_form_isactive.Checked = (bool)Lines[UpdateIndex].Active;
                    getir_form_appsecretkey.Text = Lines[UpdateIndex].AppSecretKey;
                    getir_form_description.Text = Lines[UpdateIndex].Description;
                    getir_form_orderposturl.Text = Lines[UpdateIndex].OrderPostUrl;
                    getir_form_productposturl.Text = Lines[UpdateIndex].ProductPostUrl;
                    getir_form_restaurantsecretkey.Text = Lines[UpdateIndex].RestaurantSecretKey;
                    getir_form_timeout.Text = Convert.ToString(Lines[UpdateIndex].Timeout);
                    getir_form_supplierid.Text = "---";
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

            if (Lines[index].BaseName == "GETIR")
            {
                authUri = "https://food-external-api-gateway.development.getirapi.com/auth/login";

                Dictionary<string, object> elements = new()
                {
                    { "appSecretKey", appSecretKey },
                    { "restaurantSecretKey", restaurantSecretKey }
                };
                try
                {
                    string? json = JsonSerializer.Serialize(elements);
                    StringContent? payload = new(json, Encoding.UTF8, "application/json");
                    string? token = HttpClient.PostAsync(authUri, payload).Result.Content.ReadAsStringAsync().Result;

                    Dictionary<string, object>? tokenGetter = JsonSerializer.Deserialize<Dictionary<string, object>>(token);

                    return tokenGetter["token"].ToString();
                }
                catch (AggregateException)
                {
                    string? json = JsonSerializer.Serialize(elements);
                    StringContent? payload = new(json, Encoding.UTF8, "application/json");
                    string? token = HttpClient.PostAsync(authUri, payload).Result.Content.ReadAsStringAsync().Result;

                    Dictionary<string, object>? tokenGetter = JsonSerializer.Deserialize<Dictionary<string, object>>(token);

                    return tokenGetter["token"].ToString();
                }
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
                    "TRENDYOL" => "https://api.trendyol.com/mealgw/suppliers/718787/packages",
                    _ => "",
                };
            }

            string reqString = requestString(Lines[index].BaseName);

            if (Lines[index].BaseName == "GETIR")
            {
                string requestMethod = "GET";

                HttpRequestMessage? request = new(new HttpMethod(requestMethod), reqString);
                request.Headers.TryAddWithoutValidation("accept", "application/json");
                request.Headers.TryAddWithoutValidation("token", token);

                string? response = HttpClient.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine("verilen veri : " + response);

                if (Lines?.Count == 0 || Lines == null)
                {
                    return;
                }

                StringContent? payload = new(response, Encoding.UTF8, "application/x-www-form-urlencoded");
                string? newToken = HttpClient.PostAsync(postApi, payload).Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(newToken);
            }
            else
            {
                return;
            }
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
    }
}