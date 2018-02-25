using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace TaskProject1
{
    public partial class Form1 : Form
    {
        public string selectedFood;     // Current selected food e.g. Margheritta, Kawa etc.
        public int totalPrice;          // Total price of all selected dishes
        public List<string> orderList;  // List of selected main dishes
        public List<string> addons;     // List of add-ons for selected dishes
        public int orderID = 0;         // Order's number

        public int foodCount;           // Order multiplier

        public Form1()
        {
            orderList = new List<string>(); // Initialization of main food list
            addons = new List<string>();    // Initialization of add-ons list
            InitializeComponent();          
        }

        private void addButton_Click(object sender, EventArgs e)    // Function for "Dodaj" button, which adds selected dishes to the list and prints them out to special TextBox
        {
            foodCount = Convert.ToInt32(foodCounter.Value);

            addons.AddRange(pizzaListBox.CheckedItems.Cast<string>());
            addons.AddRange(daniaListBox.CheckedItems.Cast<string>());

            for (int i = 0; i < foodCount; i++) 
            {
                switch (selectedFood)
                {
                    case "Margheritta - 20 zł":
                        totalPrice += 20;
                        orderList.Add(selectedFood);
                        break;
                    case "Vegetariana - 22 zł":
                        totalPrice += 22;
                        orderList.Add(selectedFood);
                        break;
                    case "Tosca - 25 zł":
                        totalPrice += 25;
                        orderList.Add(selectedFood);
                        break;
                    case "Venecia - 25 zł":
                        totalPrice += 25;
                        orderList.Add(selectedFood);
                        break;
                    case "Schabowy z frytkami - 30 zł":
                        totalPrice += 30;
                        orderList.Add(selectedFood);
                        break;
                    case "Ryba z frytkami - 28 zł":
                        totalPrice += 28;
                        orderList.Add(selectedFood);
                        break;
                    case "Placek po więgiersku - 27 zł":
                        totalPrice += 27;
                        orderList.Add(selectedFood);
                        break;
                    case "Pomidorowa - 12 zł":
                        totalPrice += 12;
                        orderList.Add(selectedFood);
                        break;
                    case "Rosół - 10 zł":
                        totalPrice += 10;
                        orderList.Add(selectedFood);
                        break;
                    case "Kawa - 5 zł":
                        totalPrice += 5;
                        orderList.Add(selectedFood);
                        break;
                    case "Herbata - 5 zł":
                        totalPrice += 5;
                        orderList.Add(selectedFood);
                        break;
                    case "Cola - 5 zł":
                        totalPrice += 5;
                        orderList.Add(selectedFood);
                        break;
                }
            }

            foreach (string t in orderList)
            {
                orderText.Text += (t + "\r\n");

                foreach(string s in addons)
                {
                    totalPrice += 2;

                    if (s == "Bar sałatkowy - 5 zł")
                        totalPrice += 3;
                    if (s == "Zestaw sosów - 6 zł")
                        totalPrice += 4;

                    orderText.Text += ("  -" + s + "\r\n");                    
                }
            }

            priceLabel.Text = ("Cena do zapłaty: " + totalPrice + " zł");

            
            orderList.Clear();
            addons.Clear();
        }

        private void orderButton_Click(object sender, EventArgs e)  // Function for "Zamów" button, which sends e-mail to the adress given in settings, as well as prints out order history
        {
            orderID++;

            if (orderText.Text != "")
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(Properties.Settings.Default.smtp);

                    mail.From = new MailAddress(Properties.Settings.Default.nadawca);
                    mail.To.Add(Properties.Settings.Default.odbiorca);
                    mail.Subject = ("Order #" + orderID);
                    mail.Body = (orderText.Text + "\r\n" + priceLabel.Text);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.username, Properties.Settings.Default.password);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Your order has been successfully sent!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                TabPage historyPage = new TabPage("Order #" + orderID);
                historyTab.TabPages.Add(historyPage);

                TextBox historyText = new TextBox();
                historyText.Dock = DockStyle.Fill;
                historyText.Multiline = true;
                historyText.Text = (orderText.Text + "\r\n" + priceLabel.Text);

                historyPage.Controls.Add(historyText);

                historyPage.Name += orderID;
                historyText.Name += orderID;

                orderText.Clear();
                clearAll();
            }
        }

        private void pizzaBox_SelectionChangeCommitted(object sender, EventArgs e)  //// Functions that overwrites selected dish depending on element in which it was selected
        {
            selectedFood = daniaBox.SelectedItem.ToString();            
        }

        private void daniaBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedFood = pizzaBox.SelectedItem.ToString();
        }

        private void zupyBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedFood = zupyBox.SelectedItem.ToString();
        }

        private void napojeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedFood = napojeBox.SelectedItem.ToString();
        }                                                                          ////

        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)      // Removes selections on tab change
        {
            clearAll();
        }

        private void clearAll() {                                                  // Function for clearing out all selections
            selectedFood = "Nothing";

            pizzaBox.SelectedIndex = -1;
            pizzaBox.Text = "Wybierz pizzę...";

            daniaBox.SelectedIndex = -1;
            daniaBox.Text = "Wybierz danie...";

            zupyBox.SelectedIndex = -1;
            zupyBox.Text = "Wybierz zupę...";

            napojeBox.SelectedIndex = -1;
            napojeBox.Text = "Wybierz napój...";

            foreach (int n in pizzaListBox.CheckedIndices)
            {
                pizzaListBox.SetItemCheckState(n, CheckState.Unchecked);
            }

            foreach (int i in daniaListBox.CheckedIndices)
            {
                daniaListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}