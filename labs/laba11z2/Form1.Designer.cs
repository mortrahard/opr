namespace laba11z2
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.generateButton_Click = new System.Windows.Forms.Button();
            this.readButton_Click = new System.Windows.Forms.Button();
            this.searchButton_Click = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(252, 338);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // generateButton_Click
            // 
            this.generateButton_Click.Location = new System.Drawing.Point(77, 337);
            this.generateButton_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateButton_Click.Name = "generateButton_Click";
            this.generateButton_Click.Size = new System.Drawing.Size(76, 20);
            this.generateButton_Click.TabIndex = 1;
            this.generateButton_Click.Text = "Создать";
            this.generateButton_Click.UseVisualStyleBackColor = true;
            this.generateButton_Click.Click += new System.EventHandler(this.generateButton_Click_Click);
            // 
            // readButton_Click
            // 
            this.readButton_Click.Location = new System.Drawing.Point(158, 337);
            this.readButton_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readButton_Click.Name = "readButton_Click";
            this.readButton_Click.Size = new System.Drawing.Size(74, 20);
            this.readButton_Click.TabIndex = 2;
            this.readButton_Click.Text = "Отобразить";
            this.readButton_Click.UseVisualStyleBackColor = true;
            this.readButton_Click.Click += new System.EventHandler(this.readButton_Click_Click);
            // 
            // searchButton_Click
            // 
            this.searchButton_Click.Location = new System.Drawing.Point(380, 338);
            this.searchButton_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton_Click.Name = "searchButton_Click";
            this.searchButton_Click.Size = new System.Drawing.Size(56, 19);
            this.searchButton_Click.TabIndex = 3;
            this.searchButton_Click.Text = "Поиск";
            this.searchButton_Click.UseVisualStyleBackColor = true;
            this.searchButton_Click.Click += new System.EventHandler(this.searchButton_Click_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(-2, -1);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 304);
            this.listBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::laba11z2.Properties.Resources.bca07c26_7666_44c4_acb7_8fca6826e5e0_ezgif_com_resize;
            this.pictureBox1.Location = new System.Drawing.Point(437, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 406);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::laba11z2.Properties.Resources.photo_5253479760699448133_x__1_;
            this.pictureBox2.Location = new System.Drawing.Point(332, 206);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 97);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 379);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchButton_Click);
            this.Controls.Add(this.readButton_Click);
            this.Controls.Add(this.generateButton_Click);
            this.Controls.Add(this.searchTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button generateButton_Click;
        private System.Windows.Forms.Button readButton_Click;
        private System.Windows.Forms.Button searchButton_Click;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

