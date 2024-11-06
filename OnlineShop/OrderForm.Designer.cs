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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.orderRegisterButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.unavailableRadioButton = new System.Windows.Forms.RadioButton();
            this.availableRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.categorycomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.orderRegisterButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.productNameTextBox);
            this.groupBox2.Controls.Add(this.quantityLabel);
            this.groupBox2.Controls.Add(this.categoryLabel);
            this.groupBox2.Controls.Add(this.productNameLabel);
            this.groupBox2.Controls.Add(this.categorycomboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(670, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سفارش محصول";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Thistle;
            this.resetButton.Location = new System.Drawing.Point(341, 133);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(113, 41);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "پاک کردن فرم";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.editButton.Location = new System.Drawing.Point(460, 133);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(97, 41);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "ویرایش";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.Location = new System.Drawing.Point(563, 133);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 41);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // orderRegisterButton
            // 
            this.orderRegisterButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.orderRegisterButton.Location = new System.Drawing.Point(21, 191);
            this.orderRegisterButton.Name = "orderRegisterButton";
            this.orderRegisterButton.Size = new System.Drawing.Size(202, 56);
            this.orderRegisterButton.TabIndex = 13;
            this.orderRegisterButton.Text = "ثبت سفارش";
            this.orderRegisterButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addButton.Location = new System.Drawing.Point(21, 133);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(202, 41);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "اضافه به لیست";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.unavailableRadioButton);
            this.panel2.Controls.Add(this.availableRadioButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 32);
            this.panel2.TabIndex = 7;
            // 
            // unavailableRadioButton
            // 
            this.unavailableRadioButton.AutoSize = true;
            this.unavailableRadioButton.Location = new System.Drawing.Point(16, 4);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "label4";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(229, 79);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 18);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "وضعیت :";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(341, 76);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(202, 26);
            this.quantityTextBox.TabIndex = 5;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(21, 33);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(202, 26);
            this.productNameTextBox.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(549, 79);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 18);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "تعداد  :";
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
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(229, 36);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(88, 18);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "نام محصول :";
            // 
            // categorycomboBox
            // 
            this.categorycomboBox.FormattingEnabled = true;
            this.categorycomboBox.Location = new System.Drawing.Point(341, 33);
            this.categorycomboBox.Name = "categorycomboBox";
            this.categorycomboBox.Size = new System.Drawing.Size(202, 26);
            this.categorycomboBox.TabIndex = 3;
            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(689, 499);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "OrderForm";
            this.RightToLeftLayout = true;
            this.Text = "فرم سفارش";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton unavailableRadioButton;
        private System.Windows.Forms.RadioButton availableRadioButton;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button orderRegisterButton;
        private System.Windows.Forms.Button deleteButton;
    }
}