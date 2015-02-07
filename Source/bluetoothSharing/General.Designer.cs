namespace bluetoothSharing
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Передача файлов";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(12, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Принятие файлов";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // infobutton
            // 
            this.infobutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.infobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infobutton.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infobutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infobutton.Location = new System.Drawing.Point(253, 222);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(32, 32);
            this.infobutton.TabIndex = 2;
            this.infobutton.Text = "?";
            this.infobutton.UseVisualStyleBackColor = false;
            this.infobutton.Click += new System.EventHandler(this.infobutton_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(297, 266);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "General";
            this.Text = "Bluetooth Sharing ";
            this.Load += new System.EventHandler(this.General_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button infobutton;
    }
}

