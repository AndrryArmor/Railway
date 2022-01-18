namespace GoodsOrdering
{
    partial class MainForm
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
            System.Windows.Forms.Label beginDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label totalOrdersFulfilledLabel;
            System.Windows.Forms.Label totalGoodsWeightTransportedLabel;
            System.Windows.Forms.Label totalGoodsVolumeTransportedLabel;
            this.addOrderButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodWeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.creationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.changeOrderButton = new System.Windows.Forms.Button();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.repairsTabPage = new System.Windows.Forms.TabPage();
            this.repairsGroupBox = new System.Windows.Forms.GroupBox();
            this.repairsDataGridView = new System.Windows.Forms.DataGridView();
            this.repairIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairedWagonIDNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLocomotiveRepairedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repairDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeWagonButton = new System.Windows.Forms.Button();
            this.wagonsToRepairGroupBox = new System.Windows.Forms.GroupBox();
            this.wagonsDataGridView = new System.Windows.Forms.DataGridView();
            this.wagonIDNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLocomotiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addWagonButton = new System.Windows.Forms.Button();
            this.repairButton = new System.Windows.Forms.Button();
            this.personnelTabPage = new System.Windows.Forms.TabPage();
            this.changeEmployeeInfoButton = new System.Windows.Forms.Button();
            this.appointButton = new System.Windows.Forms.Button();
            this.dismissButton = new System.Windows.Forms.Button();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTelephoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeStationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportationStatisticsTabPage = new System.Windows.Forms.TabPage();
            this.totalGoodsVolumeTransportedTextBox = new System.Windows.Forms.TextBox();
            this.totalGoodsWeightTransportedTextBox = new System.Windows.Forms.TextBox();
            this.totalOrdersFulfilledTextBox = new System.Windows.Forms.TextBox();
            this.customersGroupBox = new System.Windows.Forms.GroupBox();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonsGroupBox = new System.Windows.Forms.GroupBox();
            this.wagonsStatsDataGridView = new System.Windows.Forms.DataGridView();
            this.stationsGroupBox = new System.Windows.Forms.GroupBox();
            this.stationsDataGridView = new System.Windows.Forms.DataGridView();
            this.stationIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDepartureStationCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asArrivalStationCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.currentUserEmployerGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserEmployerTextBox = new System.Windows.Forms.TextBox();
            this.currentUserAppointmentDateGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserAppointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.currentUserPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserPositionTextBox = new System.Windows.Forms.TextBox();
            this.currentUserStationGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserStationTextBox = new System.Windows.Forms.TextBox();
            this.currentUserIDNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserIDNumberTextBox = new System.Windows.Forms.TextBox();
            this.currentUserSurnameGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserSurnameTextBox = new System.Windows.Forms.TextBox();
            this.currentUserNameGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserNameTextBox = new System.Windows.Forms.TextBox();
            this.currentUserBirthDateGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserBirthDateTextBox = new System.Windows.Forms.TextBox();
            this.currentUserTelephoneNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.currentUserTelephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.wagonIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLocomotiveStatsColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wagonDistanceWentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asPartOfTrainsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonRepairsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            beginDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            totalOrdersFulfilledLabel = new System.Windows.Forms.Label();
            totalGoodsWeightTransportedLabel = new System.Windows.Forms.Label();
            totalGoodsVolumeTransportedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            this.repairsTabPage.SuspendLayout();
            this.repairsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataGridView)).BeginInit();
            this.wagonsToRepairGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagonsDataGridView)).BeginInit();
            this.personnelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.TransportationStatisticsTabPage.SuspendLayout();
            this.customersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.wagonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagonsStatsDataGridView)).BeginInit();
            this.stationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).BeginInit();
            this.statusTabPage.SuspendLayout();
            this.currentUserEmployerGroupBox.SuspendLayout();
            this.currentUserAppointmentDateGroupBox.SuspendLayout();
            this.currentUserPositionGroupBox.SuspendLayout();
            this.currentUserStationGroupBox.SuspendLayout();
            this.currentUserIDNumberGroupBox.SuspendLayout();
            this.currentUserSurnameGroupBox.SuspendLayout();
            this.currentUserNameGroupBox.SuspendLayout();
            this.currentUserBirthDateGroupBox.SuspendLayout();
            this.currentUserTelephoneNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // beginDateLabel
            // 
            beginDateLabel.AutoSize = true;
            beginDateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            beginDateLabel.Location = new System.Drawing.Point(3, 9);
            beginDateLabel.Name = "beginDateLabel";
            beginDateLabel.Size = new System.Drawing.Size(21, 22);
            beginDateLabel.TabIndex = 29;
            beginDateLabel.Text = "З";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endDateLabel.Location = new System.Drawing.Point(3, 46);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(35, 22);
            endDateLabel.TabIndex = 30;
            endDateLabel.Text = "По";
            // 
            // totalOrdersFulfilledLabel
            // 
            totalOrdersFulfilledLabel.AutoSize = true;
            totalOrdersFulfilledLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalOrdersFulfilledLabel.Location = new System.Drawing.Point(3, 116);
            totalOrdersFulfilledLabel.Name = "totalOrdersFulfilledLabel";
            totalOrdersFulfilledLabel.Size = new System.Drawing.Size(314, 22);
            totalOrdersFulfilledLabel.TabIndex = 36;
            totalOrdersFulfilledLabel.Text = "Всього замовлень виконано, шт:";
            // 
            // totalGoodsWeightTransportedLabel
            // 
            totalGoodsWeightTransportedLabel.AutoSize = true;
            totalGoodsWeightTransportedLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalGoodsWeightTransportedLabel.Location = new System.Drawing.Point(3, 168);
            totalGoodsWeightTransportedLabel.Name = "totalGoodsWeightTransportedLabel";
            totalGoodsWeightTransportedLabel.Size = new System.Drawing.Size(283, 22);
            totalGoodsWeightTransportedLabel.TabIndex = 37;
            totalGoodsWeightTransportedLabel.Text = "Всього перевезено товарів, т:";
            // 
            // totalGoodsVolumeTransportedLabel
            // 
            totalGoodsVolumeTransportedLabel.AutoSize = true;
            totalGoodsVolumeTransportedLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalGoodsVolumeTransportedLabel.Location = new System.Drawing.Point(3, 220);
            totalGoodsVolumeTransportedLabel.Name = "totalGoodsVolumeTransportedLabel";
            totalGoodsVolumeTransportedLabel.Size = new System.Drawing.Size(300, 22);
            totalGoodsVolumeTransportedLabel.TabIndex = 38;
            totalGoodsVolumeTransportedLabel.Text = "Всього перевезено товарів, м³:";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addOrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.addOrderButton.FlatAppearance.BorderSize = 0;
            this.addOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrderButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(3, 578);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(250, 50);
            this.addOrderButton.TabIndex = 7;
            this.addOrderButton.Text = "Додати замовлення...";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ordersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDColumn,
            this.goodDescriptionColumn,
            this.customerColumn,
            this.goodWeightColumn,
            this.goodVolumeColumn,
            this.departureStationColumn,
            this.arrivalStationColumn,
            this.orderStatusColumn,
            this.creationDateColumn,
            this.executionDateColumn});
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDataGridView.RowTemplate.ReadOnly = true;
            this.ordersDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(870, 569);
            this.ordersDataGridView.TabIndex = 19;
            // 
            // orderIDColumn
            // 
            this.orderIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderIDColumn.HeaderText = "ID";
            this.orderIDColumn.Name = "orderIDColumn";
            this.orderIDColumn.ReadOnly = true;
            this.orderIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderIDColumn.Width = 46;
            // 
            // goodDescriptionColumn
            // 
            this.goodDescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodDescriptionColumn.HeaderText = "Опис товару";
            this.goodDescriptionColumn.Name = "goodDescriptionColumn";
            this.goodDescriptionColumn.ReadOnly = true;
            this.goodDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goodDescriptionColumn.Width = 106;
            // 
            // customerColumn
            // 
            this.customerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerColumn.HeaderText = "Замовник";
            this.customerColumn.Name = "customerColumn";
            this.customerColumn.ReadOnly = true;
            this.customerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerColumn.Width = 99;
            // 
            // goodWeightColumn
            // 
            this.goodWeightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodWeightColumn.HeaderText = "Маса товару";
            this.goodWeightColumn.Name = "goodWeightColumn";
            this.goodWeightColumn.ReadOnly = true;
            this.goodWeightColumn.Width = 108;
            // 
            // goodVolumeColumn
            // 
            this.goodVolumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodVolumeColumn.HeaderText = "Об\'єм товару";
            this.goodVolumeColumn.Name = "goodVolumeColumn";
            this.goodVolumeColumn.ReadOnly = true;
            this.goodVolumeColumn.Width = 113;
            // 
            // departureStationColumn
            // 
            this.departureStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departureStationColumn.HeaderText = "Станція відправлення";
            this.departureStationColumn.Name = "departureStationColumn";
            this.departureStationColumn.ReadOnly = true;
            this.departureStationColumn.Width = 158;
            // 
            // arrivalStationColumn
            // 
            this.arrivalStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arrivalStationColumn.HeaderText = "Станція прибуття";
            this.arrivalStationColumn.Name = "arrivalStationColumn";
            this.arrivalStationColumn.ReadOnly = true;
            this.arrivalStationColumn.Width = 131;
            // 
            // orderStatusColumn
            // 
            this.orderStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderStatusColumn.HeaderText = "Чи виконано";
            this.orderStatusColumn.Name = "orderStatusColumn";
            this.orderStatusColumn.ReadOnly = true;
            this.orderStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderStatusColumn.Width = 106;
            // 
            // creationDateColumn
            // 
            this.creationDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creationDateColumn.HeaderText = "Дата створення";
            this.creationDateColumn.Name = "creationDateColumn";
            this.creationDateColumn.ReadOnly = true;
            this.creationDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.creationDateColumn.Width = 125;
            // 
            // executionDateColumn
            // 
            this.executionDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.executionDateColumn.HeaderText = "Дата виконання";
            this.executionDateColumn.Name = "executionDateColumn";
            this.executionDateColumn.ReadOnly = true;
            this.executionDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.executionDateColumn.Width = 127;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(814, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 23);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Вийти 🡢";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.buttonToMain_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ordersTabPage);
            this.mainTabControl.Controls.Add(this.repairsTabPage);
            this.mainTabControl.Controls.Add(this.personnelTabPage);
            this.mainTabControl.Controls.Add(this.TransportationStatisticsTabPage);
            this.mainTabControl.Controls.Add(this.statusTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(884, 661);
            this.mainTabControl.TabIndex = 22;
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.changeOrderButton);
            this.ordersTabPage.Controls.Add(this.makeOrderButton);
            this.ordersTabPage.Controls.Add(this.ordersDataGridView);
            this.ordersTabPage.Controls.Add(this.addOrderButton);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 26);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTabPage.Size = new System.Drawing.Size(876, 631);
            this.ordersTabPage.TabIndex = 0;
            this.ordersTabPage.Text = "Замовлення";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeOrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.changeOrderButton.FlatAppearance.BorderSize = 0;
            this.changeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeOrderButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeOrderButton.Location = new System.Drawing.Point(313, 578);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(250, 50);
            this.changeOrderButton.TabIndex = 23;
            this.changeOrderButton.Text = "Змінити замовлення...";
            this.changeOrderButton.UseVisualStyleBackColor = false;
            this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.makeOrderButton.BackColor = System.Drawing.Color.PeachPuff;
            this.makeOrderButton.FlatAppearance.BorderSize = 0;
            this.makeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeOrderButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeOrderButton.Location = new System.Drawing.Point(623, 578);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(250, 50);
            this.makeOrderButton.TabIndex = 22;
            this.makeOrderButton.Text = "Виконати замовлення...";
            this.makeOrderButton.UseVisualStyleBackColor = false;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // repairsTabPage
            // 
            this.repairsTabPage.Controls.Add(this.repairsGroupBox);
            this.repairsTabPage.Controls.Add(this.removeWagonButton);
            this.repairsTabPage.Controls.Add(this.wagonsToRepairGroupBox);
            this.repairsTabPage.Controls.Add(this.addWagonButton);
            this.repairsTabPage.Controls.Add(this.repairButton);
            this.repairsTabPage.Location = new System.Drawing.Point(4, 26);
            this.repairsTabPage.Name = "repairsTabPage";
            this.repairsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.repairsTabPage.Size = new System.Drawing.Size(876, 631);
            this.repairsTabPage.TabIndex = 1;
            this.repairsTabPage.Text = "Вагони";
            this.repairsTabPage.UseVisualStyleBackColor = true;
            // 
            // repairsGroupBox
            // 
            this.repairsGroupBox.Controls.Add(this.repairsDataGridView);
            this.repairsGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repairsGroupBox.Location = new System.Drawing.Point(315, 3);
            this.repairsGroupBox.Name = "repairsGroupBox";
            this.repairsGroupBox.Size = new System.Drawing.Size(558, 628);
            this.repairsGroupBox.TabIndex = 28;
            this.repairsGroupBox.TabStop = false;
            this.repairsGroupBox.Text = "Ремонти";
            // 
            // repairsDataGridView
            // 
            this.repairsDataGridView.AllowUserToAddRows = false;
            this.repairsDataGridView.AllowUserToDeleteRows = false;
            this.repairsDataGridView.AllowUserToResizeColumns = false;
            this.repairsDataGridView.AllowUserToResizeRows = false;
            this.repairsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.repairsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.repairsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.repairsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIDColumn,
            this.repairStationColumn,
            this.repairedWagonIDNumberColumn,
            this.isLocomotiveRepairedColumn,
            this.repairDateColumn});
            this.repairsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.repairsDataGridView.MultiSelect = false;
            this.repairsDataGridView.Name = "repairsDataGridView";
            this.repairsDataGridView.ReadOnly = true;
            this.repairsDataGridView.RowHeadersVisible = false;
            this.repairsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.repairsDataGridView.RowTemplate.ReadOnly = true;
            this.repairsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.repairsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.repairsDataGridView.Size = new System.Drawing.Size(552, 607);
            this.repairsDataGridView.TabIndex = 20;
            // 
            // repairIDColumn
            // 
            this.repairIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.repairIDColumn.HeaderText = "ID";
            this.repairIDColumn.Name = "repairIDColumn";
            this.repairIDColumn.ReadOnly = true;
            this.repairIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.repairIDColumn.Width = 45;
            // 
            // repairStationColumn
            // 
            this.repairStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.repairStationColumn.HeaderText = "Станція";
            this.repairStationColumn.Name = "repairStationColumn";
            this.repairStationColumn.ReadOnly = true;
            this.repairStationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.repairStationColumn.Width = 79;
            // 
            // repairedWagonIDNumberColumn
            // 
            this.repairedWagonIDNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.repairedWagonIDNumberColumn.HeaderText = "ID номер вагона";
            this.repairedWagonIDNumberColumn.Name = "repairedWagonIDNumberColumn";
            this.repairedWagonIDNumberColumn.ReadOnly = true;
            this.repairedWagonIDNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.repairedWagonIDNumberColumn.Width = 123;
            // 
            // isLocomotiveRepairedColumn
            // 
            this.isLocomotiveRepairedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isLocomotiveRepairedColumn.HeaderText = "Чи локомотив";
            this.isLocomotiveRepairedColumn.Name = "isLocomotiveRepairedColumn";
            this.isLocomotiveRepairedColumn.ReadOnly = true;
            this.isLocomotiveRepairedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isLocomotiveRepairedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isLocomotiveRepairedColumn.Width = 105;
            // 
            // repairDateColumn
            // 
            this.repairDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.repairDateColumn.HeaderText = "Дата";
            this.repairDateColumn.Name = "repairDateColumn";
            this.repairDateColumn.ReadOnly = true;
            this.repairDateColumn.Width = 63;
            // 
            // removeWagonButton
            // 
            this.removeWagonButton.BackColor = System.Drawing.Color.PeachPuff;
            this.removeWagonButton.FlatAppearance.BorderSize = 0;
            this.removeWagonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeWagonButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeWagonButton.Location = new System.Drawing.Point(209, 522);
            this.removeWagonButton.Name = "removeWagonButton";
            this.removeWagonButton.Size = new System.Drawing.Size(100, 106);
            this.removeWagonButton.TabIndex = 27;
            this.removeWagonButton.Text = "Списати вагон";
            this.removeWagonButton.UseVisualStyleBackColor = false;
            this.removeWagonButton.Click += new System.EventHandler(this.removeWagonButton_Click);
            // 
            // wagonsToRepairGroupBox
            // 
            this.wagonsToRepairGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wagonsToRepairGroupBox.Controls.Add(this.wagonsDataGridView);
            this.wagonsToRepairGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wagonsToRepairGroupBox.Location = new System.Drawing.Point(3, 3);
            this.wagonsToRepairGroupBox.Name = "wagonsToRepairGroupBox";
            this.wagonsToRepairGroupBox.Size = new System.Drawing.Size(306, 513);
            this.wagonsToRepairGroupBox.TabIndex = 26;
            this.wagonsToRepairGroupBox.TabStop = false;
            this.wagonsToRepairGroupBox.Text = "Вагони";
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
            this.wagonIDNumberColumn,
            this.wagonStationColumn,
            this.isLocomotiveColumn});
            this.wagonsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wagonsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.wagonsDataGridView.MultiSelect = false;
            this.wagonsDataGridView.Name = "wagonsDataGridView";
            this.wagonsDataGridView.ReadOnly = true;
            this.wagonsDataGridView.RowHeadersVisible = false;
            this.wagonsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.wagonsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wagonsDataGridView.RowTemplate.ReadOnly = true;
            this.wagonsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wagonsDataGridView.Size = new System.Drawing.Size(300, 492);
            this.wagonsDataGridView.TabIndex = 25;
            // 
            // wagonIDNumberColumn
            // 
            this.wagonIDNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonIDNumberColumn.HeaderText = "ID номер";
            this.wagonIDNumberColumn.Name = "wagonIDNumberColumn";
            this.wagonIDNumberColumn.ReadOnly = true;
            this.wagonIDNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonIDNumberColumn.Width = 90;
            // 
            // wagonStationColumn
            // 
            this.wagonStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonStationColumn.HeaderText = "Станція";
            this.wagonStationColumn.Name = "wagonStationColumn";
            this.wagonStationColumn.ReadOnly = true;
            this.wagonStationColumn.Width = 79;
            // 
            // isLocomotiveColumn
            // 
            this.isLocomotiveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isLocomotiveColumn.HeaderText = "Чи локомотив";
            this.isLocomotiveColumn.Name = "isLocomotiveColumn";
            this.isLocomotiveColumn.ReadOnly = true;
            this.isLocomotiveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isLocomotiveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isLocomotiveColumn.Width = 114;
            // 
            // addWagonButton
            // 
            this.addWagonButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addWagonButton.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.addWagonButton.FlatAppearance.BorderSize = 0;
            this.addWagonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWagonButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWagonButton.Location = new System.Drawing.Point(3, 522);
            this.addWagonButton.Name = "addWagonButton";
            this.addWagonButton.Size = new System.Drawing.Size(200, 50);
            this.addWagonButton.TabIndex = 23;
            this.addWagonButton.Text = "Додати вагон...";
            this.addWagonButton.UseVisualStyleBackColor = false;
            this.addWagonButton.Click += new System.EventHandler(this.addWagonButton_Click);
            // 
            // repairButton
            // 
            this.repairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.repairButton.BackColor = System.Drawing.Color.PeachPuff;
            this.repairButton.FlatAppearance.BorderSize = 0;
            this.repairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repairButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repairButton.Location = new System.Drawing.Point(3, 578);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(200, 50);
            this.repairButton.TabIndex = 24;
            this.repairButton.Text = "Виконати ремонт";
            this.repairButton.UseVisualStyleBackColor = false;
            this.repairButton.Click += new System.EventHandler(this.repairButton_Click);
            // 
            // personnelTabPage
            // 
            this.personnelTabPage.Controls.Add(this.changeEmployeeInfoButton);
            this.personnelTabPage.Controls.Add(this.appointButton);
            this.personnelTabPage.Controls.Add(this.dismissButton);
            this.personnelTabPage.Controls.Add(this.employeesDataGridView);
            this.personnelTabPage.Location = new System.Drawing.Point(4, 26);
            this.personnelTabPage.Name = "personnelTabPage";
            this.personnelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.personnelTabPage.Size = new System.Drawing.Size(876, 631);
            this.personnelTabPage.TabIndex = 2;
            this.personnelTabPage.Text = "Працівники";
            this.personnelTabPage.UseVisualStyleBackColor = true;
            // 
            // changeEmployeeInfoButton
            // 
            this.changeEmployeeInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeEmployeeInfoButton.BackColor = System.Drawing.Color.PeachPuff;
            this.changeEmployeeInfoButton.FlatAppearance.BorderSize = 0;
            this.changeEmployeeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEmployeeInfoButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeEmployeeInfoButton.Location = new System.Drawing.Point(312, 578);
            this.changeEmployeeInfoButton.Name = "changeEmployeeInfoButton";
            this.changeEmployeeInfoButton.Size = new System.Drawing.Size(250, 50);
            this.changeEmployeeInfoButton.TabIndex = 29;
            this.changeEmployeeInfoButton.Text = "Змінити...";
            this.changeEmployeeInfoButton.UseVisualStyleBackColor = false;
            this.changeEmployeeInfoButton.Click += new System.EventHandler(this.changeEmployeeInfoButton_Click);
            // 
            // appointButton
            // 
            this.appointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appointButton.BackColor = System.Drawing.Color.PeachPuff;
            this.appointButton.FlatAppearance.BorderSize = 0;
            this.appointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointButton.Location = new System.Drawing.Point(3, 578);
            this.appointButton.Name = "appointButton";
            this.appointButton.Size = new System.Drawing.Size(250, 50);
            this.appointButton.TabIndex = 26;
            this.appointButton.Text = "Призначити...";
            this.appointButton.UseVisualStyleBackColor = false;
            this.appointButton.Click += new System.EventHandler(this.appointButton_Click);
            // 
            // dismissButton
            // 
            this.dismissButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dismissButton.BackColor = System.Drawing.Color.PeachPuff;
            this.dismissButton.FlatAppearance.BorderSize = 0;
            this.dismissButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dismissButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dismissButton.Location = new System.Drawing.Point(623, 578);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(250, 50);
            this.dismissButton.TabIndex = 25;
            this.dismissButton.Text = "Звільнити";
            this.dismissButton.UseVisualStyleBackColor = false;
            this.dismissButton.Click += new System.EventHandler(this.dismissButton_Click);
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.AllowUserToResizeColumns = false;
            this.employeesDataGridView.AllowUserToResizeRows = false;
            this.employeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.employeesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.employeesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDNumberColumn,
            this.employeeNameColumn,
            this.employeeLastNameColumn,
            this.birthDateColumn,
            this.employeeTelephoneNumberColumn,
            this.employeePositionColumn,
            this.employeeStationColumn,
            this.appointmentDateColumn,
            this.employerNameColumn});
            this.employeesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersVisible = false;
            this.employeesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employeesDataGridView.RowTemplate.ReadOnly = true;
            this.employeesDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(870, 569);
            this.employeesDataGridView.TabIndex = 24;
            // 
            // employeeIDNumberColumn
            // 
            this.employeeIDNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeIDNumberColumn.HeaderText = "ID номер";
            this.employeeIDNumberColumn.Name = "employeeIDNumberColumn";
            this.employeeIDNumberColumn.ReadOnly = true;
            this.employeeIDNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeIDNumberColumn.Width = 87;
            // 
            // employeeNameColumn
            // 
            this.employeeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeNameColumn.HeaderText = "Ім\'я";
            this.employeeNameColumn.Name = "employeeNameColumn";
            this.employeeNameColumn.ReadOnly = true;
            this.employeeNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeNameColumn.Width = 56;
            // 
            // employeeLastNameColumn
            // 
            this.employeeLastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeLastNameColumn.HeaderText = "Прізвище";
            this.employeeLastNameColumn.Name = "employeeLastNameColumn";
            this.employeeLastNameColumn.ReadOnly = true;
            this.employeeLastNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeLastNameColumn.Width = 95;
            // 
            // birthDateColumn
            // 
            this.birthDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthDateColumn.HeaderText = "Дата народження";
            this.birthDateColumn.Name = "birthDateColumn";
            this.birthDateColumn.ReadOnly = true;
            this.birthDateColumn.Width = 139;
            // 
            // employeeTelephoneNumberColumn
            // 
            this.employeeTelephoneNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeTelephoneNumberColumn.HeaderText = "Номер телефону";
            this.employeeTelephoneNumberColumn.Name = "employeeTelephoneNumberColumn";
            this.employeeTelephoneNumberColumn.ReadOnly = true;
            this.employeeTelephoneNumberColumn.Width = 135;
            // 
            // employeePositionColumn
            // 
            this.employeePositionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeePositionColumn.HeaderText = "Посада";
            this.employeePositionColumn.Name = "employeePositionColumn";
            this.employeePositionColumn.ReadOnly = true;
            this.employeePositionColumn.Width = 85;
            // 
            // employeeStationColumn
            // 
            this.employeeStationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeStationColumn.HeaderText = "Станція";
            this.employeeStationColumn.Name = "employeeStationColumn";
            this.employeeStationColumn.ReadOnly = true;
            this.employeeStationColumn.Width = 83;
            // 
            // appointmentDateColumn
            // 
            this.appointmentDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appointmentDateColumn.HeaderText = "Дата призначення";
            this.appointmentDateColumn.Name = "appointmentDateColumn";
            this.appointmentDateColumn.ReadOnly = true;
            this.appointmentDateColumn.Width = 141;
            // 
            // employerNameColumn
            // 
            this.employerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employerNameColumn.HeaderText = "Керівник";
            this.employerNameColumn.Name = "employerNameColumn";
            this.employerNameColumn.ReadOnly = true;
            this.employerNameColumn.Width = 90;
            // 
            // TransportationStatisticsTabPage
            // 
            this.TransportationStatisticsTabPage.Controls.Add(this.totalGoodsVolumeTransportedTextBox);
            this.TransportationStatisticsTabPage.Controls.Add(this.totalGoodsWeightTransportedTextBox);
            this.TransportationStatisticsTabPage.Controls.Add(this.totalOrdersFulfilledTextBox);
            this.TransportationStatisticsTabPage.Controls.Add(totalGoodsVolumeTransportedLabel);
            this.TransportationStatisticsTabPage.Controls.Add(totalGoodsWeightTransportedLabel);
            this.TransportationStatisticsTabPage.Controls.Add(totalOrdersFulfilledLabel);
            this.TransportationStatisticsTabPage.Controls.Add(this.customersGroupBox);
            this.TransportationStatisticsTabPage.Controls.Add(this.wagonsGroupBox);
            this.TransportationStatisticsTabPage.Controls.Add(this.stationsGroupBox);
            this.TransportationStatisticsTabPage.Controls.Add(this.endDateDateTimePicker);
            this.TransportationStatisticsTabPage.Controls.Add(this.beginDateDateTimePicker);
            this.TransportationStatisticsTabPage.Controls.Add(endDateLabel);
            this.TransportationStatisticsTabPage.Controls.Add(beginDateLabel);
            this.TransportationStatisticsTabPage.Location = new System.Drawing.Point(4, 26);
            this.TransportationStatisticsTabPage.Name = "TransportationStatisticsTabPage";
            this.TransportationStatisticsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TransportationStatisticsTabPage.Size = new System.Drawing.Size(876, 631);
            this.TransportationStatisticsTabPage.TabIndex = 3;
            this.TransportationStatisticsTabPage.Text = "Статистика перевезень";
            this.TransportationStatisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // totalGoodsVolumeTransportedTextBox
            // 
            this.totalGoodsVolumeTransportedTextBox.BackColor = System.Drawing.Color.White;
            this.totalGoodsVolumeTransportedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalGoodsVolumeTransportedTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalGoodsVolumeTransportedTextBox.Location = new System.Drawing.Point(35, 245);
            this.totalGoodsVolumeTransportedTextBox.Name = "totalGoodsVolumeTransportedTextBox";
            this.totalGoodsVolumeTransportedTextBox.ReadOnly = true;
            this.totalGoodsVolumeTransportedTextBox.Size = new System.Drawing.Size(292, 24);
            this.totalGoodsVolumeTransportedTextBox.TabIndex = 41;
            this.totalGoodsVolumeTransportedTextBox.Text = "0";
            // 
            // totalGoodsWeightTransportedTextBox
            // 
            this.totalGoodsWeightTransportedTextBox.BackColor = System.Drawing.Color.White;
            this.totalGoodsWeightTransportedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalGoodsWeightTransportedTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalGoodsWeightTransportedTextBox.Location = new System.Drawing.Point(35, 193);
            this.totalGoodsWeightTransportedTextBox.Name = "totalGoodsWeightTransportedTextBox";
            this.totalGoodsWeightTransportedTextBox.ReadOnly = true;
            this.totalGoodsWeightTransportedTextBox.Size = new System.Drawing.Size(292, 24);
            this.totalGoodsWeightTransportedTextBox.TabIndex = 40;
            this.totalGoodsWeightTransportedTextBox.Text = "0";
            // 
            // totalOrdersFulfilledTextBox
            // 
            this.totalOrdersFulfilledTextBox.BackColor = System.Drawing.Color.White;
            this.totalOrdersFulfilledTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalOrdersFulfilledTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalOrdersFulfilledTextBox.Location = new System.Drawing.Point(35, 141);
            this.totalOrdersFulfilledTextBox.Name = "totalOrdersFulfilledTextBox";
            this.totalOrdersFulfilledTextBox.ReadOnly = true;
            this.totalOrdersFulfilledTextBox.Size = new System.Drawing.Size(292, 24);
            this.totalOrdersFulfilledTextBox.TabIndex = 39;
            this.totalOrdersFulfilledTextBox.Text = "0";
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGroupBox.Controls.Add(this.clientsDataGridView);
            this.customersGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersGroupBox.Location = new System.Drawing.Point(333, 3);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Size = new System.Drawing.Size(540, 309);
            this.customersGroupBox.TabIndex = 35;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Замовники";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AllowUserToResizeColumns = false;
            this.clientsDataGridView.AllowUserToResizeRows = false;
            this.clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.clientsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53});
            this.clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.RowHeadersVisible = false;
            this.clientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsDataGridView.RowTemplate.ReadOnly = true;
            this.clientsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.Size = new System.Drawing.Size(534, 288);
            this.clientsDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn46.HeaderText = "ID";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn46.Width = 45;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn47.HeaderText = "Замовник";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn47.Width = 93;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn51.HeaderText = "Кількість замовлень";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn51.Width = 138;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn52.HeaderText = "Маса замовленого товару";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn52.Width = 177;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn53.HeaderText = "Об\'єм замовленого товару";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn53.Width = 180;
            // 
            // wagonsGroupBox
            // 
            this.wagonsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wagonsGroupBox.Controls.Add(this.wagonsStatsDataGridView);
            this.wagonsGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wagonsGroupBox.Location = new System.Drawing.Point(3, 318);
            this.wagonsGroupBox.Name = "wagonsGroupBox";
            this.wagonsGroupBox.Size = new System.Drawing.Size(324, 310);
            this.wagonsGroupBox.TabIndex = 34;
            this.wagonsGroupBox.TabStop = false;
            this.wagonsGroupBox.Text = "Вагони";
            // 
            // wagonsStatsDataGridView
            // 
            this.wagonsStatsDataGridView.AllowUserToAddRows = false;
            this.wagonsStatsDataGridView.AllowUserToDeleteRows = false;
            this.wagonsStatsDataGridView.AllowUserToResizeColumns = false;
            this.wagonsStatsDataGridView.AllowUserToResizeRows = false;
            this.wagonsStatsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.wagonsStatsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.wagonsStatsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wagonsStatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wagonsStatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wagonIDColumn,
            this.isLocomotiveStatsColumn,
            this.wagonDistanceWentColumn,
            this.asPartOfTrainsCountColumn,
            this.wagonRepairsCountColumn});
            this.wagonsStatsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wagonsStatsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.wagonsStatsDataGridView.MultiSelect = false;
            this.wagonsStatsDataGridView.Name = "wagonsStatsDataGridView";
            this.wagonsStatsDataGridView.ReadOnly = true;
            this.wagonsStatsDataGridView.RowHeadersVisible = false;
            this.wagonsStatsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.wagonsStatsDataGridView.RowTemplate.ReadOnly = true;
            this.wagonsStatsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonsStatsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wagonsStatsDataGridView.Size = new System.Drawing.Size(318, 289);
            this.wagonsStatsDataGridView.TabIndex = 26;
            // 
            // stationsGroupBox
            // 
            this.stationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stationsGroupBox.Controls.Add(this.stationsDataGridView);
            this.stationsGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationsGroupBox.Location = new System.Drawing.Point(333, 318);
            this.stationsGroupBox.Name = "stationsGroupBox";
            this.stationsGroupBox.Size = new System.Drawing.Size(540, 310);
            this.stationsGroupBox.TabIndex = 33;
            this.stationsGroupBox.TabStop = false;
            this.stationsGroupBox.Text = "Станції";
            // 
            // stationsDataGridView
            // 
            this.stationsDataGridView.AllowUserToAddRows = false;
            this.stationsDataGridView.AllowUserToDeleteRows = false;
            this.stationsDataGridView.AllowUserToResizeColumns = false;
            this.stationsDataGridView.AllowUserToResizeRows = false;
            this.stationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.stationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.stationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationIDColumn,
            this.stationNameColumn,
            this.asDepartureStationCountColumn,
            this.asArrivalStationCountColumn});
            this.stationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.stationsDataGridView.MultiSelect = false;
            this.stationsDataGridView.Name = "stationsDataGridView";
            this.stationsDataGridView.ReadOnly = true;
            this.stationsDataGridView.RowHeadersVisible = false;
            this.stationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stationsDataGridView.RowTemplate.ReadOnly = true;
            this.stationsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stationsDataGridView.Size = new System.Drawing.Size(534, 289);
            this.stationsDataGridView.TabIndex = 25;
            // 
            // stationIDColumn
            // 
            this.stationIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationIDColumn.HeaderText = "ID";
            this.stationIDColumn.Name = "stationIDColumn";
            this.stationIDColumn.ReadOnly = true;
            this.stationIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stationIDColumn.Width = 45;
            // 
            // stationNameColumn
            // 
            this.stationNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationNameColumn.HeaderText = "Назва";
            this.stationNameColumn.Name = "stationNameColumn";
            this.stationNameColumn.ReadOnly = true;
            this.stationNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stationNameColumn.Width = 68;
            // 
            // asDepartureStationCountColumn
            // 
            this.asDepartureStationCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asDepartureStationCountColumn.HeaderText = "Була станцією відправлення, разів";
            this.asDepartureStationCountColumn.Name = "asDepartureStationCountColumn";
            this.asDepartureStationCountColumn.ReadOnly = true;
            this.asDepartureStationCountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asDepartureStationCountColumn.Width = 189;
            // 
            // asArrivalStationCountColumn
            // 
            this.asArrivalStationCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asArrivalStationCountColumn.HeaderText = "Була станцією прибуття, разів";
            this.asArrivalStationCountColumn.Name = "asArrivalStationCountColumn";
            this.asArrivalStationCountColumn.ReadOnly = true;
            this.asArrivalStationCountColumn.Width = 165;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Checked = false;
            this.endDateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(44, 40);
            this.endDateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(135, 31);
            this.endDateDateTimePicker.TabIndex = 32;
            this.endDateDateTimePicker.ValueChanged += new System.EventHandler(this.endDateDateTimePicker_ValueChanged);
            // 
            // beginDateDateTimePicker
            // 
            this.beginDateDateTimePicker.Checked = false;
            this.beginDateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beginDateDateTimePicker.Location = new System.Drawing.Point(44, 3);
            this.beginDateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.beginDateDateTimePicker.Name = "beginDateDateTimePicker";
            this.beginDateDateTimePicker.Size = new System.Drawing.Size(135, 31);
            this.beginDateDateTimePicker.TabIndex = 31;
            this.beginDateDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.beginDateDateTimePicker.ValueChanged += new System.EventHandler(this.beginDateDateTimePicker_ValueChanged);
            // 
            // statusTabPage
            // 
            this.statusTabPage.Controls.Add(this.label2);
            this.statusTabPage.Controls.Add(this.currentUserEmployerGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserAppointmentDateGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserPositionGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserStationGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserIDNumberGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserSurnameGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserNameGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserBirthDateGroupBox);
            this.statusTabPage.Controls.Add(this.currentUserTelephoneNumberGroupBox);
            this.statusTabPage.Location = new System.Drawing.Point(4, 26);
            this.statusTabPage.Name = "statusTabPage";
            this.statusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusTabPage.Size = new System.Drawing.Size(876, 631);
            this.statusTabPage.TabIndex = 4;
            this.statusTabPage.Text = "Статус поточного користувача";
            this.statusTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(313, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Поточний користувач:";
            // 
            // currentUserEmployerGroupBox
            // 
            this.currentUserEmployerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserEmployerGroupBox.Controls.Add(this.currentUserEmployerTextBox);
            this.currentUserEmployerGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserEmployerGroupBox.Location = new System.Drawing.Point(314, 537);
            this.currentUserEmployerGroupBox.Name = "currentUserEmployerGroupBox";
            this.currentUserEmployerGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserEmployerGroupBox.TabIndex = 16;
            this.currentUserEmployerGroupBox.TabStop = false;
            this.currentUserEmployerGroupBox.Text = "Керівник";
            // 
            // currentUserEmployerTextBox
            // 
            this.currentUserEmployerTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserEmployerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserEmployerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserEmployerTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserEmployerTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserEmployerTextBox.Name = "currentUserEmployerTextBox";
            this.currentUserEmployerTextBox.ReadOnly = true;
            this.currentUserEmployerTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserEmployerTextBox.TabIndex = 0;
            // 
            // currentUserAppointmentDateGroupBox
            // 
            this.currentUserAppointmentDateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserAppointmentDateGroupBox.Controls.Add(this.currentUserAppointmentDateTextBox);
            this.currentUserAppointmentDateGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserAppointmentDateGroupBox.Location = new System.Drawing.Point(314, 478);
            this.currentUserAppointmentDateGroupBox.Name = "currentUserAppointmentDateGroupBox";
            this.currentUserAppointmentDateGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserAppointmentDateGroupBox.TabIndex = 15;
            this.currentUserAppointmentDateGroupBox.TabStop = false;
            this.currentUserAppointmentDateGroupBox.Text = "Дата призначення";
            // 
            // currentUserAppointmentDateTextBox
            // 
            this.currentUserAppointmentDateTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserAppointmentDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserAppointmentDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserAppointmentDateTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserAppointmentDateTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserAppointmentDateTextBox.Name = "currentUserAppointmentDateTextBox";
            this.currentUserAppointmentDateTextBox.ReadOnly = true;
            this.currentUserAppointmentDateTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserAppointmentDateTextBox.TabIndex = 0;
            // 
            // currentUserPositionGroupBox
            // 
            this.currentUserPositionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserPositionGroupBox.Controls.Add(this.currentUserPositionTextBox);
            this.currentUserPositionGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserPositionGroupBox.Location = new System.Drawing.Point(314, 419);
            this.currentUserPositionGroupBox.Name = "currentUserPositionGroupBox";
            this.currentUserPositionGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserPositionGroupBox.TabIndex = 14;
            this.currentUserPositionGroupBox.TabStop = false;
            this.currentUserPositionGroupBox.Text = "Посада";
            // 
            // currentUserPositionTextBox
            // 
            this.currentUserPositionTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserPositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserPositionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserPositionTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserPositionTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserPositionTextBox.Name = "currentUserPositionTextBox";
            this.currentUserPositionTextBox.ReadOnly = true;
            this.currentUserPositionTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserPositionTextBox.TabIndex = 0;
            // 
            // currentUserStationGroupBox
            // 
            this.currentUserStationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserStationGroupBox.Controls.Add(this.currentUserStationTextBox);
            this.currentUserStationGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserStationGroupBox.Location = new System.Drawing.Point(314, 360);
            this.currentUserStationGroupBox.Name = "currentUserStationGroupBox";
            this.currentUserStationGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserStationGroupBox.TabIndex = 14;
            this.currentUserStationGroupBox.TabStop = false;
            this.currentUserStationGroupBox.Text = "Станція";
            // 
            // currentUserStationTextBox
            // 
            this.currentUserStationTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserStationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserStationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserStationTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserStationTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserStationTextBox.Name = "currentUserStationTextBox";
            this.currentUserStationTextBox.ReadOnly = true;
            this.currentUserStationTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserStationTextBox.TabIndex = 0;
            // 
            // currentUserIDNumberGroupBox
            // 
            this.currentUserIDNumberGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserIDNumberGroupBox.Controls.Add(this.currentUserIDNumberTextBox);
            this.currentUserIDNumberGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserIDNumberGroupBox.Location = new System.Drawing.Point(314, 65);
            this.currentUserIDNumberGroupBox.Name = "currentUserIDNumberGroupBox";
            this.currentUserIDNumberGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserIDNumberGroupBox.TabIndex = 10;
            this.currentUserIDNumberGroupBox.TabStop = false;
            this.currentUserIDNumberGroupBox.Text = "Ідентифікаційний номер";
            // 
            // currentUserIDNumberTextBox
            // 
            this.currentUserIDNumberTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserIDNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserIDNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserIDNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserIDNumberTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserIDNumberTextBox.MaxLength = 8;
            this.currentUserIDNumberTextBox.Name = "currentUserIDNumberTextBox";
            this.currentUserIDNumberTextBox.ReadOnly = true;
            this.currentUserIDNumberTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserIDNumberTextBox.TabIndex = 0;
            // 
            // currentUserSurnameGroupBox
            // 
            this.currentUserSurnameGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserSurnameGroupBox.Controls.Add(this.currentUserSurnameTextBox);
            this.currentUserSurnameGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserSurnameGroupBox.Location = new System.Drawing.Point(314, 124);
            this.currentUserSurnameGroupBox.Name = "currentUserSurnameGroupBox";
            this.currentUserSurnameGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserSurnameGroupBox.TabIndex = 11;
            this.currentUserSurnameGroupBox.TabStop = false;
            this.currentUserSurnameGroupBox.Text = "Прізвище";
            // 
            // currentUserSurnameTextBox
            // 
            this.currentUserSurnameTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserSurnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserSurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserSurnameTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserSurnameTextBox.Name = "currentUserSurnameTextBox";
            this.currentUserSurnameTextBox.ReadOnly = true;
            this.currentUserSurnameTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserSurnameTextBox.TabIndex = 0;
            // 
            // currentUserNameGroupBox
            // 
            this.currentUserNameGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserNameGroupBox.Controls.Add(this.currentUserNameTextBox);
            this.currentUserNameGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserNameGroupBox.Location = new System.Drawing.Point(314, 183);
            this.currentUserNameGroupBox.Name = "currentUserNameGroupBox";
            this.currentUserNameGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserNameGroupBox.TabIndex = 12;
            this.currentUserNameGroupBox.TabStop = false;
            this.currentUserNameGroupBox.Text = "Ім\'я";
            // 
            // currentUserNameTextBox
            // 
            this.currentUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserNameTextBox.Name = "currentUserNameTextBox";
            this.currentUserNameTextBox.ReadOnly = true;
            this.currentUserNameTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserNameTextBox.TabIndex = 0;
            // 
            // currentUserBirthDateGroupBox
            // 
            this.currentUserBirthDateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserBirthDateGroupBox.Controls.Add(this.currentUserBirthDateTextBox);
            this.currentUserBirthDateGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserBirthDateGroupBox.Location = new System.Drawing.Point(314, 242);
            this.currentUserBirthDateGroupBox.Name = "currentUserBirthDateGroupBox";
            this.currentUserBirthDateGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserBirthDateGroupBox.TabIndex = 14;
            this.currentUserBirthDateGroupBox.TabStop = false;
            this.currentUserBirthDateGroupBox.Text = "Дата народження";
            // 
            // currentUserBirthDateTextBox
            // 
            this.currentUserBirthDateTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserBirthDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserBirthDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserBirthDateTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserBirthDateTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserBirthDateTextBox.Name = "currentUserBirthDateTextBox";
            this.currentUserBirthDateTextBox.ReadOnly = true;
            this.currentUserBirthDateTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserBirthDateTextBox.TabIndex = 1;
            // 
            // currentUserTelephoneNumberGroupBox
            // 
            this.currentUserTelephoneNumberGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentUserTelephoneNumberGroupBox.Controls.Add(this.currentUserTelephoneNumberTextBox);
            this.currentUserTelephoneNumberGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserTelephoneNumberGroupBox.Location = new System.Drawing.Point(314, 301);
            this.currentUserTelephoneNumberGroupBox.Name = "currentUserTelephoneNumberGroupBox";
            this.currentUserTelephoneNumberGroupBox.Size = new System.Drawing.Size(250, 53);
            this.currentUserTelephoneNumberGroupBox.TabIndex = 13;
            this.currentUserTelephoneNumberGroupBox.TabStop = false;
            this.currentUserTelephoneNumberGroupBox.Text = "Телефон";
            // 
            // currentUserTelephoneNumberTextBox
            // 
            this.currentUserTelephoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserTelephoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserTelephoneNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserTelephoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserTelephoneNumberTextBox.Location = new System.Drawing.Point(3, 18);
            this.currentUserTelephoneNumberTextBox.Name = "currentUserTelephoneNumberTextBox";
            this.currentUserTelephoneNumberTextBox.ReadOnly = true;
            this.currentUserTelephoneNumberTextBox.Size = new System.Drawing.Size(244, 24);
            this.currentUserTelephoneNumberTextBox.TabIndex = 0;
            // 
            // wagonIDColumn
            // 
            this.wagonIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonIDColumn.HeaderText = "ID";
            this.wagonIDColumn.Name = "wagonIDColumn";
            this.wagonIDColumn.ReadOnly = true;
            this.wagonIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonIDColumn.Width = 45;
            // 
            // isLocomotiveStatsColumn
            // 
            this.isLocomotiveStatsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isLocomotiveStatsColumn.HeaderText = "Чи локомотив";
            this.isLocomotiveStatsColumn.Name = "isLocomotiveStatsColumn";
            this.isLocomotiveStatsColumn.ReadOnly = true;
            this.isLocomotiveStatsColumn.Width = 95;
            // 
            // wagonDistanceWentColumn
            // 
            this.wagonDistanceWentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonDistanceWentColumn.HeaderText = "Пробіг, км";
            this.wagonDistanceWentColumn.Name = "wagonDistanceWentColumn";
            this.wagonDistanceWentColumn.ReadOnly = true;
            this.wagonDistanceWentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonDistanceWentColumn.Width = 95;
            // 
            // asPartOfTrainsCountColumn
            // 
            this.asPartOfTrainsCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asPartOfTrainsCountColumn.HeaderText = "У складі потягів, разів";
            this.asPartOfTrainsCountColumn.Name = "asPartOfTrainsCountColumn";
            this.asPartOfTrainsCountColumn.ReadOnly = true;
            this.asPartOfTrainsCountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asPartOfTrainsCountColumn.Width = 119;
            // 
            // wagonRepairsCountColumn
            // 
            this.wagonRepairsCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wagonRepairsCountColumn.HeaderText = "У ремонті, разів";
            this.wagonRepairsCountColumn.Name = "wagonRepairsCountColumn";
            this.wagonRepairsCountColumn.ReadOnly = true;
            this.wagonRepairsCountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wagonRepairsCountColumn.Width = 119;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База даних \"Залізниця\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderingForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.ordersTabPage.ResumeLayout(false);
            this.repairsTabPage.ResumeLayout(false);
            this.repairsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repairsDataGridView)).EndInit();
            this.wagonsToRepairGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wagonsDataGridView)).EndInit();
            this.personnelTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.TransportationStatisticsTabPage.ResumeLayout(false);
            this.TransportationStatisticsTabPage.PerformLayout();
            this.customersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.wagonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wagonsStatsDataGridView)).EndInit();
            this.stationsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).EndInit();
            this.statusTabPage.ResumeLayout(false);
            this.statusTabPage.PerformLayout();
            this.currentUserEmployerGroupBox.ResumeLayout(false);
            this.currentUserEmployerGroupBox.PerformLayout();
            this.currentUserAppointmentDateGroupBox.ResumeLayout(false);
            this.currentUserAppointmentDateGroupBox.PerformLayout();
            this.currentUserPositionGroupBox.ResumeLayout(false);
            this.currentUserPositionGroupBox.PerformLayout();
            this.currentUserStationGroupBox.ResumeLayout(false);
            this.currentUserStationGroupBox.PerformLayout();
            this.currentUserIDNumberGroupBox.ResumeLayout(false);
            this.currentUserIDNumberGroupBox.PerformLayout();
            this.currentUserSurnameGroupBox.ResumeLayout(false);
            this.currentUserSurnameGroupBox.PerformLayout();
            this.currentUserNameGroupBox.ResumeLayout(false);
            this.currentUserNameGroupBox.PerformLayout();
            this.currentUserBirthDateGroupBox.ResumeLayout(false);
            this.currentUserBirthDateGroupBox.PerformLayout();
            this.currentUserTelephoneNumberGroupBox.ResumeLayout(false);
            this.currentUserTelephoneNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage ordersTabPage;
        private System.Windows.Forms.TabPage repairsTabPage;
        private System.Windows.Forms.TabPage personnelTabPage;
        private System.Windows.Forms.TabPage TransportationStatisticsTabPage;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.DataGridView repairsDataGridView;
        private System.Windows.Forms.DataGridView wagonsDataGridView;
        private System.Windows.Forms.Button repairButton;
        private System.Windows.Forms.Button addWagonButton;
        private System.Windows.Forms.GroupBox wagonsToRepairGroupBox;
        private System.Windows.Forms.Button appointButton;
        private System.Windows.Forms.Button dismissButton;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridView stationsDataGridView;
        private System.Windows.Forms.DateTimePicker beginDateDateTimePicker;
        private System.Windows.Forms.GroupBox customersGroupBox;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.GroupBox wagonsGroupBox;
        private System.Windows.Forms.DataGridView wagonsStatsDataGridView;
        private System.Windows.Forms.GroupBox stationsGroupBox;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox totalGoodsVolumeTransportedTextBox;
        private System.Windows.Forms.TextBox totalGoodsWeightTransportedTextBox;
        private System.Windows.Forms.TextBox totalOrdersFulfilledTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDepartureStationCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asArrivalStationCountColumn;
        private System.Windows.Forms.TabPage statusTabPage;
        private System.Windows.Forms.GroupBox currentUserIDNumberGroupBox;
        private System.Windows.Forms.TextBox currentUserIDNumberTextBox;
        private System.Windows.Forms.GroupBox currentUserSurnameGroupBox;
        private System.Windows.Forms.TextBox currentUserSurnameTextBox;
        private System.Windows.Forms.GroupBox currentUserNameGroupBox;
        private System.Windows.Forms.TextBox currentUserNameTextBox;
        private System.Windows.Forms.GroupBox currentUserBirthDateGroupBox;
        private System.Windows.Forms.GroupBox currentUserTelephoneNumberGroupBox;
        private System.Windows.Forms.TextBox currentUserTelephoneNumberTextBox;
        private System.Windows.Forms.GroupBox currentUserPositionGroupBox;
        private System.Windows.Forms.TextBox currentUserPositionTextBox;
        private System.Windows.Forms.GroupBox currentUserStationGroupBox;
        private System.Windows.Forms.TextBox currentUserStationTextBox;
        private System.Windows.Forms.TextBox currentUserBirthDateTextBox;
        private System.Windows.Forms.GroupBox currentUserAppointmentDateGroupBox;
        private System.Windows.Forms.TextBox currentUserAppointmentDateTextBox;
        private System.Windows.Forms.GroupBox repairsGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairedWagonIDNumberColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLocomotiveRepairedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairDateColumn;
        private System.Windows.Forms.Button removeWagonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeTelephoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerNameColumn;
        private System.Windows.Forms.GroupBox currentUserEmployerGroupBox;
        private System.Windows.Forms.TextBox currentUserEmployerTextBox;
        private System.Windows.Forms.Button changeEmployeeInfoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonIDNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonStationColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLocomotiveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodWeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureStationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalStationColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executionDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonIDColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLocomotiveStatsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonDistanceWentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asPartOfTrainsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonRepairsCountColumn;
    }
}