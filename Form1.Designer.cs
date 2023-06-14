namespace DesignPatterns
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
            this.InviteBtn = new System.Windows.Forms.Button();
            this.ProductsList = new DesignPatterns.RadioButtonList();
            this.EnterPaymentTxt = new System.Windows.Forms.TextBox();
            this.PaymentTxt = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BagCheck = new System.Windows.Forms.CheckBox();
            this.GiftCheck = new System.Windows.Forms.CheckBox();
            this.PaymentList = new DesignPatterns.RadioButtonList();
            this.PayBack = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.TextBox();
            this.CarditCardTxt = new System.Windows.Forms.TextBox();
            this.ProductsTxt = new System.Windows.Forms.TextBox();
            this.MyMesseg = new System.Windows.Forms.TextBox();
            this.NewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InviteBtn
            // 
            this.InviteBtn.Location = new System.Drawing.Point(223, 240);
            this.InviteBtn.Name = "InviteBtn";
            this.InviteBtn.Size = new System.Drawing.Size(198, 48);
            this.InviteBtn.TabIndex = 0;
            this.InviteBtn.Text = "To Order";
            this.InviteBtn.UseVisualStyleBackColor = true;
            this.InviteBtn.Visible = false;
            this.InviteBtn.Click += new System.EventHandler(this.InviteBtn_Click);
            // 
            // ProductsList
            // 
            this.ProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Items.AddRange(new object[] {
            "Chips",
            "Doritos",
            "Chocolate",
            "Shogi",
            "Crackers",
            "Waffles",
            "Coffee",
            "Tea",
            "Cappuccino",
            "Choco",
            "Chocolata",
            "ColaZero",
            "CocaCola",
            "FuzeTea",
            "IceCoffee",
            "IceVanil",
            "Sprite"});
            this.ProductsList.Location = new System.Drawing.Point(53, 54);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(120, 306);
            this.ProductsList.TabIndex = 4;
            this.ProductsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // EnterPaymentTxt
            // 
            this.EnterPaymentTxt.Location = new System.Drawing.Point(541, 233);
            this.EnterPaymentTxt.Name = "EnterPaymentTxt";
            this.EnterPaymentTxt.PlaceholderText = "Enter payment";
            this.EnterPaymentTxt.Size = new System.Drawing.Size(120, 23);
            this.EnterPaymentTxt.TabIndex = 7;
            this.EnterPaymentTxt.Tag = "";
            this.EnterPaymentTxt.Visible = false;
            this.EnterPaymentTxt.TextChanged += new System.EventHandler(this.EnterPaymentTxt_TextChanged);
            // 
            // PaymentTxt
            // 
            this.PaymentTxt.Location = new System.Drawing.Point(541, 95);
            this.PaymentTxt.Name = "PaymentTxt";
            this.PaymentTxt.Size = new System.Drawing.Size(56, 23);
            this.PaymentTxt.TabIndex = 8;
            this.PaymentTxt.Visible = false;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(667, 232);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 25);
            this.Enter.TabIndex = 9;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Visible = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(541, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 16);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Cash";
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(541, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 16);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Cardit Card";
            this.textBox4.Visible = false;
            // 
            // BagCheck
            // 
            this.BagCheck.AutoSize = true;
            this.BagCheck.Location = new System.Drawing.Point(223, 183);
            this.BagCheck.Name = "BagCheck";
            this.BagCheck.Size = new System.Drawing.Size(46, 19);
            this.BagCheck.TabIndex = 11;
            this.BagCheck.Text = "Bag";
            this.BagCheck.UseVisualStyleBackColor = true;
            this.BagCheck.CheckedChanged += new System.EventHandler(this.BagCheck_CheckedChanged);
            // 
            // GiftCheck
            // 
            this.GiftCheck.AutoSize = true;
            this.GiftCheck.Location = new System.Drawing.Point(223, 208);
            this.GiftCheck.Name = "GiftCheck";
            this.GiftCheck.Size = new System.Drawing.Size(76, 19);
            this.GiftCheck.TabIndex = 11;
            this.GiftCheck.Text = "Gift Warp";
            this.GiftCheck.UseVisualStyleBackColor = true;
            // 
            // PaymentList
            // 
            this.PaymentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentList.FormattingEnabled = true;
            this.PaymentList.Items.AddRange(new object[] {
            "Cash",
            "Cardit Card"});
            this.PaymentList.Location = new System.Drawing.Point(541, 124);
            this.PaymentList.Name = "PaymentList";
            this.PaymentList.Size = new System.Drawing.Size(120, 36);
            this.PaymentList.TabIndex = 12;
            this.PaymentList.Visible = false;
            this.PaymentList.SelectedIndexChanged += new System.EventHandler(this.PaymentList_SelectedIndexChanged);
            // 
            // PayBack
            // 
            this.PayBack.Location = new System.Drawing.Point(593, 265);
            this.PayBack.Name = "PayBack";
            this.PayBack.Size = new System.Drawing.Size(149, 23);
            this.PayBack.TabIndex = 13;
            this.PayBack.Visible = false;
            // 
            // Change
            // 
            this.Change.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Change.Location = new System.Drawing.Point(541, 268);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(46, 16);
            this.Change.TabIndex = 14;
            this.Change.Text = "Change:";
            this.Change.Visible = false;
            this.Change.TextChanged += new System.EventHandler(this.Change_TextChanged);
            // 
            // CarditCardTxt
            // 
            this.CarditCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarditCardTxt.Location = new System.Drawing.Point(538, 322);
            this.CarditCardTxt.Name = "CarditCardTxt";
            this.CarditCardTxt.Size = new System.Drawing.Size(204, 16);
            this.CarditCardTxt.TabIndex = 15;
            this.CarditCardTxt.Visible = false;
            // 
            // ProductsTxt
            // 
            this.ProductsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsTxt.Location = new System.Drawing.Point(53, 32);
            this.ProductsTxt.Name = "ProductsTxt";
            this.ProductsTxt.Size = new System.Drawing.Size(100, 16);
            this.ProductsTxt.TabIndex = 6;
            this.ProductsTxt.Text = "Products";
            // 
            // MyMesseg
            // 
            this.MyMesseg.Location = new System.Drawing.Point(12, 415);
            this.MyMesseg.Name = "MyMesseg";
            this.MyMesseg.Size = new System.Drawing.Size(776, 23);
            this.MyMesseg.TabIndex = 16;
            this.MyMesseg.TextChanged += new System.EventHandler(this.MyMesseg_TextChanged);
            // 
            // NewOrder
            // 
            this.NewOrder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.NewOrder.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewOrder.Location = new System.Drawing.Point(189, 344);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(463, 169);
            this.NewOrder.TabIndex = 17;
            this.NewOrder.Text = "NewOrder";
            this.NewOrder.UseVisualStyleBackColor = false;
            this.NewOrder.Visible = false;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.MyMesseg);
            this.Controls.Add(this.CarditCardTxt);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.PayBack);
            this.Controls.Add(this.PaymentList);
            this.Controls.Add(this.GiftCheck);
            this.Controls.Add(this.BagCheck);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.PaymentTxt);
            this.Controls.Add(this.EnterPaymentTxt);
            this.Controls.Add(this.ProductsTxt);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.InviteBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button InviteBtn;
        private RadioButtonList ListOfProduct;
        private RadioButtonList ProductsList;
        private TextBox EnterPaymentTxt;
        private TextBox PaymentTxt;
        private Button Enter;
        private TextBox textBox3;
        private TextBox textBox4;
        private CheckBox BagCheck;
        private CheckBox GiftCheck;
        private RadioButtonList PaymentList;
        private TextBox PayBack;
        private TextBox Change;
        private TextBox CarditCardTxt;
        private TextBox ProductsTxt;
        private TextBox MyMesseg;
        private Button NewOrder;
    }
}