namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cboNumber1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboNumber2 = new ComboBox();
            chkLst1 = new CheckedListBox();
            SuspendLayout();
            // 
            // cboNumber1
            // 
            cboNumber1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNumber1.FormattingEnabled = true;
            cboNumber1.Location = new Point(97, 69);
            cboNumber1.Name = "cboNumber1";
            cboNumber1.Size = new Size(121, 23);
            cboNumber1.TabIndex = 0;
            cboNumber1.SelectedIndexChanged += ShowCheckList;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 51);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Number 2";
            // 
            // cboNumber2
            // 
            cboNumber2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNumber2.FormattingEnabled = true;
            cboNumber2.Location = new Point(369, 69);
            cboNumber2.Name = "cboNumber2";
            cboNumber2.Size = new Size(121, 23);
            cboNumber2.TabIndex = 3;
            cboNumber2.SelectedIndexChanged += ShowCheckList;
            // 
            // chkLst1
            // 
            chkLst1.FormattingEnabled = true;
            chkLst1.Location = new Point(12, 113);
            chkLst1.Name = "chkLst1";
            chkLst1.Size = new Size(851, 472);
            chkLst1.TabIndex = 4;
            chkLst1.ItemCheck += chkLst1_ItemCheck;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 615);
            Controls.Add(chkLst1);
            Controls.Add(cboNumber2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboNumber1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Lock Breaker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboNumber1;
        private Label label1;
        private Label label2;
        private ComboBox cboNumber2;
        private CheckedListBox chkLst1;
    }
}
