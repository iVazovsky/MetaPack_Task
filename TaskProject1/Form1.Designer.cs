namespace TaskProject1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pizzaListBox = new System.Windows.Forms.CheckedListBox();
            this.pizzaBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daniaListBox = new System.Windows.Forms.CheckedListBox();
            this.daniaBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.zupyBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.napojeBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.foodCounter = new System.Windows.Forms.NumericUpDown();
            this.orderText = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.historyTab = new System.Windows.Forms.TabControl();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Controls.Add(this.tabPage3);
            this.mainTab.Controls.Add(this.tabPage4);
            this.mainTab.Location = new System.Drawing.Point(17, 13);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(268, 157);
            this.mainTab.TabIndex = 1;
            this.mainTab.SelectedIndexChanged += new System.EventHandler(this.mainTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pizzaListBox);
            this.tabPage1.Controls.Add(this.pizzaBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pizza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rodzaje pizzy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dodatki do pizzy";
            // 
            // pizzaListBox
            // 
            this.pizzaListBox.CheckOnClick = true;
            this.pizzaListBox.FormattingEnabled = true;
            this.pizzaListBox.Items.AddRange(new object[] {
            "Podwójny ser - 2 zł",
            "Salami - 2 zł",
            "Szynka - 2 zł",
            "Pieczarki - 2 zł"});
            this.pizzaListBox.Location = new System.Drawing.Point(135, 29);
            this.pizzaListBox.Name = "pizzaListBox";
            this.pizzaListBox.Size = new System.Drawing.Size(120, 64);
            this.pizzaListBox.TabIndex = 3;
            // 
            // pizzaBox
            // 
            this.pizzaBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pizzaBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pizzaBox.FormattingEnabled = true;
            this.pizzaBox.Items.AddRange(new object[] {
            "Margheritta - 20 zł",
            "Vegetariana - 22 zł",
            "Tosca - 25 zł",
            "Venecia - 25 zł"});
            this.pizzaBox.Location = new System.Drawing.Point(6, 29);
            this.pizzaBox.Name = "pizzaBox";
            this.pizzaBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaBox.TabIndex = 0;
            this.pizzaBox.Text = "Wybierz pizzę...";
            this.pizzaBox.SelectionChangeCommitted += new System.EventHandler(this.daniaBox_SelectionChangeCommitted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.daniaListBox);
            this.tabPage2.Controls.Add(this.daniaBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dania główne";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dodatki do dań";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rodzaje dań";
            // 
            // daniaListBox
            // 
            this.daniaListBox.CheckOnClick = true;
            this.daniaListBox.FormattingEnabled = true;
            this.daniaListBox.Items.AddRange(new object[] {
            "Bar sałatkowy - 5 zł",
            "Zestaw sosów - 6 zł"});
            this.daniaListBox.Location = new System.Drawing.Point(6, 80);
            this.daniaListBox.Name = "daniaListBox";
            this.daniaListBox.Size = new System.Drawing.Size(120, 34);
            this.daniaListBox.TabIndex = 9;
            // 
            // daniaBox
            // 
            this.daniaBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.daniaBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.daniaBox.FormattingEnabled = true;
            this.daniaBox.Items.AddRange(new object[] {
            "Schabowy z frytkami - 30 zł",
            "Ryba z frytkami - 28 zł",
            "Placek po więgiersku - 27 zł"});
            this.daniaBox.Location = new System.Drawing.Point(6, 28);
            this.daniaBox.Name = "daniaBox";
            this.daniaBox.Size = new System.Drawing.Size(179, 21);
            this.daniaBox.TabIndex = 0;
            this.daniaBox.Text = "Wybierz danie...";
            this.daniaBox.SelectionChangeCommitted += new System.EventHandler(this.pizzaBox_SelectionChangeCommitted);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.zupyBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(260, 131);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zupy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rodzaje zup";
            // 
            // zupyBox
            // 
            this.zupyBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.zupyBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.zupyBox.FormattingEnabled = true;
            this.zupyBox.Items.AddRange(new object[] {
            "Pomidorowa - 12 zł",
            "Rosół - 10 zł"});
            this.zupyBox.Location = new System.Drawing.Point(6, 28);
            this.zupyBox.Name = "zupyBox";
            this.zupyBox.Size = new System.Drawing.Size(121, 21);
            this.zupyBox.TabIndex = 0;
            this.zupyBox.Tag = "";
            this.zupyBox.Text = "Wybierz zupę...";
            this.zupyBox.SelectionChangeCommitted += new System.EventHandler(this.zupyBox_SelectionChangeCommitted);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.napojeBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(260, 131);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Napoje";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rodzaje napojów";
            // 
            // napojeBox
            // 
            this.napojeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.napojeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.napojeBox.FormattingEnabled = true;
            this.napojeBox.Items.AddRange(new object[] {
            "Kawa - 5 zł",
            "Herbata - 5 zł",
            "Cola - 5 zł"});
            this.napojeBox.Location = new System.Drawing.Point(7, 28);
            this.napojeBox.Name = "napojeBox";
            this.napojeBox.Size = new System.Drawing.Size(121, 21);
            this.napojeBox.TabIndex = 0;
            this.napojeBox.Text = "Wybierz napój...";
            this.napojeBox.SelectionChangeCommitted += new System.EventHandler(this.napojeBox_SelectionChangeCommitted);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(291, 115);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ilość";
            // 
            // foodCounter
            // 
            this.foodCounter.Location = new System.Drawing.Point(291, 63);
            this.foodCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.foodCounter.Name = "foodCounter";
            this.foodCounter.Size = new System.Drawing.Size(44, 20);
            this.foodCounter.TabIndex = 2;
            this.foodCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // orderText
            // 
            this.orderText.Location = new System.Drawing.Point(372, 35);
            this.orderText.Multiline = true;
            this.orderText.Name = "orderText";
            this.orderText.ReadOnly = true;
            this.orderText.Size = new System.Drawing.Size(178, 568);
            this.orderText.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(223, 173);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(109, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Cena do zapłaty: 0 zł";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(291, 144);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Zamów";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Twoje zamówienie";
            // 
            // historyTab
            // 
            this.historyTab.Location = new System.Drawing.Point(17, 252);
            this.historyTab.Name = "historyTab";
            this.historyTab.SelectedIndex = 0;
            this.historyTab.Size = new System.Drawing.Size(268, 351);
            this.historyTab.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 615);
            this.Controls.Add(this.historyTab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.orderText);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.foodCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TaskProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox pizzaListBox;
        private System.Windows.Forms.NumericUpDown foodCounter;
        private System.Windows.Forms.ComboBox pizzaBox;
        private System.Windows.Forms.TextBox orderText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox daniaListBox;
        private System.Windows.Forms.ComboBox daniaBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox zupyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox napojeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl historyTab;
    }
}

