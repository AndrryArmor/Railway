
namespace GoodsOrdering
{
    partial class AddWagonForm
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
            this.addWagonButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.wagonTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.wagonNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maxLoadTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWagonButton
            // 
            this.addWagonButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addWagonButton.FlatAppearance.BorderSize = 0;
            this.addWagonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWagonButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWagonButton.Location = new System.Drawing.Point(12, 307);
            this.addWagonButton.Name = "addWagonButton";
            this.addWagonButton.Size = new System.Drawing.Size(250, 50);
            this.addWagonButton.TabIndex = 22;
            this.addWagonButton.Text = "Додати вагон";
            this.addWagonButton.UseVisualStyleBackColor = false;
            this.addWagonButton.Click += new System.EventHandler(this.addWagonButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.wagonTypeComboBox);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox7.Size = new System.Drawing.Size(250, 53);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Вид вагона";
            // 
            // wagonTypeComboBox
            // 
            this.wagonTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wagonTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wagonTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wagonTypeComboBox.Items.AddRange(new object[] {
            "Вагон",
            "Локомотив"});
            this.wagonTypeComboBox.Location = new System.Drawing.Point(5, 20);
            this.wagonTypeComboBox.Name = "wagonTypeComboBox";
            this.wagonTypeComboBox.Size = new System.Drawing.Size(240, 30);
            this.wagonTypeComboBox.TabIndex = 10;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.wagonNumberTextBox);
            this.groupBox8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(12, 71);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(250, 53);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Номер вагона";
            // 
            // wagonNumberTextBox
            // 
            this.wagonNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.wagonNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wagonNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wagonNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wagonNumberTextBox.Location = new System.Drawing.Point(3, 18);
            this.wagonNumberTextBox.MaxLength = 8;
            this.wagonNumberTextBox.Name = "wagonNumberTextBox";
            this.wagonNumberTextBox.Size = new System.Drawing.Size(244, 24);
            this.wagonNumberTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.maxLoadTextBox);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 53);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Макс. допустиме навантаження, т";
            // 
            // maxLoadTextBox
            // 
            this.maxLoadTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.maxLoadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxLoadTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLoadTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxLoadTextBox.Location = new System.Drawing.Point(3, 18);
            this.maxLoadTextBox.Name = "maxLoadTextBox";
            this.maxLoadTextBox.Size = new System.Drawing.Size(244, 24);
            this.maxLoadTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.weightTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 53);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Маса, т";
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.Location = new System.Drawing.Point(3, 18);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(244, 24);
            this.weightTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.volumeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Об\'єм, м3";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.volumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volumeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeTextBox.Location = new System.Drawing.Point(3, 18);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(244, 24);
            this.volumeTextBox.TabIndex = 0;
            // 
            // AddWagonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 363);
            this.Controls.Add(this.addWagonButton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddWagonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання вагона";
            this.Load += new System.EventHandler(this.AddWagonForm_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addWagonButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox wagonTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox wagonNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox maxLoadTextBox;
    }
}