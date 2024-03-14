namespace RestaurantWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            restaurantLabel = new Label();
            listBoxMenu = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelMenuName = new Label();
            textBoxMenuName = new TextBox();
            labelFoodTheme = new Label();
            textBoxFoodTheme = new TextBox();
            labelIsAvailable = new Label();
            checkBoxAvailable = new CheckBox();
            labelRestaurant = new Label();
            comboBoxRestaurant = new ComboBox();
            buttonAddMenu = new Button();
            labelNotification = new Label();
            buttonEdit = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // restaurantLabel
            // 
            restaurantLabel.AutoSize = true;
            restaurantLabel.ForeColor = SystemColors.ActiveCaptionText;
            restaurantLabel.Location = new Point(37, 32);
            restaurantLabel.Name = "restaurantLabel";
            restaurantLabel.Size = new Size(134, 20);
            restaurantLabel.TabIndex = 0;
            restaurantLabel.Text = "Accelist Restaurant";
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.Location = new Point(37, 89);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(223, 244);
            listBoxMenu.TabIndex = 1;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelMenuName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxMenuName, 1, 0);
            tableLayoutPanel1.Controls.Add(labelFoodTheme, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxFoodTheme, 1, 1);
            tableLayoutPanel1.Controls.Add(labelIsAvailable, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBoxAvailable, 1, 3);
            tableLayoutPanel1.Controls.Add(labelRestaurant, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBoxRestaurant, 1, 2);
            tableLayoutPanel1.Location = new Point(345, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(427, 244);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Location = new Point(3, 0);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(90, 20);
            labelMenuName.TabIndex = 0;
            labelMenuName.Text = "Menu Name";
            // 
            // textBoxMenuName
            // 
            textBoxMenuName.Location = new Point(132, 3);
            textBoxMenuName.Name = "textBoxMenuName";
            textBoxMenuName.Size = new Size(119, 27);
            textBoxMenuName.TabIndex = 1;
            // 
            // labelFoodTheme
            // 
            labelFoodTheme.AutoSize = true;
            labelFoodTheme.Location = new Point(3, 33);
            labelFoodTheme.Name = "labelFoodTheme";
            labelFoodTheme.Size = new Size(92, 20);
            labelFoodTheme.TabIndex = 2;
            labelFoodTheme.Text = "Food Theme";
            // 
            // textBoxFoodTheme
            // 
            textBoxFoodTheme.Location = new Point(132, 36);
            textBoxFoodTheme.Name = "textBoxFoodTheme";
            textBoxFoodTheme.Size = new Size(119, 27);
            textBoxFoodTheme.TabIndex = 3;
            // 
            // labelIsAvailable
            // 
            labelIsAvailable.AutoSize = true;
            labelIsAvailable.Location = new Point(3, 100);
            labelIsAvailable.Name = "labelIsAvailable";
            labelIsAvailable.Size = new Size(85, 20);
            labelIsAvailable.TabIndex = 4;
            labelIsAvailable.Text = "Is Available";
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(132, 103);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(93, 24);
            checkBoxAvailable.TabIndex = 5;
            checkBoxAvailable.Text = "Available";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // labelRestaurant
            // 
            labelRestaurant.AutoSize = true;
            labelRestaurant.Location = new Point(3, 66);
            labelRestaurant.Name = "labelRestaurant";
            labelRestaurant.Size = new Size(123, 20);
            labelRestaurant.TabIndex = 6;
            labelRestaurant.Text = "Restaurant Name";
            // 
            // comboBoxRestaurant
            // 
            comboBoxRestaurant.FormattingEnabled = true;
            comboBoxRestaurant.Location = new Point(132, 69);
            comboBoxRestaurant.Name = "comboBoxRestaurant";
            comboBoxRestaurant.Size = new Size(151, 28);
            comboBoxRestaurant.TabIndex = 7;
            // 
            // buttonAddMenu
            // 
            buttonAddMenu.Location = new Point(377, 366);
            buttonAddMenu.Name = "buttonAddMenu";
            buttonAddMenu.Size = new Size(94, 29);
            buttonAddMenu.TabIndex = 3;
            buttonAddMenu.Text = "Add Menu";
            buttonAddMenu.UseVisualStyleBackColor = true;
            buttonAddMenu.Click += buttonAddMenu_Click;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(664, 350);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(88, 20);
            labelNotification.TabIndex = 4;
            labelNotification.Text = "Notification";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(502, 366);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit Menu";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(377, 418);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear Form";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(515, 422);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete Menu";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonEdit);
            Controls.Add(labelNotification);
            Controls.Add(buttonAddMenu);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listBoxMenu);
            Controls.Add(restaurantLabel);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label restaurantLabel;
        private ListBox listBoxMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelMenuName;
        private TextBox textBoxMenuName;
        private Label labelFoodTheme;
        private TextBox textBoxFoodTheme;
        private Label labelIsAvailable;
        private CheckBox checkBoxAvailable;
        private Button buttonAddMenu;
        private Label labelNotification;
        private Button buttonEdit;
        private Label labelRestaurant;
        private ComboBox comboBoxRestaurant;
        private Button buttonClear;
        private Button buttonDelete;
    }
}
