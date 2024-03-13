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
            dataGridViewMenu = new DataGridView();
            labelMenu = new Label();
            textBoxMenuName = new TextBox();
            tableLayoutPanelInsert = new TableLayoutPanel();
            buttonAddMenu = new Button();
            editButton = new Button();
            labelLevelSpicy = new Label();
            checkBoxLevelSpicy = new CheckBox();
            labelValidation = new Label();
            buttonClear = new Button();
            labelFoodType = new Label();
            comboBoxFoodType = new ComboBox();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            tableLayoutPanelInsert.SuspendLayout();
            SuspendLayout();
            // 
            // restaurantLabel
            // 
            restaurantLabel.AutoSize = true;
            restaurantLabel.ForeColor = SystemColors.ActiveCaptionText;
            restaurantLabel.Location = new Point(37, 32);
            restaurantLabel.Name = "restaurantLabel";
            restaurantLabel.Size = new Size(119, 20);
            restaurantLabel.TabIndex = 0;
            restaurantLabel.Text = "Label Restaurant";
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.Location = new Point(37, 89);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(150, 104);
            listBoxMenu.TabIndex = 1;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(37, 240);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 51;
            dataGridViewMenu.Size = new Size(300, 188);
            dataGridViewMenu.TabIndex = 2;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Location = new Point(3, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(90, 20);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "Menu Name";
            // 
            // textBoxMenuName
            // 
            textBoxMenuName.Location = new Point(99, 3);
            textBoxMenuName.Name = "textBoxMenuName";
            textBoxMenuName.Size = new Size(180, 27);
            textBoxMenuName.TabIndex = 1;
            // 
            // tableLayoutPanelInsert
            // 
            tableLayoutPanelInsert.ColumnCount = 5;
            tableLayoutPanelInsert.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInsert.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInsert.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInsert.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInsert.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelInsert.Controls.Add(textBoxMenuName, 1, 0);
            tableLayoutPanelInsert.Controls.Add(labelMenu, 0, 0);
            tableLayoutPanelInsert.Controls.Add(buttonAddMenu, 1, 3);
            tableLayoutPanelInsert.Controls.Add(editButton, 2, 3);
            tableLayoutPanelInsert.Controls.Add(labelLevelSpicy, 0, 1);
            tableLayoutPanelInsert.Controls.Add(checkBoxLevelSpicy, 1, 1);
            tableLayoutPanelInsert.Controls.Add(labelValidation, 0, 3);
            tableLayoutPanelInsert.Controls.Add(buttonClear, 3, 3);
            tableLayoutPanelInsert.Controls.Add(labelFoodType, 0, 2);
            tableLayoutPanelInsert.Controls.Add(comboBoxFoodType, 1, 2);
            tableLayoutPanelInsert.Controls.Add(buttonDelete, 4, 3);
            tableLayoutPanelInsert.Location = new Point(371, 89);
            tableLayoutPanelInsert.Name = "tableLayoutPanelInsert";
            tableLayoutPanelInsert.RowCount = 4;
            tableLayoutPanelInsert.RowStyles.Add(new RowStyle());
            tableLayoutPanelInsert.RowStyles.Add(new RowStyle());
            tableLayoutPanelInsert.RowStyles.Add(new RowStyle());
            tableLayoutPanelInsert.RowStyles.Add(new RowStyle());
            tableLayoutPanelInsert.Size = new Size(545, 198);
            tableLayoutPanelInsert.TabIndex = 3;
            // 
            // buttonAddMenu
            // 
            buttonAddMenu.Location = new Point(99, 100);
            buttonAddMenu.Name = "buttonAddMenu";
            buttonAddMenu.Size = new Size(94, 29);
            buttonAddMenu.TabIndex = 2;
            buttonAddMenu.Text = "Add";
            buttonAddMenu.UseVisualStyleBackColor = true;
            buttonAddMenu.Click += buttonAddMenu_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(285, 100);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // labelLevelSpicy
            // 
            labelLevelSpicy.AutoSize = true;
            labelLevelSpicy.Location = new Point(3, 33);
            labelLevelSpicy.Name = "labelLevelSpicy";
            labelLevelSpicy.Size = new Size(58, 20);
            labelLevelSpicy.TabIndex = 5;
            labelLevelSpicy.Text = "Is Spicy";
            // 
            // checkBoxLevelSpicy
            // 
            checkBoxLevelSpicy.AutoSize = true;
            checkBoxLevelSpicy.Location = new Point(99, 36);
            checkBoxLevelSpicy.Name = "checkBoxLevelSpicy";
            checkBoxLevelSpicy.Size = new Size(52, 24);
            checkBoxLevelSpicy.TabIndex = 6;
            checkBoxLevelSpicy.Text = "Yes";
            checkBoxLevelSpicy.UseVisualStyleBackColor = true;
            // 
            // labelValidation
            // 
            labelValidation.AutoSize = true;
            labelValidation.Location = new Point(3, 97);
            labelValidation.Name = "labelValidation";
            labelValidation.Size = new Size(0, 20);
            labelValidation.TabIndex = 7;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(385, 100);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(56, 29);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelFoodType
            // 
            labelFoodType.AutoSize = true;
            labelFoodType.Location = new Point(3, 63);
            labelFoodType.Name = "labelFoodType";
            labelFoodType.Size = new Size(78, 20);
            labelFoodType.TabIndex = 9;
            labelFoodType.Text = "Food Type";
            // 
            // comboBoxFoodType
            // 
            comboBoxFoodType.FormattingEnabled = true;
            comboBoxFoodType.Location = new Point(99, 66);
            comboBoxFoodType.Name = "comboBoxFoodType";
            comboBoxFoodType.Size = new Size(151, 28);
            comboBoxFoodType.TabIndex = 10;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(447, 100);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(tableLayoutPanelInsert);
            Controls.Add(dataGridViewMenu);
            Controls.Add(listBoxMenu);
            Controls.Add(restaurantLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            tableLayoutPanelInsert.ResumeLayout(false);
            tableLayoutPanelInsert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label restaurantLabel;
        private ListBox listBoxMenu;
        private DataGridView dataGridViewMenu;
        private Label labelMenu;
        private TextBox textBoxMenuName;
        private TableLayoutPanel tableLayoutPanelInsert;
        private Button buttonAddMenu;
        private Button editButton;
        private Label labelLevelSpicy;
        private CheckBox checkBoxLevelSpicy;
        private Label labelValidation;
        private Button buttonClear;
        private Label labelFoodType;
        private ComboBox comboBoxFoodType;
        private Button buttonDelete;
    }
}
