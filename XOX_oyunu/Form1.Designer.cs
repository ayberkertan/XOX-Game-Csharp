namespace XOX_oyunu
{
    partial class Form1
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
            lblTurn = new Label();
            gridPanel = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lblSkorX = new Label();
            lblSkorO = new Label();
            gridPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Location = new Point(24, 20);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(100, 28);
            lblTurn.TabIndex = 0;
            lblTurn.Text = "Sıra: X";
            // 
            // gridPanel
            // 
            gridPanel.ColumnCount = 3;
            gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            gridPanel.Controls.Add(button1, 0, 0);
            gridPanel.Controls.Add(button2, 1, 0);
            gridPanel.Controls.Add(button3, 2, 0);
            gridPanel.Controls.Add(button4, 0, 1);
            gridPanel.Controls.Add(button5, 1, 1);
            gridPanel.Controls.Add(button6, 2, 1);
            gridPanel.Controls.Add(button7, 0, 2);
            gridPanel.Controls.Add(button8, 1, 2);
            gridPanel.Controls.Add(button9, 2, 2);
            gridPanel.Location = new Point(24, 60);
            gridPanel.Name = "gridPanel";
            gridPanel.RowCount = 3;
            gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            gridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            gridPanel.Size = new Size(300, 300);
            gridPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Name = "button1";
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += XOXtiklama;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Name = "button2";
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += XOXtiklama;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Name = "button3";
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += XOXtiklama;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Name = "button4";
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += XOXtiklama;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Name = "button5";
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += XOXtiklama;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Name = "button6";
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += XOXtiklama;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Name = "button7";
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += XOXtiklama;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Name = "button8";
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += XOXtiklama;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Name = "button9";
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += XOXtiklama;
            // 
            // lblSkorX
            // 
            lblSkorX.AutoSize = true;
            lblSkorX.Location = new Point(24, 380);
            lblSkorX.Name = "lblSkorX";
            lblSkorX.Size = new Size(120, 28);
            lblSkorX.TabIndex = 2;
            lblSkorX.Text = "Oyuncu 1 (X): 0";
            // 
            // lblSkorO
            // 
            lblSkorO.AutoSize = true;
            lblSkorO.Location = new Point(24, 420);
            lblSkorO.Name = "lblSkorO";
            lblSkorO.Size = new Size(120, 28);
            lblSkorO.TabIndex = 3;
            lblSkorO.Text = "Oyuncu 2 (O): 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 470);
            Controls.Add(lblSkorO);
            Controls.Add(lblSkorX);
            Controls.Add(gridPanel);
            Controls.Add(lblTurn);
            Name = "Form1";
            Text = "XOX Oyunu";
            FormClosed += Form1_FormClosed;
            gridPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTurn;
        private TableLayoutPanel gridPanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label lblSkorX;
        private Label lblSkorO;
    }
}
