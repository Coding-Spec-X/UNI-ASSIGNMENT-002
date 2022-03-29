namespace Practice1
{
    partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.coffeeRequiredTextBox = new System.Windows.Forms.TextBox();
            this.teaBagsRequiredTextBox = new System.Windows.Forms.TextBox();
            this.costOfCoffeeTextBox = new System.Windows.Forms.TextBox();
            this.costOfTeaBagsTextBox = new System.Windows.Forms.TextBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.coffeeRequiredLabel = new System.Windows.Forms.Label();
            this.teaBagsRequiredLabel = new System.Windows.Forms.Label();
            this.costOfCoffeeLabel = new System.Windows.Forms.Label();
            this.costOfTeaBagsLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.coffeeDrinkersTextBox = new System.Windows.Forms.TextBox();
            this.teaDrinkersTextBox = new System.Windows.Forms.TextBox();
            this.coffeeDrinkersLabel = new System.Windows.Forms.Label();
            this.teaDrinkersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(87, 367);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(125, 45);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(244, 367);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 45);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(399, 367);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // coffeeRequiredTextBox
            // 
            this.coffeeRequiredTextBox.Location = new System.Drawing.Point(316, 123);
            this.coffeeRequiredTextBox.Name = "coffeeRequiredTextBox";
            this.coffeeRequiredTextBox.Size = new System.Drawing.Size(100, 22);
            this.coffeeRequiredTextBox.TabIndex = 3;
            // 
            // teaBagsRequiredTextBox
            // 
            this.teaBagsRequiredTextBox.Location = new System.Drawing.Point(316, 168);
            this.teaBagsRequiredTextBox.Name = "teaBagsRequiredTextBox";
            this.teaBagsRequiredTextBox.Size = new System.Drawing.Size(100, 22);
            this.teaBagsRequiredTextBox.TabIndex = 4;
            // 
            // costOfCoffeeTextBox
            // 
            this.costOfCoffeeTextBox.Location = new System.Drawing.Point(316, 214);
            this.costOfCoffeeTextBox.Name = "costOfCoffeeTextBox";
            this.costOfCoffeeTextBox.Size = new System.Drawing.Size(100, 22);
            this.costOfCoffeeTextBox.TabIndex = 5;
            // 
            // costOfTeaBagsTextBox
            // 
            this.costOfTeaBagsTextBox.Location = new System.Drawing.Point(316, 259);
            this.costOfTeaBagsTextBox.Name = "costOfTeaBagsTextBox";
            this.costOfTeaBagsTextBox.Size = new System.Drawing.Size(100, 22);
            this.costOfTeaBagsTextBox.TabIndex = 6;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(316, 301);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalCostTextBox.TabIndex = 7;
            // 
            // coffeeRequiredLabel
            // 
            this.coffeeRequiredLabel.AutoSize = true;
            this.coffeeRequiredLabel.Location = new System.Drawing.Point(151, 129);
            this.coffeeRequiredLabel.Name = "coffeeRequiredLabel";
            this.coffeeRequiredLabel.Size = new System.Drawing.Size(142, 16);
            this.coffeeRequiredLabel.TabIndex = 8;
            this.coffeeRequiredLabel.Text = "Coffee Required (Kgs):";
            // 
            // teaBagsRequiredLabel
            // 
            this.teaBagsRequiredLabel.AutoSize = true;
            this.teaBagsRequiredLabel.Location = new System.Drawing.Point(164, 174);
            this.teaBagsRequiredLabel.Name = "teaBagsRequiredLabel";
            this.teaBagsRequiredLabel.Size = new System.Drawing.Size(129, 16);
            this.teaBagsRequiredLabel.TabIndex = 9;
            this.teaBagsRequiredLabel.Text = "Tea Bags Required:";
            // 
            // costOfCoffeeLabel
            // 
            this.costOfCoffeeLabel.AutoSize = true;
            this.costOfCoffeeLabel.Location = new System.Drawing.Point(202, 220);
            this.costOfCoffeeLabel.Name = "costOfCoffeeLabel";
            this.costOfCoffeeLabel.Size = new System.Drawing.Size(91, 16);
            this.costOfCoffeeLabel.TabIndex = 10;
            this.costOfCoffeeLabel.Text = "Cost of coffee:";
            // 
            // costOfTeaBagsLabel
            // 
            this.costOfTeaBagsLabel.AutoSize = true;
            this.costOfTeaBagsLabel.Location = new System.Drawing.Point(179, 265);
            this.costOfTeaBagsLabel.Name = "costOfTeaBagsLabel";
            this.costOfTeaBagsLabel.Size = new System.Drawing.Size(114, 16);
            this.costOfTeaBagsLabel.TabIndex = 11;
            this.costOfTeaBagsLabel.Text = "Cost of Tea Bags:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(222, 307);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(71, 16);
            this.totalCostLabel.TabIndex = 12;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // coffeeDrinkersTextBox
            // 
            this.coffeeDrinkersTextBox.Location = new System.Drawing.Point(205, 68);
            this.coffeeDrinkersTextBox.Name = "coffeeDrinkersTextBox";
            this.coffeeDrinkersTextBox.Size = new System.Drawing.Size(100, 22);
            this.coffeeDrinkersTextBox.TabIndex = 13;
            // 
            // teaDrinkersTextBox
            // 
            this.teaDrinkersTextBox.Location = new System.Drawing.Point(435, 68);
            this.teaDrinkersTextBox.Name = "teaDrinkersTextBox";
            this.teaDrinkersTextBox.Size = new System.Drawing.Size(100, 22);
            this.teaDrinkersTextBox.TabIndex = 14;
            // 
            // coffeeDrinkersLabel
            // 
            this.coffeeDrinkersLabel.AutoSize = true;
            this.coffeeDrinkersLabel.Location = new System.Drawing.Point(84, 74);
            this.coffeeDrinkersLabel.Name = "coffeeDrinkersLabel";
            this.coffeeDrinkersLabel.Size = new System.Drawing.Size(102, 16);
            this.coffeeDrinkersLabel.TabIndex = 15;
            this.coffeeDrinkersLabel.Text = "Coffee Drinkers:";
            // 
            // teaDrinkersLabel
            // 
            this.teaDrinkersLabel.AutoSize = true;
            this.teaDrinkersLabel.Location = new System.Drawing.Point(328, 74);
            this.teaDrinkersLabel.Name = "teaDrinkersLabel";
            this.teaDrinkersLabel.Size = new System.Drawing.Size(88, 16);
            this.teaDrinkersLabel.TabIndex = 16;
            this.teaDrinkersLabel.Text = "Tea Drinkers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 435);
            this.Controls.Add(this.teaDrinkersLabel);
            this.Controls.Add(this.coffeeDrinkersLabel);
            this.Controls.Add(this.teaDrinkersTextBox);
            this.Controls.Add(this.coffeeDrinkersTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.costOfTeaBagsLabel);
            this.Controls.Add(this.costOfCoffeeLabel);
            this.Controls.Add(this.teaBagsRequiredLabel);
            this.Controls.Add(this.coffeeRequiredLabel);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.costOfTeaBagsTextBox);
            this.Controls.Add(this.costOfCoffeeTextBox);
            this.Controls.Add(this.teaBagsRequiredTextBox);
            this.Controls.Add(this.coffeeRequiredTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "103 Practice Test 1 2015";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox coffeeRequiredTextBox;
        private System.Windows.Forms.TextBox teaBagsRequiredTextBox;
        private System.Windows.Forms.TextBox costOfCoffeeTextBox;
        private System.Windows.Forms.TextBox costOfTeaBagsTextBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label coffeeRequiredLabel;
        private System.Windows.Forms.Label teaBagsRequiredLabel;
        private System.Windows.Forms.Label costOfCoffeeLabel;
        private System.Windows.Forms.Label costOfTeaBagsLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox coffeeDrinkersTextBox;
        private System.Windows.Forms.TextBox teaDrinkersTextBox;
        private System.Windows.Forms.Label coffeeDrinkersLabel;
        private System.Windows.Forms.Label teaDrinkersLabel;
    }
}

