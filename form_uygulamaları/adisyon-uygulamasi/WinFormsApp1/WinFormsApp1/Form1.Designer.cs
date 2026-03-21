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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            kullaniciAdiTxt = new TextBox();
            sifreTxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(122, 172);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 53);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 105);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "ŞİFRE: ";
            label2.Click += label2_Click;
            // 
            // kullaniciAdiTxt
            // 
            kullaniciAdiTxt.Location = new Point(122, 46);
            kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            kullaniciAdiTxt.Size = new Size(125, 27);
            kullaniciAdiTxt.TabIndex = 3;
            kullaniciAdiTxt.TextChanged += kullaniciAdiTxt_TextChanged;
            // 
            // sifreTxt
            // 
            sifreTxt.Location = new Point(122, 98);
            sifreTxt.Name = "sifreTxt";
            sifreTxt.Size = new Size(125, 27);
            sifreTxt.TabIndex = 4;
            sifreTxt.TextChanged += sifreTxt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 238);
            Controls.Add(sifreTxt);
            Controls.Add(kullaniciAdiTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox kullaniciAdiTxt;
        private TextBox sifreTxt;
    }
}
