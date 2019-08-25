namespace УгадайЧисло
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butPlayRestart = new System.Windows.Forms.Button();
            this.tBoxMyNumber = new System.Windows.Forms.TextBox();
            this.butTry = new System.Windows.Forms.Button();
            this.labelCountTry = new System.Windows.Forms.Label();
            this.labelMoreLess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Я загадал число от 0 до 100. Угадай!";
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(12, 130);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(131, 28);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butPlayRestart
            // 
            this.butPlayRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPlayRestart.Location = new System.Drawing.Point(196, 130);
            this.butPlayRestart.Name = "butPlayRestart";
            this.butPlayRestart.Size = new System.Drawing.Size(131, 28);
            this.butPlayRestart.TabIndex = 3;
            this.butPlayRestart.Text = "Играть";
            this.butPlayRestart.UseVisualStyleBackColor = true;
            this.butPlayRestart.Click += new System.EventHandler(this.butPlayRestart_Click);
            // 
            // tBoxMyNumber
            // 
            this.tBoxMyNumber.Enabled = false;
            this.tBoxMyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxMyNumber.Location = new System.Drawing.Point(12, 56);
            this.tBoxMyNumber.MaxLength = 10;
            this.tBoxMyNumber.Name = "tBoxMyNumber";
            this.tBoxMyNumber.Size = new System.Drawing.Size(92, 26);
            this.tBoxMyNumber.TabIndex = 4;
            this.tBoxMyNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxMyNumber_KeyPress);
            // 
            // butTry
            // 
            this.butTry.Enabled = false;
            this.butTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTry.Location = new System.Drawing.Point(110, 56);
            this.butTry.Name = "butTry";
            this.butTry.Size = new System.Drawing.Size(89, 26);
            this.butTry.TabIndex = 5;
            this.butTry.Text = "Проверить";
            this.butTry.UseVisualStyleBackColor = true;
            this.butTry.Click += new System.EventHandler(this.butTry_Click);
            // 
            // labelCountTry
            // 
            this.labelCountTry.AutoSize = true;
            this.labelCountTry.Enabled = false;
            this.labelCountTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountTry.Location = new System.Drawing.Point(13, 97);
            this.labelCountTry.Name = "labelCountTry";
            this.labelCountTry.Size = new System.Drawing.Size(150, 18);
            this.labelCountTry.TabIndex = 6;
            this.labelCountTry.Text = "Сделано попыток: 0";
            // 
            // labelMoreLess
            // 
            this.labelMoreLess.AutoSize = true;
            this.labelMoreLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoreLess.Location = new System.Drawing.Point(205, 62);
            this.labelMoreLess.Name = "labelMoreLess";
            this.labelMoreLess.Size = new System.Drawing.Size(0, 16);
            this.labelMoreLess.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 170);
            this.Controls.Add(this.labelMoreLess);
            this.Controls.Add(this.labelCountTry);
            this.Controls.Add(this.butTry);
            this.Controls.Add(this.tBoxMyNumber);
            this.Controls.Add(this.butPlayRestart);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butPlayRestart;
        private System.Windows.Forms.TextBox tBoxMyNumber;
        private System.Windows.Forms.Button butTry;
        private System.Windows.Forms.Label labelCountTry;
        private System.Windows.Forms.Label labelMoreLess;
    }
}

