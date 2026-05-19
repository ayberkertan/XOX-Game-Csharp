namespace XOX_oyunu
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtOyuncu2 = new TextBox();
            txtOyuncu1 = new TextBox();
            btnBasla = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 120);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "Oyuncu 1 (X) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 170);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 1;
            label2.Text = "Oyuncu 2 (O) :";
            // 
            // txtOyuncu2
            // 
            txtOyuncu2.Location = new Point(170, 172);
            txtOyuncu2.Name = "txtOyuncu2";
            txtOyuncu2.Size = new Size(200, 23);
            txtOyuncu2.TabIndex = 2;
            // 
            // txtOyuncu1
            // 
            txtOyuncu1.Location = new Point(170, 122);
            txtOyuncu1.Name = "txtOyuncu1";
            txtOyuncu1.Size = new Size(200, 23);
            txtOyuncu1.TabIndex = 1;
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(120, 240);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(160, 48);
            btnBasla.TabIndex = 3;
            btnBasla.Text = "BAŞLA";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 40);
            label3.Name = "label3";
            label3.Size = new Size(297, 37);
            label3.TabIndex = 4;
            label3.Text = "Oyuncu İsimlerini Giriniz";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 320);
            Controls.Add(label3);
            Controls.Add(btnBasla);
            Controls.Add(txtOyuncu1);
            Controls.Add(txtOyuncu2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "XOX Oyunu - Oyuncu Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOyuncu2;
        private TextBox txtOyuncu1;
        private Button btnBasla;
        private Label label3;
    }
}
