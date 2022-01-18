namespace GoodsOrdering
{
    partial class EnterForm
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
            System.Windows.Forms.Label titleLabel;
            this.enterButton = new System.Windows.Forms.Button();
            this.stationGroupBox = new System.Windows.Forms.GroupBox();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.centerPanel = new System.Windows.Forms.Panel();
            titleLabel = new System.Windows.Forms.Label();
            this.stationGroupBox.SuspendLayout();
            this.accountGroupBox.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            titleLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(778, 55);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "База даних \"Залізниця\"";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.PeachPuff;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(100, 134);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(200, 50);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Виконати вхід";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // stationGroupBox
            // 
            this.stationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.stationGroupBox.Controls.Add(this.stationComboBox);
            this.stationGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationGroupBox.Location = new System.Drawing.Point(25, 16);
            this.stationGroupBox.Name = "stationGroupBox";
            this.stationGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.stationGroupBox.Size = new System.Drawing.Size(350, 53);
            this.stationGroupBox.TabIndex = 5;
            this.stationGroupBox.TabStop = false;
            this.stationGroupBox.Text = "Оберіть станцію";
            // 
            // stationComboBox
            // 
            this.stationComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stationComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationComboBox.Location = new System.Drawing.Point(5, 20);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(340, 30);
            this.stationComboBox.TabIndex = 11;
            this.stationComboBox.SelectedIndexChanged += new System.EventHandler(this.stationComboBox_SelectedIndexChanged);
            // 
            // accountGroupBox
            // 
            this.accountGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.accountGroupBox.Controls.Add(this.accountComboBox);
            this.accountGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountGroupBox.Location = new System.Drawing.Point(25, 75);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.accountGroupBox.Size = new System.Drawing.Size(350, 53);
            this.accountGroupBox.TabIndex = 6;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "Обліковий запис";
            // 
            // accountComboBox
            // 
            this.accountComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountComboBox.Items.AddRange(new object[] {
            ""});
            this.accountComboBox.Location = new System.Drawing.Point(5, 20);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(340, 30);
            this.accountComboBox.TabIndex = 11;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Controls.Add(this.stationGroupBox);
            this.centerPanel.Controls.Add(this.accountGroupBox);
            this.centerPanel.Controls.Add(this.enterButton);
            this.centerPanel.Location = new System.Drawing.Point(189, 80);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(400, 200);
            this.centerPanel.TabIndex = 7;
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GoodsOrdering.Properties.Resources.Фон_початкової_сторінки_програми_залізниці_затінений;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(778, 361);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База даних \"Залізниця\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.stationGroupBox.ResumeLayout(false);
            this.accountGroupBox.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.GroupBox stationGroupBox;
        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.ComboBox accountComboBox;
    }
}