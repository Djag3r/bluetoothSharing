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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.transfer = new System.Windows.Forms.Button();
            this.get = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.waiting = new System.Windows.Forms.Label();
            this.gamefunlabel = new System.Windows.Forms.LinkLabel();
            this.wait_progressbar = new System.Windows.Forms.ProgressBar();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.transfer.Location = new System.Drawing.Point(12, 12);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(261, 53);
            this.transfer.TabIndex = 0;
            this.transfer.Text = "Передача файлов";
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // get
            // 
            this.get.BackColor = System.Drawing.SystemColors.ControlDark;
            this.get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get.ForeColor = System.Drawing.SystemColors.ControlText;
            this.get.Location = new System.Drawing.Point(12, 71);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(261, 53);
            this.get.TabIndex = 1;
            this.get.Text = "Принятие файлов";
            this.get.UseVisualStyleBackColor = false;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.SystemColors.ControlText;
            this.version.Location = new System.Drawing.Point(12, 185);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 21);
            this.version.TabIndex = 4;
            this.version.Text = "0.0.1";
            // 
            // waiting
            // 
            this.waiting.AutoSize = true;
            this.waiting.BackColor = System.Drawing.Color.Transparent;
            this.waiting.Enabled = false;
            this.waiting.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waiting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.waiting.Location = new System.Drawing.Point(9, 129);
            this.waiting.Name = "waiting";
            this.waiting.Size = new System.Drawing.Size(171, 16);
            this.waiting.TabIndex = 6;
            this.waiting.Text = "Ожидание передачи файлов...";
            this.waiting.Visible = false;
            // 
            // gamefunlabel
            // 
            this.gamefunlabel.AutoSize = true;
            this.gamefunlabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamefunlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gamefunlabel.Location = new System.Drawing.Point(103, 185);
            this.gamefunlabel.Name = "gamefunlabel";
            this.gamefunlabel.Size = new System.Drawing.Size(170, 21);
            this.gamefunlabel.TabIndex = 7;
            this.gamefunlabel.TabStop = true;
            this.gamefunlabel.Text = "GameFuN, 2011-2016";
            this.gamefunlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gamefunlabel_LinkClicked);
            // 
            // wait_progressbar
            // 
            this.wait_progressbar.Enabled = false;
            this.wait_progressbar.Location = new System.Drawing.Point(12, 152);
            this.wait_progressbar.Name = "wait_progressbar";
            this.wait_progressbar.Size = new System.Drawing.Size(261, 23);
            this.wait_progressbar.Step = 1;
            this.wait_progressbar.TabIndex = 8;
            this.wait_progressbar.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settings.BackgroundImage = global::bluetoothSharing.Properties.Resources.settings;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Location = new System.Drawing.Point(65, 181);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(32, 32);
            this.settings.TabIndex = 9;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(282, 219);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.wait_progressbar);
            this.Controls.Add(this.gamefunlabel);
            this.Controls.Add(this.waiting);
            this.Controls.Add(this.version);
            this.Controls.Add(this.get);
            this.Controls.Add(this.transfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Sharing ";
            this.Load += new System.EventHandler(this.General_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button transfer;
        public System.Windows.Forms.Button get;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label waiting;
        private System.Windows.Forms.LinkLabel gamefunlabel;
        private System.Windows.Forms.ProgressBar wait_progressbar;
        public System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button settings;
        public System.Windows.Forms.Timer timer;
    }
}

