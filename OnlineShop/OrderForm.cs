using System;
using OnlineShop.Enums;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using OnlineShop.Utility;
using OnlineShop.Businessees;
using System.Linq;

namespace OnlineShop
{
    public partial class OrderForm : Form
    {
        private readonly ProductBusinesse _productBusinesse;
        private readonly CategoryBusiness _categoryBusiness;
        public delegate void LoadData(List<Product>products);
        public delegate void ResetForm();
        public event LoadData LoadDataEvent;
        public event ResetForm ResetFormEvent;
        List<Categories> categories;
        List<Product> products;
        bool selectedIsAvailable = false;
        String newProductName = string.Empty;
        Product SelectedProduct;
        Categories selectedCategory;
        int newQuantity = 0;
        public OrderForm()
        {
            InitializeComponent();
            LoadDataEvent += FillDataInDataGridView;
            _productBusinesse = new ProductBusinesse();
            _categoryBusiness = new CategoryBusiness();
            categories = _categoryBusiness.GetCategoriess();
            ResetFormEvent += ResetForms;
            products = _productBusinesse.GetAll();
            LoadDataEvent.Invoke(products);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //categories = new List<Categories>();
            //products = new List<Product>();

            //string jsonDataCategoriesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Categories.json");
            //if (File.Exists(jsonDataCategoriesFilePath))
            //{
            //    string jsonCategoryStr = File.ReadAllText(jsonDataCategoriesFilePath);
            //    categories = JsonConvert.DeserializeObject<List<Categories>>(jsonCategoryStr);
            //}
            categorycomboBox.DataSource = categories;
            categorycomboBox.DisplayMember = "Description";
            categorycomboBox.ValueMember = "Id";

            //string jsonDataProductFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Products.json");
            //if (File.Exists(jsonDataProductFilePath))
            //{
            //    string jsonProductStr = File.ReadAllText(jsonDataProductFilePath);
            //    products = JsonConvert.DeserializeObject<List<Product>>(jsonProductStr);
            //}

        }
        private void FillDataInDataGridView(List<Product>products)
        {
            products = _productBusinesse.GetAll();
            productDataGridView.DataSource = null;
            productDataGridView.DataSource = products;
            productDataGridView.Refresh();
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
                CategoryId = selectedCategory.Id,
                Quantity = newQuantity,
                IsAvailable = selectedIsAvailable
            };
            AddProduct(addProduct);
            products = _productBusinesse.GetAll();
            LoadDataEvent.Invoke(products);
        }
            
        private void AddProduct(AddProduct addProduct)
        {
            Product newproduct = new Product(productName: addProduct.ProductName, quantity: addProduct.Quantity, categoryId: addProduct.CategoryId, isAvailable: addProduct.IsAvailable);
            //products.Add(newproduct);
            _productBusinesse.Add(newproduct);
            Console.WriteLine(products);
            // MessageBox.Show($"{addProduct.ProductName} add to list");
            products = _productBusinesse.GetAll();
            LoadDataEvent.Invoke(products);
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
                selectedIsAvailable = false;
            }
            else
            {
                MessageBox.Show("هیچ گزینه‌ای انتخاب نشده است");
                return false;
            }
            return true;
        }
        private void ResetForms()
        {
            productNameTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            categorycomboBox.SelectedIndex = 0;
            availableRadioButton.Checked = false;
            unavailableRadioButton.Checked = false;
        }
        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                var selectedRow = productDataGridView.Rows[e.RowIndex];
                var id = (int)selectedRow.Cells["Id"].Value;
                SelectedProduct = products.Where(p => p.Id == id).FirstOrDefault();

                productNameTextBox.Text = SelectedProduct.ProductName;
                quantityTextBox.Text = SelectedProduct.Quantity.ToString();

                int selectedCategoryId = (int)selectedRow.Cells["CategoryId"].Value;
                categorycomboBox.SelectedValue = selectedCategoryId;
                selectedCategory = categorycomboBox.Items.Cast<Categories>().FirstOrDefault(c => c.Id == selectedCategoryId);

                if(SelectedProduct.IsAvailable)
                {
                    availableRadioButton.Checked = true;
                }
                else
                {
                    unavailableRadioButton.Checked = true ;
                }
                
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (SelectedProduct is null)
            {
                MessageBox.Show("شما محصولی را جهت به حذف انتخاب نکرده اید!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این محصول را حذف کنید؟","تایید حذف",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                _productBusinesse.Delete(Id: SelectedProduct.Id);
                products = _productBusinesse.GetAll();
                LoadDataEvent.Invoke(products);
                ResetFormEvent.Invoke();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (SelectedProduct is null)
            {
                MessageBox.Show("شما محصولی را جهت ویرایش اطلاعات انتخاب نکرده اید!");
                return;
            }

            CheckDataInForm();
            Product product = new Product()
            {
                ProductName = newProductName,
                CategoryId = selectedCategory.Id,
                Quantity = newQuantity,
                IsAvailable = selectedIsAvailable,
                Id = SelectedProduct.Id
            };
            _productBusinesse.Update(product);
            products = _productBusinesse.GetAll();
            LoadDataEvent.Invoke(products);
            ResetForms();
        }
    }
}
