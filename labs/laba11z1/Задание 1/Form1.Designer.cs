namespace Задание_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mean = new System.Windows.Forms.RichTextBox();
            this.Pol = new System.Windows.Forms.HScrollBar();
            this.Mean_n = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mean2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Mean
            // 
            this.Mean.Location = new System.Drawing.Point(156, 31);
            this.Mean.Margin = new System.Windows.Forms.Padding(2);
            this.Mean.Name = "Mean";
            this.Mean.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Mean.Size = new System.Drawing.Size(284, 27);
            this.Mean.TabIndex = 0;
            this.Mean.Text = "";
            this.Mean.WordWrap = false;
            // 
            // Pol
            // 
            this.Pol.Location = new System.Drawing.Point(223, 158);
            this.Pol.Name = "Pol";
            this.Pol.Size = new System.Drawing.Size(158, 26);
            this.Pol.TabIndex = 1;
            this.Pol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Mean_n
            // 
            this.Mean_n.Location = new System.Drawing.Point(156, 130);
            this.Mean_n.Margin = new System.Windows.Forms.Padding(2);
            this.Mean_n.Name = "Mean_n";
            this.Mean_n.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Mean_n.Size = new System.Drawing.Size(284, 27);
            this.Mean_n.TabIndex = 2;
            this.Mean_n.Text = "";
            this.Mean_n.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Значение n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вычисленное значение выражения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вычислить значение выражения -1+2-3+...+(-1)^n = (-1)^n[(n + 1) / 2]";
            // 
            // Mean2
            // 
            this.Mean2.Location = new System.Drawing.Point(156, 62);
            this.Mean2.Margin = new System.Windows.Forms.Padding(2);
            this.Mean2.Name = "Mean2";
            this.Mean2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Mean2.Size = new System.Drawing.Size(284, 27);
            this.Mean2.TabIndex = 6;
            this.Mean2.Text = "";
            this.Mean2.WordWrap = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Задание_1.Properties.Resources.aekljkwedfgt;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 367);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Mean2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mean_n);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Mean;
        private System.Windows.Forms.HScrollBar Pol;
        private System.Windows.Forms.RichTextBox Mean_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Mean2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

