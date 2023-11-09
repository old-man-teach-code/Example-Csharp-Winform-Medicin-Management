namespace MedicinManagement
{
    partial class MedicinManagement
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
            tbID = new TextBox();
            label1 = new Label();
            tbProductName = new TextBox();
            label2 = new Label();
            tbPrice = new TextBox();
            label3 = new Label();
            tbAmount = new TextBox();
            label4 = new Label();
            tbExpiredDate = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lvProduct = new ListView();
            SuspendLayout();
            // 
            // tbID
            // 
            tbID.Location = new Point(188, 67);
            tbID.Name = "tbID";
            tbID.Size = new Size(286, 39);
            tbID.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 70);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(188, 142);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(286, 39);
            tbProductName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 145);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 4;
            label2.Text = "Product Name";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(188, 293);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(286, 39);
            tbPrice.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 296);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(188, 218);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(286, 39);
            tbAmount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 221);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 6;
            label4.Text = "Amount";
            // 
            // tbExpiredDate
            // 
            tbExpiredDate.Location = new Point(188, 372);
            tbExpiredDate.Name = "tbExpiredDate";
            tbExpiredDate.Size = new Size(286, 39);
            tbExpiredDate.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 375);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 10;
            label5.Text = "Expired Date";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 458);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(168, 458);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 458);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lvProduct
            // 
            lvProduct.Location = new Point(495, 12);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(756, 492);
            lvProduct.TabIndex = 15;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.SelectedIndexChanged += lvProduct_SelectedIndexChanged;
            // 
            // MedicinManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 516);
            Controls.Add(lvProduct);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbExpiredDate);
            Controls.Add(label5);
            Controls.Add(tbPrice);
            Controls.Add(label3);
            Controls.Add(tbAmount);
            Controls.Add(label4);
            Controls.Add(tbProductName);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(label1);
            Name = "MedicinManagement";
            Text = "Medicin Management";
            Load += MedicinManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbID;
        private Label label1;
        private TextBox tbProductName;
        private Label label2;
        private TextBox tbPrice;
        private Label label3;
        private TextBox tbAmount;
        private Label label4;
        private TextBox tbExpiredDate;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvProduct;
    }
}