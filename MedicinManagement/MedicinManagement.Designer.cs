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
            cbPrioritize = new CheckBox();
            cbbType = new ComboBox();
            SuspendLayout();
            // 
            // tbID
            // 
            tbID.Location = new Point(101, 17);
            tbID.Margin = new Padding(2, 1, 2, 1);
            tbID.Name = "tbID";
            tbID.Size = new Size(156, 23);
            tbID.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(101, 51);
            tbProductName.Margin = new Padding(2, 1, 2, 1);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(156, 23);
            tbProductName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Product Name";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(101, 117);
            tbPrice.Margin = new Padding(2, 1, 2, 1);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(156, 23);
            tbPrice.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(101, 82);
            tbAmount.Margin = new Padding(2, 1, 2, 1);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(156, 23);
            tbAmount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 82);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Amount";
            // 
            // tbExpiredDate
            // 
            tbExpiredDate.Location = new Point(101, 151);
            tbExpiredDate.Margin = new Padding(2, 1, 2, 1);
            tbExpiredDate.Name = "tbExpiredDate";
            tbExpiredDate.Size = new Size(156, 23);
            tbExpiredDate.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 10;
            label5.Text = "Expired Date";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 215);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 22);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(90, 215);
            btnUpdate.Margin = new Padding(2, 1, 2, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 22);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 215);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 22);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvProduct
            // 
            lvProduct.Location = new Point(267, 6);
            lvProduct.Margin = new Padding(2, 1, 2, 1);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(581, 233);
            lvProduct.TabIndex = 15;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.SelectedIndexChanged += lvProduct_SelectedIndexChanged;
            // 
            // cbPrioritize
            // 
            cbPrioritize.AutoSize = true;
            cbPrioritize.Location = new Point(12, 185);
            cbPrioritize.Margin = new Padding(2, 1, 2, 1);
            cbPrioritize.Name = "cbPrioritize";
            cbPrioritize.Size = new Size(72, 19);
            cbPrioritize.TabIndex = 16;
            cbPrioritize.Text = "prioritize";
            cbPrioritize.UseVisualStyleBackColor = true;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Location = new Point(101, 184);
            cbbType.Margin = new Padding(2, 1, 2, 1);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(156, 23);
            cbbType.TabIndex = 17;
            cbbType.SelectedIndexChanged += cbbType_SelectedIndexChanged;
            // 
            // MedicinManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 245);
            Controls.Add(cbbType);
            Controls.Add(cbPrioritize);
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
            Margin = new Padding(2, 1, 2, 1);
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
        private CheckBox cbPrioritize;
        private ComboBox cbbType;
    }
}