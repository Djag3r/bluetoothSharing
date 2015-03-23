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
            this.sharingbutton = new System.Windows.Forms.Button();
            this.getbutton = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
            this.buildlabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.gamefunlinklabel = new System.Windows.Forms.LinkLabel();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sharingbutton
            // 
            this.sharingbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sharingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sharingbutton.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sharingbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sharingbutton.Location = new System.Drawing.Point(12, 38);
            this.sharingbutton.Name = "sharingbutton";
            this.sharingbutton.Size = new System.Drawing.Size(273, 53);
            this.sharingbutton.TabIndex = 0;
            this.sharingbutton.Text = "Передача файлов";
            this.sharingbutton.UseVisualStyleBackColor = false;
            // 
            // getbutton
            // 
            this.getbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.getbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getbutton.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.getbutton.Location = new System.Drawing.Point(12, 109);
            this.getbutton.Name = "getbutton";
            this.getbutton.Size = new System.Drawing.Size(273, 53);
            this.getbutton.TabIndex = 1;
            this.getbutton.Text = "Принятие файлов";
            this.getbutton.UseVisualStyleBackColor = false;
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
            // settingsbutton
            // 
            this.settingsbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingsbutton.BackgroundImage = global::bluetoothSharing.Properties.Resources.settings;
            this.settingsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbutton.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsbutton.Location = new System.Drawing.Point(12, 222);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(32, 32);
            this.settingsbutton.TabIndex = 3;
            this.settingsbutton.UseVisualStyleBackColor = false;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.namelabel.Location = new System.Drawing.Point(11, 22);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(153, 13);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "Bluetooth Sharing for Windows";
            this.namelabel.Visible = false;
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.versionlabel.Location = new System.Drawing.Point(11, 35);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(45, 13);
            this.versionlabel.TabIndex = 5;
            this.versionlabel.Text = "Version:";
            this.versionlabel.Visible = false;
            // 
            // buildlabel
            // 
            this.buildlabel.AutoSize = true;
            this.buildlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buildlabel.Location = new System.Drawing.Point(62, 35);
            this.buildlabel.Name = "buildlabel";
            this.buildlabel.Size = new System.Drawing.Size(57, 13);
            this.buildlabel.TabIndex = 6;
            this.buildlabel.Text = "0.1 (1D04)";
            this.buildlabel.Visible = false;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datelabel.Location = new System.Drawing.Point(66, 48);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(58, 13);
            this.datelabel.TabIndex = 7;
            this.datelabel.Text = "2011-2015";
            this.datelabel.Visible = false;
            // 
            // gamefunlinklabel
            // 
            this.gamefunlinklabel.AutoSize = true;
            this.gamefunlinklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gamefunlinklabel.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gamefunlinklabel.Location = new System.Drawing.Point(11, 48);
            this.gamefunlinklabel.Name = "gamefunlinklabel";
            this.gamefunlinklabel.Size = new System.Drawing.Size(58, 13);
            this.gamefunlinklabel.TabIndex = 8;
            this.gamefunlinklabel.TabStop = true;
            this.gamefunlinklabel.Text = "GameFuN,";
            this.gamefunlinklabel.Visible = false;
            this.gamefunlinklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gamefunlinklabel_LinkClicked);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.namelabel);
            this.groupbox.Controls.Add(this.gamefunlinklabel);
            this.groupbox.Controls.Add(this.buildlabel);
            this.groupbox.Controls.Add(this.datelabel);
            this.groupbox.Controls.Add(this.versionlabel);
            this.groupbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupbox.Location = new System.Drawing.Point(74, 183);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(173, 71);
            this.groupbox.TabIndex = 9;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Информация";
            this.groupbox.Visible = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(297, 266);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.settingsbutton);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.getbutton);
            this.Controls.Add(this.sharingbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Sharing ";
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sharingbutton;
        private System.Windows.Forms.Button getbutton;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.Button settingsbutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.Label buildlabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.LinkLabel gamefunlinklabel;
        private System.Windows.Forms.GroupBox groupbox;
    }
}

