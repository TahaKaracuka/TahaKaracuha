namespace WindowsForm01_Intro
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
            btnSave = new Button();
            cbAgree = new CheckBox();
            cmbCategoryList = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            txtProductName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(87, 62);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbAgree
            // 
            cbAgree.AutoSize = true;
            cbAgree.Location = new Point(308, 67);
            cbAgree.Name = "cbAgree";
            cbAgree.Size = new Size(163, 29);
            cbAgree.TabIndex = 1;
            cbAgree.Text = "Kabul ediyorum";
            cbAgree.UseVisualStyleBackColor = true;
            // 
            // cmbCategoryList
            // 
            cmbCategoryList.FormattingEnabled = true;
            cmbCategoryList.Location = new Point(521, 64);
            cmbCategoryList.Name = "cmbCategoryList";
            cmbCategoryList.Size = new Size(182, 33);
            cmbCategoryList.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 131);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(428, 139);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(298, 302);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(91, 12);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductName);
            Controls.Add(radioButton1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(cmbCategoryList);
            Controls.Add(cbAgree);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Uygulamam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private CheckBox cbAgree;
        private ComboBox cmbCategoryList;
        private Label label1;
        private ListBox listBox1;
        private RadioButton radioButton1;
        private TextBox txtProductName;
    }
}
