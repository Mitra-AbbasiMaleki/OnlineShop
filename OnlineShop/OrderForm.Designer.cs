namespace OnlineShop
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.unavailableRadioButton = new System.Windows.Forms.RadioButton();
            this.availableRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categorycomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.orderGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productDataGridView.ColumnHeadersHeight = 40;
            this.productDataGridView.Location = new System.Drawing.Point(12, 220);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(670, 278);
            this.productDataGridView.TabIndex = 0;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.resetButton);
            this.orderGroupBox.Controls.Add(this.editButton);
            this.orderGroupBox.Controls.Add(this.deleteButton);
            this.orderGroupBox.Controls.Add(this.productNameLabel);
            this.orderGroupBox.Controls.Add(this.productNameTextBox);
            this.orderGroupBox.Controls.Add(this.quantityLabel);
            this.orderGroupBox.Controls.Add(this.quantityTextBox);
            this.orderGroupBox.Controls.Add(this.statusLabel);
            this.orderGroupBox.Controls.Add(this.panel2);
            this.orderGroupBox.Controls.Add(this.addButton);
            this.orderGroupBox.Controls.Add(this.categoryLabel);
            this.orderGroupBox.Controls.Add(this.categorycomboBox);
            this.orderGroupBox.Location = new System.Drawing.Point(12, 3);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderGroupBox.Size = new System.Drawing.Size(670, 211);
            this.orderGroupBox.TabIndex = 0;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "سفارش محصول";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Thistle;
            this.resetButton.Location = new System.Drawing.Point(12, 165);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(242, 40);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "پاک کردن فرم";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.editButton.Location = new System.Drawing.Point(12, 119);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(242, 40);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "ویرایش";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.Location = new System.Drawing.Point(12, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(242, 40);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(549, 76);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(88, 18);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "نام محصول :";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(302, 73);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(241, 26);
            this.productNameTextBox.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(549, 122);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 18);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "تعداد  :";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(302, 119);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(241, 26);
            this.quantityTextBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(549, 160);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 18);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "وضعیت :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.unavailableRadioButton);
            this.panel2.Controls.Add(this.availableRadioButton);
            this.panel2.Location = new System.Drawing.Point(302, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 32);
            this.panel2.TabIndex = 7;
            // 
            // unavailableRadioButton
            // 
            this.unavailableRadioButton.AutoSize = true;
            this.unavailableRadioButton.Location = new System.Drawing.Point(17, 5);
            this.unavailableRadioButton.Name = "unavailableRadioButton";
            this.unavailableRadioButton.Size = new System.Drawing.Size(73, 22);
            this.unavailableRadioButton.TabIndex = 8;
            this.unavailableRadioButton.TabStop = true;
            this.unavailableRadioButton.Text = "ناموجود";
            this.unavailableRadioButton.UseVisualStyleBackColor = true;
            // 
            // availableRadioButton
            // 
            this.availableRadioButton.AutoSize = true;
            this.availableRadioButton.Location = new System.Drawing.Point(128, 5);
            this.availableRadioButton.Name = "availableRadioButton";
            this.availableRadioButton.Size = new System.Drawing.Size(65, 22);
            this.availableRadioButton.TabIndex = 7;
            this.availableRadioButton.TabStop = true;
            this.availableRadioButton.Text = "موجود";
            this.availableRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addButton.Location = new System.Drawing.Point(12, 22);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(242, 45);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "اضافه";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(549, 36);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(97, 18);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "گروه محصول :";
            // 
            // categorycomboBox
            // 
            this.categorycomboBox.FormattingEnabled = true;
            this.categorycomboBox.Location = new System.Drawing.Point(302, 33);
            this.categorycomboBox.Name = "categorycomboBox";
            this.categorycomboBox.Size = new System.Drawing.Size(241, 26);
            this.categorycomboBox.TabIndex = 3;
            this.categorycomboBox.SelectedIndexChanged += new System.EventHandler(this.categorycomboBox_SelectedIndexChanged);
            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(689, 504);
            this.Controls.Add(this.orderGroupBox);
            this.Controls.Add(this.productDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "OrderForm";
            this.RightToLeftLayout = true;
            this.Text = "فرم سفارش";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton unavailableRadioButton;
        private System.Windows.Forms.RadioButton availableRadioButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.ComboBox categorycomboBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView productDataGridView;
    }
}