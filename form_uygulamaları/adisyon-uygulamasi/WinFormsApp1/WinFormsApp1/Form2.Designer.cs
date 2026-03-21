namespace WinFormsApp1
{
    partial class Form2
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
            panel1 = new Panel();
            masa4btn = new Button();
            masa3btn = new Button();
            masa2btn = new Button();
            masa1btn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            salepBtn = new Button();
            ihlamurBtn = new Button();
            limonataBtn = new Button();
            ayranBtn = new Button();
            kolaBtn = new Button();
            kahveBtn = new Button();
            cayBtn = new Button();
            suBtn = new Button();
            dataGridView1 = new DataGridView();
            urunDG = new DataGridViewTextBoxColumn();
            fiyatDG = new DataGridViewTextBoxColumn();
            secileniSilBTN = new Button();
            hesapKesBTN = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(masa4btn);
            panel1.Controls.Add(masa3btn);
            panel1.Controls.Add(masa2btn);
            panel1.Controls.Add(masa1btn);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 231);
            panel1.TabIndex = 0;
            // 
            // masa4btn
            // 
            masa4btn.Location = new Point(415, 0);
            masa4btn.Name = "masa4btn";
            masa4btn.Size = new Size(121, 231);
            masa4btn.TabIndex = 4;
            masa4btn.Text = "MASA 4";
            masa4btn.UseVisualStyleBackColor = true;
            masa4btn.Click += masa4btn_Click;
            // 
            // masa3btn
            // 
            masa3btn.Location = new Point(276, 0);
            masa3btn.Name = "masa3btn";
            masa3btn.Size = new Size(121, 231);
            masa3btn.TabIndex = 3;
            masa3btn.Text = "MASA 3";
            masa3btn.UseVisualStyleBackColor = true;
            masa3btn.Click += masa3btn_Click;
            // 
            // masa2btn
            // 
            masa2btn.Location = new Point(136, 0);
            masa2btn.Name = "masa2btn";
            masa2btn.Size = new Size(121, 231);
            masa2btn.TabIndex = 2;
            masa2btn.Text = "MASA 2";
            masa2btn.UseVisualStyleBackColor = true;
            masa2btn.Click += masa2btn_Click;
            // 
            // masa1btn
            // 
            masa1btn.BackColor = SystemColors.ButtonFace;
            masa1btn.ForeColor = SystemColors.ControlText;
            masa1btn.Location = new Point(0, 0);
            masa1btn.Name = "masa1btn";
            masa1btn.Size = new Size(121, 231);
            masa1btn.TabIndex = 1;
            masa1btn.Text = "MASA 1";
            masa1btn.UseVisualStyleBackColor = false;
            masa1btn.Click += masa1btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(salepBtn);
            panel2.Controls.Add(ihlamurBtn);
            panel2.Controls.Add(limonataBtn);
            panel2.Controls.Add(ayranBtn);
            panel2.Controls.Add(kolaBtn);
            panel2.Controls.Add(kahveBtn);
            panel2.Controls.Add(cayBtn);
            panel2.Controls.Add(suBtn);
            panel2.Location = new Point(12, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 199);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(222, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "İÇECEKLER";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // salepBtn
            // 
            salepBtn.Location = new Point(412, 111);
            salepBtn.Name = "salepBtn";
            salepBtn.Size = new Size(121, 55);
            salepBtn.TabIndex = 8;
            salepBtn.Text = "Salep";
            salepBtn.UseVisualStyleBackColor = true;
            salepBtn.Click += salepBtn_Click;
            // 
            // ihlamurBtn
            // 
            ihlamurBtn.Location = new Point(276, 111);
            ihlamurBtn.Name = "ihlamurBtn";
            ihlamurBtn.Size = new Size(121, 55);
            ihlamurBtn.TabIndex = 7;
            ihlamurBtn.Text = "Ihlamur";
            ihlamurBtn.UseVisualStyleBackColor = true;
            ihlamurBtn.Click += ihlamurBtn_Click;
            // 
            // limonataBtn
            // 
            limonataBtn.Location = new Point(136, 111);
            limonataBtn.Name = "limonataBtn";
            limonataBtn.Size = new Size(121, 55);
            limonataBtn.TabIndex = 3;
            limonataBtn.Text = "Limonata";
            limonataBtn.UseVisualStyleBackColor = true;
            limonataBtn.Click += limonataBtn_Click;
            // 
            // ayranBtn
            // 
            ayranBtn.Location = new Point(3, 111);
            ayranBtn.Name = "ayranBtn";
            ayranBtn.Size = new Size(118, 55);
            ayranBtn.TabIndex = 6;
            ayranBtn.Text = "Ayran";
            ayranBtn.UseVisualStyleBackColor = true;
            ayranBtn.Click += ayranBtn_Click;
            // 
            // kolaBtn
            // 
            kolaBtn.Location = new Point(412, 38);
            kolaBtn.Name = "kolaBtn";
            kolaBtn.Size = new Size(121, 55);
            kolaBtn.TabIndex = 5;
            kolaBtn.Text = "Kola";
            kolaBtn.UseVisualStyleBackColor = true;
            kolaBtn.Click += kolaBtn_Click;
            // 
            // kahveBtn
            // 
            kahveBtn.Location = new Point(276, 38);
            kahveBtn.Name = "kahveBtn";
            kahveBtn.Size = new Size(121, 55);
            kahveBtn.TabIndex = 4;
            kahveBtn.Text = "Kahve";
            kahveBtn.UseVisualStyleBackColor = true;
            kahveBtn.Click += kahveBtn_Click;
            // 
            // cayBtn
            // 
            cayBtn.Location = new Point(136, 38);
            cayBtn.Name = "cayBtn";
            cayBtn.Size = new Size(121, 55);
            cayBtn.TabIndex = 3;
            cayBtn.Text = "Çay";
            cayBtn.UseVisualStyleBackColor = true;
            cayBtn.Click += cayBtn_Click;
            // 
            // suBtn
            // 
            suBtn.Location = new Point(3, 38);
            suBtn.Name = "suBtn";
            suBtn.Size = new Size(118, 55);
            suBtn.TabIndex = 2;
            suBtn.Text = "Su";
            suBtn.UseVisualStyleBackColor = true;
            suBtn.Click += suBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { urunDG, fiyatDG });
            dataGridView1.Location = new Point(555, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(327, 295);
            dataGridView1.TabIndex = 2;
            // 
            // urunDG
            // 
            urunDG.HeaderText = "Ürün";
            urunDG.MinimumWidth = 6;
            urunDG.Name = "urunDG";
            // 
            // fiyatDG
            // 
            fiyatDG.HeaderText = "Fiyat";
            fiyatDG.MinimumWidth = 6;
            fiyatDG.Name = "fiyatDG";
            // 
            // secileniSilBTN
            // 
            secileniSilBTN.Location = new Point(632, 313);
            secileniSilBTN.Name = "secileniSilBTN";
            secileniSilBTN.Size = new Size(185, 29);
            secileniSilBTN.TabIndex = 3;
            secileniSilBTN.Text = "Seçileni Sil";
            secileniSilBTN.UseVisualStyleBackColor = true;
            secileniSilBTN.Click += secileniSilBTN_Click;
            // 
            // hesapKesBTN
            // 
            hesapKesBTN.Location = new Point(591, 348);
            hesapKesBTN.Name = "hesapKesBTN";
            hesapKesBTN.Size = new Size(261, 67);
            hesapKesBTN.TabIndex = 4;
            hesapKesBTN.Text = "HESAP KES";
            hesapKesBTN.UseVisualStyleBackColor = true;
            hesapKesBTN.Click += hesapKesBTN_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(hesapKesBTN);
            Controls.Add(secileniSilBTN);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button masa4btn;
        private Button masa3btn;
        private Button masa2btn;
        private Button masa1btn;
        private Panel panel2;
        private Button suBtn;
        private Button cayBtn;
        private Button kahveBtn;
        private Button kolaBtn;
        private Button ayranBtn;
        private Button limonataBtn;
        private Button ihlamurBtn;
        private Button salepBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn urunDG;
        private DataGridViewTextBoxColumn fiyatDG;
        private Button secileniSilBTN;
        private Button hesapKesBTN;
        private Label label1;
    }
}