namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            IbCarID = new Label();
            IbCarName = new Label();
            IbManufacturer = new Label();
            IbPrice = new Label();
            IbReleaseYear = new Label();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            txtCarID = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            colorDialog1 = new ColorDialog();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // IbCarID
            // 
            IbCarID.AutoSize = true;
            IbCarID.Location = new Point(37, 64);
            IbCarID.Name = "IbCarID";
            IbCarID.Size = new Size(118, 48);
            IbCarID.TabIndex = 0;
            IbCarID.Text = "Car ID";
            // 
            // IbCarName
            // 
            IbCarName.AutoSize = true;
            IbCarName.Location = new Point(37, 133);
            IbCarName.Name = "IbCarName";
            IbCarName.Size = new Size(178, 48);
            IbCarName.TabIndex = 1;
            IbCarName.Text = "Car Name";
            // 
            // IbManufacturer
            // 
            IbManufacturer.AutoSize = true;
            IbManufacturer.Location = new Point(29, 209);
            IbManufacturer.Name = "IbManufacturer";
            IbManufacturer.Size = new Size(233, 48);
            IbManufacturer.TabIndex = 2;
            IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            IbPrice.AutoSize = true;
            IbPrice.Location = new Point(674, 64);
            IbPrice.Name = "IbPrice";
            IbPrice.Size = new Size(98, 48);
            IbPrice.TabIndex = 3;
            IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            IbReleaseYear.AutoSize = true;
            IbReleaseYear.Location = new Point(674, 136);
            IbReleaseYear.Name = "IbReleaseYear";
            IbReleaseYear.Size = new Size(217, 48);
            IbReleaseYear.TabIndex = 4;
            IbReleaseYear.Text = "Release Year";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(268, 136);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(400, 55);
            txtCarName.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(268, 202);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(400, 55);
            txtManufacturer.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(897, 61);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(425, 55);
            txtPrice.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(897, 129);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(426, 55);
            txtReleaseYear.TabIndex = 8;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(268, 61);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(400, 55);
            txtCarID.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(228, 281);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(225, 69);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(572, 281);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(225, 69);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(937, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 69);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(29, 380);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 123;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(1301, 285);
            dgvCarList.TabIndex = 15;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(572, 700);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(225, 69);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 799);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCarID);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(IbReleaseYear);
            Controls.Add(IbPrice);
            Controls.Add(IbManufacturer);
            Controls.Add(IbCarName);
            Controls.Add(IbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbCarID;
        private Label IbCarName;
        private Label IbManufacturer;
        private Label IbPrice;
        private Label IbReleaseYear;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private TextBox txtCarID;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private ColorDialog colorDialog1;
        private Button btnClose;
    }
}