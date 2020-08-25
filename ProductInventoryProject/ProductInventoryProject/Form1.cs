using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProductInventoryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Inventory Manager";
        }

        Control GetControl(string name)
        {
            Control[] controls = Form.ActiveForm.Controls.Find(name, true);
            //Control[] controls = this.Controls.Find(name, true);
            if (controls.Length == 0)
                return null;
            else
                return controls[0];
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            ((Control)sender).Parent.Hide();
            GetControl("addItemPanel").Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Control parentPanel = ((Control)sender).Parent;

            string name = parentPanel.Controls[1].Text;
            decimal price;
            bool isPriceValid = decimal.TryParse(parentPanel.Controls[3].Text, out price);
            int quantity;
            bool isQuantityValid = int.TryParse(parentPanel.Controls[5].Text, out quantity);

            GetControl("priceInvalid").Hide();
            GetControl("quantityInvalid").Hide();
            if (!isPriceValid || !isQuantityValid)
            {
                if (!isPriceValid)
                    GetControl("priceInvalid").Show();
                if (!isQuantityValid)
                    GetControl("quantityInvalid").Show();
                return;
            }

            Item item = new Item(name, price, quantity);
            Inventory.AddItemToInventory(item);

            parentPanel.Hide();
            GetControl("panel1").Show();
        }

        private void showInventoryBtn_Click(object sender, EventArgs e)
        {
            ((Control)sender).Parent.Hide();
            GetControl("showInventoryPanel").Show();
            FillListBox();
        }
        void FillListBox()
        {
            GroupBox infoGroupBox = (GroupBox)GetControl("infoGroupbox");
            for (int i = 0; i < 4; i++)
                infoGroupBox.Controls[i].Text = "";
            GetControl("editItemBtn").Enabled = false;

            //fill the list box with inventory items
            ListBox inventoryListBox = (ListBox)GetControl("inventoryListBox");
            inventoryListBox.Items.Clear();

            foreach (Item item in Inventory.items)
            {
                inventoryListBox.Items.Add(item);
            }

            inventoryListBox.DisplayMember = "Name";
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = (Item)inventoryListBox.SelectedItem;
            GroupBox infoGroupBox = (GroupBox)GetControl("infoGroupbox");
            if (item != null)
            {
                infoGroupBox.Controls[0].Text = item.Name;
                infoGroupBox.Controls[1].Text = "$" + item.Price.ToString();
                infoGroupBox.Controls[2].Text = item.Quantity.ToString();
                infoGroupBox.Controls[3].Text = "$" + item.TotalValue.ToString();
                GetControl("editItemBtn").Enabled = true;
            }
        }

        private void backToPanel1Btn_Click(object sender, EventArgs e)
        {
            GroupBox infoGroupBox = (GroupBox)GetControl("infoGroupbox");
            for (int i = 0; i < 4; i++)
                infoGroupBox.Controls[i].Text = "";
            GetControl("editItemBtn").Enabled = false;

            ((Control)sender).Parent.Hide();
            GetControl("panel1").Show();
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            ((Control)sender).Parent.Parent.Hide();
            Control editItemPanel = GetControl("editItemPanel");
            editItemPanel.Show();

            ListBox listBox = (ListBox)GetControl("inventoryListBox");
            Item item = (Item)listBox.SelectedItem;

            foreach (Control control in editItemPanel.Controls[0].Controls)
            {
                if (control.Name == "editNameTextBox")
                    control.Text = item.Name;
                if (control.Name == "editPriceTextBox")
                    control.Text = item.Price.ToString();
                if (control.Name == "editQuantityTextBox")
                    control.Text = item.Quantity.ToString();
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)GetControl("inventoryListBox");
            Item item = (Item)listBox.SelectedItem;
            DialogResult confirmResult = MessageBox.Show("Are you sure to edit this item?", "Confirm edit", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                foreach (Control control in editItemPanel.Controls[0].Controls)
                {
                    if (control.Name == "editNameTextBox")
                        item.Name = control.Text;
                    if (control.Name == "editPriceTextBox")
                        item.Price = Convert.ToDecimal(control.Text);
                    if (control.Name == "editQuantityTextBox")
                        item.Quantity = Convert.ToInt32(control.Text);
                }

                InvoFileTools.SaveCurrentFile();
                GetControl("showInventoryPanel").Show();
                GetControl("editItemPanel").Hide();
                FillListBox();
            }
        }

        private void editBackBtn_Click(object sender, EventArgs e)
        {
            GetControl("showInventoryPanel").Show();
            GetControl("editItemPanel").Hide();
            FillListBox();
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)GetControl("inventoryListBox");
            Item item = (Item)listBox.SelectedItem;
            DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool result = Inventory.RemoveItemFromInventory(item);
                if (!result)
                    MessageBox.Show("Item can't be deleted");
            }
            
            GetControl("showInventoryPanel").Show();
            GetControl("editItemPanel").Hide();
            FillListBox();
        }

        private void createNewFileBtn_Click(object sender, EventArgs e)
        {
            InvoFileTools.SaveNewFile(GetControl("fileToName").Text);
            //Close create window
            Form.ActiveForm.Close();

            //Should be main window
            foreach (Control control in Form.ActiveForm.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    control.Hide();
                }
            }
            Inventory.UnloadInventory();
            GetControl("panel1").Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new form to name and create file
            Form newFileForm = new Form();
            newFileForm.Text = "New Inventory";
            
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 17);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name of inventory:";
            nameLabel.TextAlign = ContentAlignment.TopRight;

            TextBox fileToName = new TextBox();
            fileToName.Location = new Point(110, 10);
            fileToName.Name = "fileToName";
            fileToName.Size = new Size(170, 22);

            Button createNewFileBtn = new Button();
            createNewFileBtn.Location = new Point(10, 80);
            createNewFileBtn.Name = "createNewFileBtn";
            createNewFileBtn.Size = new Size(75, 23);
            createNewFileBtn.TabIndex = 6;
            createNewFileBtn.Text = "Create";
            createNewFileBtn.UseVisualStyleBackColor = true;
            createNewFileBtn.Click += new EventHandler(createNewFileBtn_Click);

            newFileForm.Controls.Add(nameLabel);
            newFileForm.Controls.Add(fileToName);
            newFileForm.Controls.Add(createNewFileBtn);
            newFileForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new form to name and create file
            Form newFileForm = new Form();
            newFileForm.Text = "Open Inventory";

            //Get all invo files in folder
            string filePath = Directory.GetCurrentDirectory();
            Console.WriteLine(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            FileInfo[] files = directoryInfo.GetFiles();
            int fileCount = 0;
            foreach (FileInfo file in files)
            {
                //Create object in panel
                if (file.Extension == ".invo")
                {
                    fileCount++;
                    Button openInvoBtn = new Button();
                    openInvoBtn.Location = new Point(10, 10);
                    openInvoBtn.Name = "invoFile" + fileCount;
                    openInvoBtn.Size = new Size(150, 50);
                    openInvoBtn.TabIndex = fileCount;
                    openInvoBtn.Text = file.Name.Split('.')[0];//this gets the name of the file without the extension
                    openInvoBtn.UseVisualStyleBackColor = true;
                    openInvoBtn.Click += new EventHandler(openInvoBtn_Click);
                    newFileForm.Controls.Add(openInvoBtn);
                }
            }
            newFileForm.Show();
        }

        private void openInvoBtn_Click(object sender, EventArgs e)
        {
            //Close the open invo window
            Form.ActiveForm.Close();

            string invoSelected = ((Button)sender).Text;
            bool result = Inventory.LoadInventoryFromFile(invoSelected);
            if (!result)
            {
                MessageBox.Show("Unable to load file");
                return;
            }
            foreach (Control control in Form.ActiveForm.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    control.Hide();
                }
            }
            GetControl("panel1").Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
