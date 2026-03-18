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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButtonBay = new RadioButton();
            radioButtonBayan = new RadioButton();
            btnGoster = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // radioButtonBay
            // 
            radioButtonBay.AutoSize = true;
            radioButtonBay.Location = new Point(12, 68);
            radioButtonBay.Name = "radioButtonBay";
            radioButtonBay.Size = new Size(54, 24);
            radioButtonBay.TabIndex = 4;
            radioButtonBay.TabStop = true;
            radioButtonBay.Text = "Bay";
            radioButtonBay.UseVisualStyleBackColor = true;
            // 
            // radioButtonBayan
            // 
            radioButtonBayan.AutoSize = true;
            radioButtonBayan.Location = new Point(12, 98);
            radioButtonBayan.Name = "radioButtonBayan";
            radioButtonBayan.Size = new Size(70, 24);
            radioButtonBayan.TabIndex = 5;
            radioButtonBayan.TabStop = true;
            radioButtonBayan.Text = "Bayan";
            radioButtonBayan.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(75, 156);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(87, 43);
            btnGoster.TabIndex = 6;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(259, 271);
            Controls.Add(btnGoster);
            Controls.Add(radioButtonBayan);
            Controls.Add(radioButtonBay);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButtonBay;
        private RadioButton radioButtonBayan;
        private Button btnGoster;
    }
}
