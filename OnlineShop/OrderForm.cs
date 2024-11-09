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
        public delegate void LoadData();
        public event LoadData LoadDataEvent;
        public event LoadData ResetFormEvent;
        List<Categories> categories;
        List<Product> products;
        bool selectedIsAvailable = false;
        String newProductName = string.Empty;
        Categories selectedCategory;
        int newQuantity = 0;
        public OrderForm()
        {
            InitializeComponent();
            LoadDataEvent += FillDataInDataGridView;
            ResetFormEvent += ResetForm;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            categories = new List<Categories>();
            products = new List<Product>();

            string jsonDataCategoriesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Categories.json");
            if (File.Exists(jsonDataCategoriesFilePath))
            {
                string jsonCategoryStr = File.ReadAllText(jsonDataCategoriesFilePath);
                categories = JsonConvert.DeserializeObject<List<Categories>>(jsonCategoryStr);
            }
            categorycomboBox.DataSource = categories;
            categorycomboBox.DisplayMember = "Name";
            categorycomboBox.ValueMember = "Id";

            string jsonDataProductFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Products.json");
            if (File.Exists(jsonDataProductFilePath))
            {
                string jsonProductStr = File.ReadAllText(jsonDataProductFilePath);
                products = JsonConvert.DeserializeObject<List<Product>>(jsonProductStr);
            }
            LoadDataEvent.Invoke();
        }
        private void FillDataInDataGridView()
        {
            //productDataGridView.DataSource = null;
            //productDataGridView.DataSource = products;
            //productDataGridView.Refresh();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetFormEvent.Invoke();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!CheckDataInForm())
                return;
            AddProduct addProduct = new AddProduct
            {
                ProductName = newProductName,
                CategoryName = selectedCategory.Name,
                Quantity = newQuantity,
                IsAvailable = selectedIsAvailable
            };
            AddProduct(addProduct);
            ResetFormEvent.Invoke();
        }
            
        private void AddProduct(AddProduct addProduct)
        {
            Product newproduct = new Product(productName: addProduct.ProductName, quantity: addProduct.Quantity, categoryName: addProduct.CategoryName, isAvailable: addProduct.IsAvailable);
            products.Add(newproduct);
            Console.WriteLine(products);
            MessageBox.Show($"{addProduct.ProductName} add to list");
        }
        private bool CheckDataInForm()
        {
            if (categorycomboBox.SelectedItem != null)
            {
               selectedCategory = (Categories)categorycomboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("هیچ دسته‌بندی انتخاب نشده است.");
                return false;
            }

            if (string.IsNullOrEmpty(productNameTextBox.Text))
            {
                MessageBox.Show("لطفا نام محصول را وارد کنید");
                return false;
            }
            else
            {
                newProductName = productNameTextBox.Text.ToLower();
            }

            if (!int.TryParse(quantityTextBox.Text, out newQuantity) || string.IsNullOrEmpty(quantityTextBox.Text))
            {
                    MessageBox.Show("تعداد وارد شده صحیح نمیباشد.");
                return false;
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
                return false;
            }
            return true;
        }
        private void ResetForm()
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
