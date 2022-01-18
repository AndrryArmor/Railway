
namespace GoodsOrdering
{
    partial class MakeOrderForm
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
            this.trainsDataGridView = new System.Windows.Forms.DataGridView();
            this.trainIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainDriverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainWeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.locomotiveGroupBox = new System.Windows.Forms.GroupBox();
            this.locomotiveComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentTrainLoadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wagonsDataGridView = new System.Windows.Forms.DataGridView();
            this.wagonNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonWeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonMaxLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addWagonComboBox = new System.Windows.Forms.ComboBox();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.addTrainButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderVolumeTextBox = new System.Windows.Forms.TextBox();
            this.orderWeightTextBox = new System.Windows.Forms.TextBox();
            this.driverGroupBox = new System.Windows.Forms.GroupBox();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.totalWeightTextBox = new System.Windows.Forms.TextBox();
            this.totalVolumeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainsDataGridView)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.locomotiveGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagonsDataGridView)).BeginInit();
            this.driverGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainsDataGridView
            // 
            this.trainsDataGridView.AllowUserToAddRows = false;
            this.trainsDataGridView.AllowUserToDeleteRows = false;
            this.trainsDataGridView.AllowUserToResizeColumns = false;
            this.trainsDataGridView.AllowUserToResizeRows = false;
            this.trainsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.trainsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.trainsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trainsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainIDColumn,
            this.trainDriverColumn,
            this.wagonCountColumn,
            this.trainWeightColumn,
            this.trainVolumeColumn});
            this.trainsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.trainsDataGridView.MultiSelect = false;
            this.trainsDataGridView.Name = "trainsDataGridView";
            this.trainsDataGridView.ReadOnly = true;
            this.trainsDataGridView.RowHeadersVisible = false;
            this.trainsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.trainsDataGridView.RowTemplate.ReadOnly = true;
            this.trainsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trainsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainsDataGridView.Size = new System.Drawing.Size(355, 270);
            this.trainsDataGridView.TabIndex = 20;
            // 
            // trainIDColumn
            // 
            this.trainIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trainIDColumn.HeaderText = "ID";
            this.trainIDColumn.Name = "trainIDColumn";
            this.trainIDColumn.ReadOnly = true;
            this.trainIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trainIDColumn.Width = 45;
            // 
            // trainDriverColumn
            // 
            this.trainDriverColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trainDriverColumn.HeaderText = "Машиніст";
            this.trainDriverColumn.Name = "trainDriverColumn";
            this.trainDriverColumn.ReadOnly = true;
            this.trainDriverColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trainDriverColumn.Width = 93;
            // 
            // wagonCountColumn
            // 
            this.wagonCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonCountColumn.HeaderText = "Кількість вагонів";
            this.wagonCountColumn.Name = "wagonCountColumn";
            this.wagonCountColumn.ReadOnly = true;
            this.wagonCountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonCountColumn.Width = 117;
            // 
            // trainWeightColumn
            // 
            this.trainWeightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trainWeightColumn.HeaderText = "Маса";
            this.trainWeightColumn.Name = "trainWeightColumn";
            this.trainWeightColumn.ReadOnly = true;
            this.trainWeightColumn.Width = 68;
            // 
            // trainVolumeColumn
            // 
            this.trainVolumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trainVolumeColumn.HeaderText = "Об\'єм";
            this.trainVolumeColumn.Name = "trainVolumeColumn";
            this.trainVolumeColumn.ReadOnly = true;
            this.trainVolumeColumn.Width = 72;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.trainsDataGridView);
            this.groupBox8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(12, 127);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(361, 291);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Поїзди";
            // 
            // locomotiveGroupBox
            // 
            this.locomotiveGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.locomotiveGroupBox.Controls.Add(this.locomotiveComboBox);
            this.locomotiveGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locomotiveGroupBox.Location = new System.Drawing.Point(379, 12);
            this.locomotiveGroupBox.Name = "locomotiveGroupBox";
            this.locomotiveGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.locomotiveGroupBox.Size = new System.Drawing.Size(325, 53);
            this.locomotiveGroupBox.TabIndex = 22;
            this.locomotiveGroupBox.TabStop = false;
            this.locomotiveGroupBox.Text = "Локомотив";
            // 
            // locomotiveComboBox
            // 
            this.locomotiveComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locomotiveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locomotiveComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locomotiveComboBox.Items.AddRange(new object[] {
            "Меблі",
            "Пристрій",
            "Одяг"});
            this.locomotiveComboBox.Location = new System.Drawing.Point(5, 20);
            this.locomotiveComboBox.Name = "locomotiveComboBox";
            this.locomotiveComboBox.Size = new System.Drawing.Size(315, 30);
            this.locomotiveComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.currentTrainLoadTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.wagonsDataGridView);
            this.groupBox1.Controls.Add(this.addWagonComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(379, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(325, 291);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вагони";
            // 
            // currentTrainLoadTextBox
            // 
            this.currentTrainLoadTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentTrainLoadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentTrainLoadTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTrainLoadTextBox.Location = new System.Drawing.Point(187, 20);
            this.currentTrainLoadTextBox.Name = "currentTrainLoadTextBox";
            this.currentTrainLoadTextBox.ReadOnly = true;
            this.currentTrainLoadTextBox.Size = new System.Drawing.Size(133, 24);
            this.currentTrainLoadTextBox.TabIndex = 46;
            this.currentTrainLoadTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Додати вагон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Навантаженість, т:";
            // 
            // wagonsDataGridView
            // 
            this.wagonsDataGridView.AllowUserToAddRows = false;
            this.wagonsDataGridView.AllowUserToDeleteRows = false;
            this.wagonsDataGridView.AllowUserToResizeColumns = false;
            this.wagonsDataGridView.AllowUserToResizeRows = false;
            this.wagonsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.wagonsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.wagonsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wagonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wagonsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wagonNumberColumn,
            this.wagonWeightColumn,
            this.wagonVolumeColumn,
            this.wagonMaxLoadColumn});
            this.wagonsDataGridView.Location = new System.Drawing.Point(5, 103);
            this.wagonsDataGridView.MultiSelect = false;
            this.wagonsDataGridView.Name = "wagonsDataGridView";
            this.wagonsDataGridView.ReadOnly = true;
            this.wagonsDataGridView.RowHeadersVisible = false;
            this.wagonsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.wagonsDataGridView.RowTemplate.ReadOnly = true;
            this.wagonsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wagonsDataGridView.Size = new System.Drawing.Size(315, 180);
            this.wagonsDataGridView.TabIndex = 21;
            // 
            // wagonNumberColumn
            // 
            this.wagonNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonNumberColumn.HeaderText = "Номер";
            this.wagonNumberColumn.Name = "wagonNumberColumn";
            this.wagonNumberColumn.ReadOnly = true;
            this.wagonNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonNumberColumn.Width = 76;
            // 
            // wagonWeightColumn
            // 
            this.wagonWeightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonWeightColumn.HeaderText = "Маса";
            this.wagonWeightColumn.Name = "wagonWeightColumn";
            this.wagonWeightColumn.ReadOnly = true;
            this.wagonWeightColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonWeightColumn.Width = 68;
            // 
            // wagonVolumeColumn
            // 
            this.wagonVolumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonVolumeColumn.HeaderText = "Об\'єм";
            this.wagonVolumeColumn.Name = "wagonVolumeColumn";
            this.wagonVolumeColumn.ReadOnly = true;
            this.wagonVolumeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonVolumeColumn.Width = 72;
            // 
            // wagonMaxLoadColumn
            // 
            this.wagonMaxLoadColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonMaxLoadColumn.HeaderText = "Макс. навантаження";
            this.wagonMaxLoadColumn.Name = "wagonMaxLoadColumn";
            this.wagonMaxLoadColumn.ReadOnly = true;
            this.wagonMaxLoadColumn.Width = 144;
            // 
            // addWagonComboBox
            // 
            this.addWagonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addWagonComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWagonComboBox.Items.AddRange(new object[] {
            "Меблі",
            "Пристрій",
            "Одяг"});
            this.addWagonComboBox.Location = new System.Drawing.Point(5, 67);
            this.addWagonComboBox.Name = "addWagonComboBox";
            this.addWagonComboBox.Size = new System.Drawing.Size(315, 30);
            this.addWagonComboBox.TabIndex = 10;
            this.addWagonComboBox.SelectionChangeCommitted += new System.EventHandler(this.addWagonComboBox_SelectionChangeCommitted);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.makeOrderButton.FlatAppearance.BorderSize = 0;
            this.makeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeOrderButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeOrderButton.Location = new System.Drawing.Point(61, 424);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(250, 50);
            this.makeOrderButton.TabIndex = 24;
            this.makeOrderButton.Text = "Виконати замовлення";
            this.makeOrderButton.UseVisualStyleBackColor = false;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // addTrainButton
            // 
            this.addTrainButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addTrainButton.FlatAppearance.BorderSize = 0;
            this.addTrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTrainButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTrainButton.Location = new System.Drawing.Point(423, 424);
            this.addTrainButton.Name = "addTrainButton";
            this.addTrainButton.Size = new System.Drawing.Size(250, 50);
            this.addTrainButton.TabIndex = 25;
            this.addTrainButton.Text = "Додати поїзд";
            this.addTrainButton.UseVisualStyleBackColor = false;
            this.addTrainButton.Click += new System.EventHandler(this.addTrainButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Маса товару, т:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Об\'єм товару, м3:";
            // 
            // orderVolumeTextBox
            // 
            this.orderVolumeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderVolumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderVolumeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderVolumeTextBox.Location = new System.Drawing.Point(292, 39);
            this.orderVolumeTextBox.Name = "orderVolumeTextBox";
            this.orderVolumeTextBox.ReadOnly = true;
            this.orderVolumeTextBox.Size = new System.Drawing.Size(81, 24);
            this.orderVolumeTextBox.TabIndex = 40;
            this.orderVolumeTextBox.Text = "0";
            // 
            // orderWeightTextBox
            // 
            this.orderWeightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderWeightTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderWeightTextBox.Location = new System.Drawing.Point(292, 9);
            this.orderWeightTextBox.Name = "orderWeightTextBox";
            this.orderWeightTextBox.ReadOnly = true;
            this.orderWeightTextBox.Size = new System.Drawing.Size(81, 24);
            this.orderWeightTextBox.TabIndex = 41;
            this.orderWeightTextBox.Text = "0";
            // 
            // driverGroupBox
            // 
            this.driverGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.driverGroupBox.Controls.Add(this.driverComboBox);
            this.driverGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverGroupBox.Location = new System.Drawing.Point(379, 71);
            this.driverGroupBox.Name = "driverGroupBox";
            this.driverGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.driverGroupBox.Size = new System.Drawing.Size(325, 53);
            this.driverGroupBox.TabIndex = 23;
            this.driverGroupBox.TabStop = false;
            this.driverGroupBox.Text = "Машиніст";
            // 
            // driverComboBox
            // 
            this.driverComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverComboBox.Items.AddRange(new object[] {
            "Меблі",
            "Пристрій",
            "Одяг"});
            this.driverComboBox.Location = new System.Drawing.Point(5, 20);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(315, 30);
            this.driverComboBox.TabIndex = 10;
            // 
            // totalWeightTextBox
            // 
            this.totalWeightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalWeightTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalWeightTextBox.Location = new System.Drawing.Point(292, 69);
            this.totalWeightTextBox.Name = "totalWeightTextBox";
            this.totalWeightTextBox.ReadOnly = true;
            this.totalWeightTextBox.Size = new System.Drawing.Size(81, 24);
            this.totalWeightTextBox.TabIndex = 45;
            this.totalWeightTextBox.Text = "0";
            // 
            // totalVolumeTextBox
            // 
            this.totalVolumeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalVolumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalVolumeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalVolumeTextBox.Location = new System.Drawing.Point(292, 99);
            this.totalVolumeTextBox.Name = "totalVolumeTextBox";
            this.totalVolumeTextBox.ReadOnly = true;
            this.totalVolumeTextBox.Size = new System.Drawing.Size(81, 24);
            this.totalVolumeTextBox.TabIndex = 44;
            this.totalVolumeTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Загальний об\'єм поїзда, м3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Загальна макс. маса, т:";
            // 
            // MakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 486);
            this.Controls.Add(this.totalWeightTextBox);
            this.Controls.Add(this.totalVolumeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.driverGroupBox);
            this.Controls.Add(this.orderWeightTextBox);
            this.Controls.Add(this.orderVolumeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTrainButton);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.locomotiveGroupBox);
            this.Controls.Add(this.groupBox8);
            this.Name = "MakeOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виконання замовлення";
            this.Load += new System.EventHandler(this.MakeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainsDataGridView)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.locomotiveGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagonsDataGridView)).EndInit();
            this.driverGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView trainsDataGridView;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox locomotiveGroupBox;
        private System.Windows.Forms.ComboBox locomotiveComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox addWagonComboBox;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.DataGridView wagonsDataGridView;
        private System.Windows.Forms.Button addTrainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderVolumeTextBox;
        private System.Windows.Forms.TextBox orderWeightTextBox;
        private System.Windows.Forms.GroupBox driverGroupBox;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainDriverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainWeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonWeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonMaxLoadColumn;
        private System.Windows.Forms.TextBox totalWeightTextBox;
        private System.Windows.Forms.TextBox totalVolumeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentTrainLoadTextBox;
    }
}