using System;
using OnlineShop.Enums;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using OnlineShop.Utility;

namespace OnlineShop
{
    public partial class OrderForm : Form
    {
        List<Categories> categories;
        List<Product> products;
        bool selectedIsAvailable = false;
        String newProductName = string.Empty;
        Categories selectedCategory;
        int newQuantity = 0;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            categories = new List<Categories>();
            products = new List<Product>();
            string jsonDataCategoriesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Categories.json");
            //string jsonDataProductFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Products.json");
            if (File.Exists(jsonDataCategoriesFilePath))
            {
                string jsonDataStr = File.ReadAllText(jsonDataCategoriesFilePath);
                categories = JsonConvert.DeserializeObject<List<Categories>>(jsonDataStr);
            }
            categorycomboBox.DataSource = categories;
            categorycomboBox.DisplayMember = "Name";
            categorycomboBox.ValueMember = "Id";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CheckDataInForm();
            AddProduct addProduct = new AddProduct
            {
                ProductName = newProductName,
                Category = selectedCategory,
                Quantity = newQuantity,
                IsAvailable = selectedIsAvailable
            };
            AddProduct(addProduct);
            resetForm();
        }
            
        private void AddProduct(AddProduct addProduct)
        {
            Product newproduct = new Product(productName: addProduct.ProductName, quantity: addProduct.Quantity, category: addProduct.Category, isAvailable: addProduct.IsAvailable);
            products.Add(newproduct);
            MessageBox.Show($"{addProduct.ProductName} add to list");
        }
        private void CheckDataInForm()
        {
            if (categorycomboBox.SelectedItem != null)
            {
               selectedCategory = (Categories)categorycomboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("هیچ دسته‌بندی انتخاب نشده است.");
                return;
            }

            if (string.IsNullOrEmpty(productNameTextBox.Text))
            {
                MessageBox.Show("لطفا نام محصول را وارد کنید");
                return;
            }
            else
            {
                newProductName = productNameTextBox.Text.ToLower();
            }

            if (!int.TryParse(quantityTextBox.Text, out newQuantity) && string.IsNullOrEmpty(quantityTextBox.Text))
            {
                    MessageBox.Show("تعداد وارد شده صحیح نمیباشد.");
                return;
            }
           
            if (availableRadioButton.Checked)
            {
                selectedIsAvailable = true;
            }
            else if (unavailableRadioButton.Checked)
            {
                selectedIsAvailable = true;
            }
            else
            {
                MessageBox.Show("هیچ گزینه‌ای انتخاب نشده است");
                return;
            }
        }
        private void resetForm()
        {
            productNameTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            categorycomboBox.SelectedIndex = 0;
            availableRadioButton.Checked = false;
            unavailableRadioButton.Checked = false;
        }


        //private void FillComboBox()
        //{
        //    List<string> descriptions = new List<string>();

        //    foreach (Status status in Enum.GetValues(typeof(Status)))
        //    {
        //        descriptions.Add(GetEnumDescription(status));
        //    }

        //    categorycomboBox.DataSource = descriptions;
        //}
        //public static string GetEnumDescription(Enum value)
        //{
        //    var field = value.GetType().GetField(value.ToString());
        //    var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
        //    return attribute != null ? attribute.Description : value.ToString();
        //}
    }
}
