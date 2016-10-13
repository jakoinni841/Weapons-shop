namespace Weapons_shop
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.swordBox = new System.Windows.Forms.TextBox();
            this.shieldBox = new System.Windows.Forms.TextBox();
            this.battleaxeBox = new System.Windows.Forms.TextBox();
            this.warhammerBox = new System.Windows.Forms.TextBox();
            this.title2 = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.swordCost = new System.Windows.Forms.Label();
            this.shieldCost = new System.Windows.Forms.Label();
            this.axeCost = new System.Windows.Forms.Label();
            this.hammerCost = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.tenderdLabel = new System.Windows.Forms.Label();
            this.tenderdBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.costText = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.storeOwnerPic = new System.Windows.Forms.PictureBox();
            this.receiptPic = new System.Windows.Forms.PictureBox();
            this.hammerPic = new System.Windows.Forms.PictureBox();
            this.axePic = new System.Windows.Forms.PictureBox();
            this.shieldPic = new System.Windows.Forms.PictureBox();
            this.swordPic = new System.Windows.Forms.PictureBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeOwnerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPic)).BeginInit();
            this.SuspendLayout();
            // 
            // swordBox
            // 
            this.swordBox.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swordBox.Location = new System.Drawing.Point(61, 138);
            this.swordBox.Multiline = true;
            this.swordBox.Name = "swordBox";
            this.swordBox.Size = new System.Drawing.Size(38, 29);
            this.swordBox.TabIndex = 0;
            // 
            // shieldBox
            // 
            this.shieldBox.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shieldBox.Location = new System.Drawing.Point(216, 138);
            this.shieldBox.Multiline = true;
            this.shieldBox.Name = "shieldBox";
            this.shieldBox.Size = new System.Drawing.Size(38, 29);
            this.shieldBox.TabIndex = 1;
            // 
            // battleaxeBox
            // 
            this.battleaxeBox.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleaxeBox.Location = new System.Drawing.Point(366, 138);
            this.battleaxeBox.Multiline = true;
            this.battleaxeBox.Name = "battleaxeBox";
            this.battleaxeBox.Size = new System.Drawing.Size(38, 29);
            this.battleaxeBox.TabIndex = 2;
            // 
            // warhammerBox
            // 
            this.warhammerBox.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warhammerBox.Location = new System.Drawing.Point(511, 138);
            this.warhammerBox.Multiline = true;
            this.warhammerBox.Name = "warhammerBox";
            this.warhammerBox.Size = new System.Drawing.Size(38, 29);
            this.warhammerBox.TabIndex = 3;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(12, 9);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(270, 27);
            this.title2.TabIndex = 4;
            this.title2.Text = "Angus\'s Weapon Shop";
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(17, 328);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(161, 32);
            this.receiptButton.TabIndex = 5;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(17, 271);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(161, 31);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // swordCost
            // 
            this.swordCost.AutoSize = true;
            this.swordCost.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swordCost.Location = new System.Drawing.Point(58, 180);
            this.swordCost.Name = "swordCost";
            this.swordCost.Size = new System.Drawing.Size(80, 16);
            this.swordCost.TabIndex = 8;
            this.swordCost.Text = "0.99 Gold";
            // 
            // shieldCost
            // 
            this.shieldCost.AutoSize = true;
            this.shieldCost.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shieldCost.Location = new System.Drawing.Point(213, 180);
            this.shieldCost.Name = "shieldCost";
            this.shieldCost.Size = new System.Drawing.Size(80, 16);
            this.shieldCost.TabIndex = 9;
            this.shieldCost.Text = "1.89 Gold";
            // 
            // axeCost
            // 
            this.axeCost.AutoSize = true;
            this.axeCost.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axeCost.Location = new System.Drawing.Point(363, 180);
            this.axeCost.Name = "axeCost";
            this.axeCost.Size = new System.Drawing.Size(80, 16);
            this.axeCost.TabIndex = 10;
            this.axeCost.Text = "2.49 Gold";
            // 
            // hammerCost
            // 
            this.hammerCost.AutoSize = true;
            this.hammerCost.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hammerCost.Location = new System.Drawing.Point(508, 180);
            this.hammerCost.Name = "hammerCost";
            this.hammerCost.Size = new System.Drawing.Size(80, 16);
            this.hammerCost.TabIndex = 11;
            this.hammerCost.Text = "3.33 Gold";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(216, 82);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(247, 73);
            this.start.TabIndex = 12;
            this.start.Text = "Enter";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tenderdLabel
            // 
            this.tenderdLabel.AutoSize = true;
            this.tenderdLabel.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderdLabel.Location = new System.Drawing.Point(13, 248);
            this.tenderdLabel.Name = "tenderdLabel";
            this.tenderdLabel.Size = new System.Drawing.Size(88, 20);
            this.tenderdLabel.TabIndex = 13;
            this.tenderdLabel.Text = "Tenderd";
            // 
            // tenderdBox
            // 
            this.tenderdBox.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderdBox.Location = new System.Drawing.Point(107, 245);
            this.tenderdBox.Multiline = true;
            this.tenderdBox.Name = "tenderdBox";
            this.tenderdBox.Size = new System.Drawing.Size(51, 23);
            this.tenderdBox.TabIndex = 14;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(18, 305);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(81, 20);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change";
            // 
            // costText
            // 
            this.costText.AutoSize = true;
            this.costText.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costText.Location = new System.Drawing.Point(319, 233);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(54, 20);
            this.costText.TabIndex = 16;
            this.costText.Text = "Cost";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(319, 271);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(39, 20);
            this.taxLabel.TabIndex = 17;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(319, 305);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(61, 20);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Trajan Pro", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(112, 32);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(476, 47);
            this.title1.TabIndex = 19;
            this.title1.Text = "Angus\'s Weapon Shop";
            // 
            // calculateTotal
            // 
            this.calculateTotal.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotal.Location = new System.Drawing.Point(17, 210);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(161, 29);
            this.calculateTotal.TabIndex = 24;
            this.calculateTotal.Text = "Calculate Total";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(173, 340);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(303, 16);
            this.errorLabel.TabIndex = 26;
            this.errorLabel.Text = "You must enter a number for each item";
            // 
            // storeOwnerPic
            // 
            this.storeOwnerPic.Image = global::Weapons_shop.Properties.Resources.blacksmith_1460826_960_720;
            this.storeOwnerPic.Location = new System.Drawing.Point(480, 180);
            this.storeOwnerPic.Name = "storeOwnerPic";
            this.storeOwnerPic.Size = new System.Drawing.Size(242, 359);
            this.storeOwnerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.storeOwnerPic.TabIndex = 27;
            this.storeOwnerPic.TabStop = false;
            // 
            // receiptPic
            // 
            this.receiptPic.Image = global::Weapons_shop.Properties.Resources.Scroll_PNG_File;
            this.receiptPic.Location = new System.Drawing.Point(-23, 1);
            this.receiptPic.Name = "receiptPic";
            this.receiptPic.Size = new System.Drawing.Size(745, 369);
            this.receiptPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.receiptPic.TabIndex = 25;
            this.receiptPic.TabStop = false;
            // 
            // hammerPic
            // 
            this.hammerPic.Image = global::Weapons_shop.Properties.Resources.Dwarvenwarhammer;
            this.hammerPic.Location = new System.Drawing.Point(495, 1);
            this.hammerPic.Name = "hammerPic";
            this.hammerPic.Size = new System.Drawing.Size(165, 131);
            this.hammerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hammerPic.TabIndex = 23;
            this.hammerPic.TabStop = false;
            // 
            // axePic
            // 
            this.axePic.Image = global::Weapons_shop.Properties.Resources.SteelBattleAxe_SK;
            this.axePic.Location = new System.Drawing.Point(323, 9);
            this.axePic.Name = "axePic";
            this.axePic.Size = new System.Drawing.Size(153, 123);
            this.axePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.axePic.TabIndex = 22;
            this.axePic.TabStop = false;
            // 
            // shieldPic
            // 
            this.shieldPic.Image = global::Weapons_shop.Properties.Resources.Hide_shield;
            this.shieldPic.Location = new System.Drawing.Point(192, 32);
            this.shieldPic.Name = "shieldPic";
            this.shieldPic.Size = new System.Drawing.Size(101, 100);
            this.shieldPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shieldPic.TabIndex = 21;
            this.shieldPic.TabStop = false;
            // 
            // swordPic
            // 
            this.swordPic.Image = global::Weapons_shop.Properties.Resources.sword_PNG5518;
            this.swordPic.Location = new System.Drawing.Point(17, 39);
            this.swordPic.Name = "swordPic";
            this.swordPic.Size = new System.Drawing.Size(135, 93);
            this.swordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordPic.TabIndex = 20;
            this.swordPic.TabStop = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(520, 259);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(130, 43);
            this.newOrderButton.TabIndex = 28;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(701, 365);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.storeOwnerPic);
            this.Controls.Add(this.receiptPic);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.hammerPic);
            this.Controls.Add(this.axePic);
            this.Controls.Add(this.shieldPic);
            this.Controls.Add(this.swordPic);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderdBox);
            this.Controls.Add(this.tenderdLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.hammerCost);
            this.Controls.Add(this.axeCost);
            this.Controls.Add(this.shieldCost);
            this.Controls.Add(this.swordCost);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.warhammerBox);
            this.Controls.Add(this.battleaxeBox);
            this.Controls.Add(this.shieldBox);
            this.Controls.Add(this.swordBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "Angus\'s Weapon Shop";
            ((System.ComponentModel.ISupportInitialize)(this.storeOwnerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox swordBox;
        private System.Windows.Forms.TextBox shieldBox;
        private System.Windows.Forms.TextBox battleaxeBox;
        private System.Windows.Forms.TextBox warhammerBox;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label swordCost;
        private System.Windows.Forms.Label shieldCost;
        private System.Windows.Forms.Label axeCost;
        private System.Windows.Forms.Label hammerCost;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label tenderdLabel;
        private System.Windows.Forms.TextBox tenderdBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label costText;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.PictureBox swordPic;
        private System.Windows.Forms.PictureBox shieldPic;
        private System.Windows.Forms.PictureBox axePic;
        private System.Windows.Forms.PictureBox hammerPic;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.PictureBox receiptPic;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox storeOwnerPic;
        private System.Windows.Forms.Button newOrderButton;
    }
}

