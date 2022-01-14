
namespace lab10
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
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.thirdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intToString = new System.Windows.Forms.Button();
            this.intSort = new System.Windows.Forms.Button();
            this.stringToString = new System.Windows.Forms.Button();
            this.stringSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.personToString = new System.Windows.Forms.Button();
            this.personSort = new System.Windows.Forms.Button();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(66, 262);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(399, 159);
            this.ContentTextBox.TabIndex = 0;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(66, 25);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstTextBox.TabIndex = 1;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(215, 25);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(100, 22);
            this.secondTextBox.TabIndex = 2;
            // 
            // thirdTextBox
            // 
            this.thirdTextBox.Location = new System.Drawing.Point(365, 25);
            this.thirdTextBox.Name = "thirdTextBox";
            this.thirdTextBox.Size = new System.Drawing.Size(100, 22);
            this.thirdTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "String";
            // 
            // intToString
            // 
            this.intToString.Location = new System.Drawing.Point(535, 77);
            this.intToString.Name = "intToString";
            this.intToString.Size = new System.Drawing.Size(75, 23);
            this.intToString.TabIndex = 8;
            this.intToString.Text = "toString";
            this.intToString.UseVisualStyleBackColor = true;
            this.intToString.Click += new System.EventHandler(this.intToString_Click);
            // 
            // intSort
            // 
            this.intSort.Location = new System.Drawing.Point(535, 137);
            this.intSort.Name = "intSort";
            this.intSort.Size = new System.Drawing.Size(75, 23);
            this.intSort.TabIndex = 9;
            this.intSort.Text = "Sort";
            this.intSort.UseVisualStyleBackColor = true;
            this.intSort.Click += new System.EventHandler(this.intSort_Click);
            // 
            // stringToString
            // 
            this.stringToString.Location = new System.Drawing.Point(688, 77);
            this.stringToString.Name = "stringToString";
            this.stringToString.Size = new System.Drawing.Size(75, 23);
            this.stringToString.TabIndex = 10;
            this.stringToString.Text = "toString";
            this.stringToString.UseVisualStyleBackColor = true;
            this.stringToString.Click += new System.EventHandler(this.stringToString_Click);
            // 
            // stringSort
            // 
            this.stringSort.Location = new System.Drawing.Point(688, 137);
            this.stringSort.Name = "stringSort";
            this.stringSort.Size = new System.Drawing.Size(75, 23);
            this.stringSort.TabIndex = 11;
            this.stringSort.Text = "Sort";
            this.stringSort.UseVisualStyleBackColor = true;
            this.stringSort.Click += new System.EventHandler(this.stringSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Person";
            // 
            // personToString
            // 
            this.personToString.Location = new System.Drawing.Point(612, 285);
            this.personToString.Name = "personToString";
            this.personToString.Size = new System.Drawing.Size(75, 23);
            this.personToString.TabIndex = 13;
            this.personToString.Text = "toString";
            this.personToString.UseVisualStyleBackColor = true;
            this.personToString.Click += new System.EventHandler(this.personToString_Click);
            // 
            // personSort
            // 
            this.personSort.Location = new System.Drawing.Point(612, 347);
            this.personSort.Name = "personSort";
            this.personSort.Size = new System.Drawing.Size(75, 23);
            this.personSort.TabIndex = 14;
            this.personSort.Text = "Sort";
            this.personSort.UseVisualStyleBackColor = true;
            this.personSort.Click += new System.EventHandler(this.personSort_Click);
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(96, 122);
            this.personTextBox.Multiline = true;
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(342, 131);
            this.personTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Person Text Box";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Imie Nazwisko Waga Wiek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.personSort);
            this.Controls.Add(this.personToString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stringSort);
            this.Controls.Add(this.stringToString);
            this.Controls.Add(this.intSort);
            this.Controls.Add(this.intToString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thirdTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.ContentTextBox);
            this.Name = "Form1";
            this.Text = "Trojka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox thirdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button intToString;
        private System.Windows.Forms.Button intSort;
        private System.Windows.Forms.Button stringToString;
        private System.Windows.Forms.Button stringSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button personToString;
        private System.Windows.Forms.Button personSort;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

