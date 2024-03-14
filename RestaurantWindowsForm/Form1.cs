using RestaurantWindowsForm.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.Text.Json;

namespace RestaurantWindowsForm
{
    public partial class Form1 : Form
    {
        public List<MenuModel> Menus { get; set; } = new List<MenuModel>();
        public List<RestaurantModel> Restaurants { get; set; } = new List<RestaurantModel>();
        public HttpClient _httpClient { get; set; } = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            PopulateListBox();
        }

        public async void PopulateComboBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:779/api/restaurant");

            var jsonContent = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var restaurants = System.Text.Json.JsonSerializer.Deserialize<List<RestaurantModel>>(jsonContent, options);

            if (restaurants != null) Restaurants = restaurants;

            //comboBoxRestaurant.DataSource = Restaurants;
            comboBoxRestaurant.Items.Clear();
            comboBoxRestaurant.Items.AddRange(Restaurants.ToArray());
            comboBoxRestaurant.DisplayMember = "RestaurantName";
        }

        public async void PopulateListBox()
        {
            var response = await _httpClient.GetAsync("https://new-dev.accelist.com:779/api/menu");
            response.EnsureSuccessStatusCode();
            var jsonContent = await response.Content.ReadAsStringAsync();
            //var content = JsonSerializer.Deserialize<List<MenuModel>>(jsonContent);

            var content = JsonConvert.DeserializeObject<List<MenuModel>>(jsonContent);

            if (content != null)
            {
                Menus = content;
            }

            //listBoxMenu.DataSource = Menus;
            listBoxMenu.Items.Clear();
            listBoxMenu.Items.AddRange(Menus.ToArray());
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
            var selectedRestaurant = comboBoxRestaurant.SelectedItem as RestaurantModel;
            if (selectedRestaurant == null)
            {
                labelNotification.Text = "Restaurant can't be empty";
                return;
            }

            var menuModel = new MenuInputModel
            {
                FoodTheme = foodTheme,
                IsAvailable = checkBoxAvailable.Checked,
                MenuName = textBoxMenuName.Text,
                RestaurantId = selectedRestaurant.RestaurantId,
            };

            var jsonString = JsonConvert.SerializeObject(menuModel);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


            var response = await _httpClient.PostAsync("https://new-dev.accelist.com:779/api/menu", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Succesfully to Insert New Menu";
            }
            else
            {
                labelNotification.Text = "Failed to Insert New Menu";
            }

            PopulateListBox();
            ClearForm();
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBoxMenu.SelectedItem as MenuModel;
            if (selectedItem == null) return;
            textBoxMenuName.Text = selectedItem.MenuName;
            textBoxFoodTheme.Text = selectedItem.FoodTheme;
            checkBoxAvailable.Checked = selectedItem.IsAvailable;

            var currentRestaurant = Restaurants.Where(Q => Q.RestaurantName == selectedItem.RestaurantName).FirstOrDefault();

            comboBoxRestaurant.SelectedItem = currentRestaurant;
        }

        public void ClearForm()
        {
            textBoxFoodTheme.Text = string.Empty;
            textBoxMenuName.Text = string.Empty;
            comboBoxRestaurant.SelectedItem = null;
            checkBoxAvailable.Checked = false;
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            var menuName = textBoxMenuName.Text;
            var foodTheme = textBoxFoodTheme.Text;
            var selectedMenu = listBoxMenu.SelectedItem as MenuModel;
            var selectedRestaurant = comboBoxRestaurant.SelectedItem as RestaurantModel;

            if (selectedMenu == null)
            {
                labelNotification.Text = "Restaurant can't be empty";
                return;
            }

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

            if (selectedRestaurant == null)
            {
                labelNotification.Text = "Restaurant can't be empty";
                return;
            }

            var updatedModel = new MenuInputModel
            {
                FoodTheme = foodTheme,
                IsAvailable = checkBoxAvailable.Checked,
                MenuId = selectedMenu.MenuId,
                MenuName = menuName,
                RestaurantId = selectedRestaurant.RestaurantId,
            };

            var jsonString = JsonConvert.SerializeObject(updatedModel);
            var contentHttp = new StringContent(jsonString);
            contentHttp.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.PutAsync("https://new-dev.accelist.com:779/api/menu", contentHttp);

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Success Updating";
            }
            else
            {
                labelNotification.Text = "Failed to Update";
            }

            PopulateListBox();
            ClearForm();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedMenuIndex = listBoxMenu.SelectedIndex;
            var selectedMenu = listBoxMenu.Items[selectedMenuIndex] as MenuModel;

            if (selectedMenu == null)
            {
                labelNotification.Text = "Can't delete empty item";
                return;
            }

            var response = await _httpClient.DeleteAsync($"https://new-dev.accelist.com:779/api/menu/{selectedMenu.MenuId}");

            if (response.IsSuccessStatusCode)
            {
                labelNotification.Text = "Success deleting menu";
            }
            else
            {
                labelNotification.Text = "Failed to delete menu";
            }

            PopulateListBox();
            ClearForm();
        }
    }
}
