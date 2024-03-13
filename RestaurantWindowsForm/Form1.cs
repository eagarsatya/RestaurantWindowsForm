using RestaurantWindowsForm.Models;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantWindowsForm
{
    public partial class Form1 : Form
    {
        public List<MenuModel> Menus { get; set; } = new List<MenuModel>();
        public List<FoodTypeModel> FoodType { get; set; }
        public int MenuId { get; set; } = 2;
        public Form1()
        {
            FoodType = new List<FoodTypeModel>()
            {
                new FoodTypeModel
                {
                    FoodTypeId = 1,
                    FoodTypeName = "Indonesian Food",
                },
                new FoodTypeModel
                {
                    FoodTypeId = 2,
                    FoodTypeName = "Western Food"
                }
            };

            Menus = new List<MenuModel>()
            {
                new MenuModel()
                {
                    MenuId = 1,
                    IsSpicy = true,
                    MenuName = "Pizza Hut",
                    FoodTypeId = 2,
                },
                new MenuModel()
                {
                    MenuId = 2,
                    IsSpicy = false,
                    MenuName = "Pizza Padang",
                    FoodTypeId = 1,
                }
            };
            InitializeComponent();
            PopulateFoodTypeComboBox();
            PopulateListBox();
            PopulateDataGridView();
            //tableLayoutPanelInsert.Visible = false;
        }

        public void PopulateFoodTypeComboBox()
        {
            comboBoxFoodType.DataSource = FoodType;
            comboBoxFoodType.DisplayMember = "FoodTypeName";
        }

        public void PopulateListBox()
        {
            var dataSourceMenu = new BindingSource();
            foreach (var menu in Menus)
            {
                dataSourceMenu.Add(menu);
            }

            listBoxMenu.DataSource = dataSourceMenu;
            listBoxMenu.DisplayMember = "MenuName";
        }

        public void PopulateDataGridView()
        {
            var bindingSourceMenu = new BindingSource();

            foreach (var menu in Menus)
            {
                bindingSourceMenu.Add(menu);
            }

            dataGridViewMenu.DataSource = bindingSourceMenu;
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxMenu.SelectedIndex;
            var selectedMenu = listBoxMenu.Items[selectedIndex] as MenuModel;

            if (selectedMenu != null)
            {
                textBoxMenuName.Text = selectedMenu.MenuName;
                checkBoxLevelSpicy.Checked = selectedMenu.IsSpicy;
                var foodType = FoodType.FirstOrDefault(Q => Q.FoodTypeId == selectedMenu.FoodTypeId);
                comboBoxFoodType.SelectedItem = foodType;
            }
        }

        private void buttonAddMenu_Click(object sender, EventArgs e)
        {
            labelValidation.Text = string.Empty;
            var menuName = textBoxMenuName.Text;
            var selectedFoodType = comboBoxFoodType.SelectedItem as FoodTypeModel;

            if (string.IsNullOrEmpty(menuName))
            {
                labelValidation.Text = "Menu can't be empty";
                return;
            }

            if (selectedFoodType == null)
            {
                labelValidation.Text = "Food Type can't be empty";
                return;
            }

            var newMenu = new MenuModel()
            {
                MenuId = MenuId + 1,
                MenuName = menuName,
                IsSpicy = checkBoxLevelSpicy.Checked,
                FoodTypeId = selectedFoodType.FoodTypeId
            };

            MenuId++;

            Menus.Add(newMenu);

            var menuBindingSource = new BindingSource();

            foreach (var menu in Menus)
            {
                menuBindingSource.Add(menu);
            }

            listBoxMenu.DataSource = menuBindingSource;
            listBoxMenu.DisplayMember = "MenuName";

            dataGridViewMenu.DataSource = menuBindingSource;
            ClearInput();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxMenu.SelectedIndex;
            var selectedFoodType = comboBoxFoodType.SelectedItem as FoodTypeModel;

            var menuName = textBoxMenuName.Text;
            if (string.IsNullOrEmpty(menuName))
            {
                labelValidation.Text = "Menu can't be empty";
                return;
            }

            if (selectedFoodType == null)
            {
                labelValidation.Text = "Food Type can't be empty";
                return;
            }

            Menus[selectedIndex].MenuName = menuName;
            Menus[selectedIndex].IsSpicy = checkBoxLevelSpicy.Checked;
            Menus[selectedIndex].FoodTypeId = selectedFoodType.FoodTypeId;

            var menuBindingSource = new BindingSource();
            foreach (var menu in Menus)
            {
                menuBindingSource.Add(menu);
            }

            listBoxMenu.DataSource = menuBindingSource;
            listBoxMenu.DisplayMember = "MenuName";

            dataGridViewMenu.DataSource = menuBindingSource;
            ClearInput();
        }

        public void ClearInput()
        {
            textBoxMenuName.Text = string.Empty;
            checkBoxLevelSpicy.Checked = false;
            comboBoxFoodType.SelectedItem = null;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = this.listBoxMenu.SelectedItem as MenuModel;

            if (selectedItem == null)
            {
                labelValidation.Text = "Can't find selected item";
                return;
            }

            Menus.Remove(selectedItem);
            var menuBindingSource = new BindingSource();
            foreach (var menu in Menus)
            {
                menuBindingSource.Add(menu);
            }

            listBoxMenu.DataSource = menuBindingSource;
            listBoxMenu.DisplayMember = "MenuName";

            dataGridViewMenu.DataSource = menuBindingSource;
            ClearInput();
        }
    }
}
