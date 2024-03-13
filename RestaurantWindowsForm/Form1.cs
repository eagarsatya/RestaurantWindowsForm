using RestaurantWindowsForm.Models;
using Newtonsoft;
using Newtonsoft.Json;

namespace RestaurantWindowsForm
{
    public partial class Form1 : Form
    {
        public List<MenuModel> Menus { get; set; } = new List<MenuModel>();
        public HttpClient _httpClient { get; set; } = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
        }

        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:779/api/restaurant");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            //var content = JsonSerializer.Deserialize<List<MenuModel>>(jsonContent);

            var content = JsonConvert.DeserializeObject<List<MenuModel>>(jsonContent);

            if (content != null)
            {
                Menus = content;
            }

            listBoxMenu.DataSource = Menus;
            listBoxMenu.DisplayMember = "MenuName";
        }

        private async void buttonAddMenu_Click(object sender, EventArgs e)
        {
            var foodTheme = textBoxFoodTheme.Text;
            var menuName = textBoxMenuName.Text;

            if (string.IsNullOrEmpty(menuName))
            {
                labelNotification.Text = "Menu Name can't be empty";
                return;
            }

            if (string.IsNullOrEmpty(foodTheme))
            {
                labelNotification.Text = "Food theme can't be empty";
                return;
            }

            var menuModel = new MenuInputModel
            {
                FoodTheme = foodTheme,
                IsAvailable = checkBoxAvailable.Checked,
                MenuName = textBoxMenuName.Text,
                RestaurantId = 1
            };

            var jsonString = JsonConvert.SerializeObject(menuModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:779/api/restaurant", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully to Insert New Menu";
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Menu";
            }
        }
    }
}
