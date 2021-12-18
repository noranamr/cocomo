
namespace cocomo
{
    partial class Form2
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
            this.ReqSWRelaibility_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeOfappDB_comboBox = new System.Windows.Forms.ComboBox();
            this.ComplixtyOfProject_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.runtimePreformance_comboBox = new System.Windows.Forms.ComboBox();
            this.volatilityOfVirtualMachineEnv_comboBox = new System.Windows.Forms.ComboBox();
            this.MemoryConstraints_comboBox = new System.Windows.Forms.ComboBox();
            this.reqTurnabout_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProgrammingLangExp_comboBox = new System.Windows.Forms.ComboBox();
            this.virtualMachineExp_comboBox = new System.Windows.Forms.ComboBox();
            this.SWengineerCapability_comboBox = new System.Windows.Forms.ComboBox();
            this.appExp_comboBox = new System.Windows.Forms.ComboBox();
            this.analystCapability_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.applicationOfSWEmethods_comboBox = new System.Windows.Forms.ComboBox();
            this.useOfSWtools_comboBox = new System.Windows.Forms.ComboBox();
            this.reqDevSchedule_comboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.calculateEAF = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReqSWRelaibility_comboBox
            // 
            this.ReqSWRelaibility_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReqSWRelaibility_comboBox.FormattingEnabled = true;
            this.ReqSWRelaibility_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.ReqSWRelaibility_comboBox.Location = new System.Drawing.Point(239, 29);
            this.ReqSWRelaibility_comboBox.Name = "ReqSWRelaibility_comboBox";
            this.ReqSWRelaibility_comboBox.Size = new System.Drawing.Size(106, 28);
            this.ReqSWRelaibility_comboBox.TabIndex = 0;
            this.ReqSWRelaibility_comboBox.SelectedIndexChanged += new System.EventHandler(this.ReqSWRelaibility_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Required Software Reliability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size of application database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Complixty of project";
            // 
            // SizeOfappDB_comboBox
            // 
            this.SizeOfappDB_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeOfappDB_comboBox.FormattingEnabled = true;
            this.SizeOfappDB_comboBox.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.SizeOfappDB_comboBox.Location = new System.Drawing.Point(239, 67);
            this.SizeOfappDB_comboBox.Name = "SizeOfappDB_comboBox";
            this.SizeOfappDB_comboBox.Size = new System.Drawing.Size(106, 28);
            this.SizeOfappDB_comboBox.TabIndex = 4;
            this.SizeOfappDB_comboBox.SelectedIndexChanged += new System.EventHandler(this.SizeOfappDB_comboBox_SelectedIndexChanged);
            // 
            // ComplixtyOfProject_comboBox
            // 
            this.ComplixtyOfProject_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComplixtyOfProject_comboBox.FormattingEnabled = true;
            this.ComplixtyOfProject_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.ComplixtyOfProject_comboBox.Location = new System.Drawing.Point(239, 98);
            this.ComplixtyOfProject_comboBox.Name = "ComplixtyOfProject_comboBox";
            this.ComplixtyOfProject_comboBox.Size = new System.Drawing.Size(106, 28);
            this.ComplixtyOfProject_comboBox.TabIndex = 5;
            this.ComplixtyOfProject_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComplixtyOfProject_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Run-time preformance constraints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Memory constraints";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Volatility of virtual machine enviroment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Required trunabout time";
            // 
            // runtimePreformance_comboBox
            // 
            this.runtimePreformance_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runtimePreformance_comboBox.FormattingEnabled = true;
            this.runtimePreformance_comboBox.Items.AddRange(new object[] {
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.runtimePreformance_comboBox.Location = new System.Drawing.Point(258, 38);
            this.runtimePreformance_comboBox.Name = "runtimePreformance_comboBox";
            this.runtimePreformance_comboBox.Size = new System.Drawing.Size(106, 28);
            this.runtimePreformance_comboBox.TabIndex = 10;
            this.runtimePreformance_comboBox.SelectedIndexChanged += new System.EventHandler(this.runtimePreformance_comboBox_SelectedIndexChanged);
            // 
            // volatilityOfVirtualMachineEnv_comboBox
            // 
            this.volatilityOfVirtualMachineEnv_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.volatilityOfVirtualMachineEnv_comboBox.FormattingEnabled = true;
            this.volatilityOfVirtualMachineEnv_comboBox.Items.AddRange(new object[] {
            "Low ",
            "Nominal",
            "High",
            "Very high"});
            this.volatilityOfVirtualMachineEnv_comboBox.Location = new System.Drawing.Point(258, 114);
            this.volatilityOfVirtualMachineEnv_comboBox.Name = "volatilityOfVirtualMachineEnv_comboBox";
            this.volatilityOfVirtualMachineEnv_comboBox.Size = new System.Drawing.Size(106, 28);
            this.volatilityOfVirtualMachineEnv_comboBox.TabIndex = 11;
            this.volatilityOfVirtualMachineEnv_comboBox.SelectedIndexChanged += new System.EventHandler(this.volatilityOfVirtualMachineEnv_comboBox_SelectedIndexChanged);
            // 
            // MemoryConstraints_comboBox
            // 
            this.MemoryConstraints_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MemoryConstraints_comboBox.FormattingEnabled = true;
            this.MemoryConstraints_comboBox.Items.AddRange(new object[] {
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.MemoryConstraints_comboBox.Location = new System.Drawing.Point(258, 74);
            this.MemoryConstraints_comboBox.Name = "MemoryConstraints_comboBox";
            this.MemoryConstraints_comboBox.Size = new System.Drawing.Size(106, 28);
            this.MemoryConstraints_comboBox.TabIndex = 12;
            this.MemoryConstraints_comboBox.SelectedIndexChanged += new System.EventHandler(this.MemoryConstraints_comboBox_SelectedIndexChanged);
            // 
            // reqTurnabout_comboBox
            // 
            this.reqTurnabout_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reqTurnabout_comboBox.FormattingEnabled = true;
            this.reqTurnabout_comboBox.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.reqTurnabout_comboBox.Location = new System.Drawing.Point(258, 153);
            this.reqTurnabout_comboBox.Name = "reqTurnabout_comboBox";
            this.reqTurnabout_comboBox.Size = new System.Drawing.Size(106, 28);
            this.reqTurnabout_comboBox.TabIndex = 13;
            this.reqTurnabout_comboBox.SelectedIndexChanged += new System.EventHandler(this.reqTurnabout_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReqSWRelaibility_comboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SizeOfappDB_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComplixtyOfProject_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 144);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Attributes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.runtimePreformance_comboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.reqTurnabout_comboBox);
            this.groupBox2.Controls.Add(this.MemoryConstraints_comboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.volatilityOfVirtualMachineEnv_comboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(444, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 219);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware Attributes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProgrammingLangExp_comboBox);
            this.groupBox3.Controls.Add(this.virtualMachineExp_comboBox);
            this.groupBox3.Controls.Add(this.SWengineerCapability_comboBox);
            this.groupBox3.Controls.Add(this.appExp_comboBox);
            this.groupBox3.Controls.Add(this.analystCapability_comboBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(20, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 241);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personnel Attributes";
            // 
            // ProgrammingLangExp_comboBox
            // 
            this.ProgrammingLangExp_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgrammingLangExp_comboBox.FormattingEnabled = true;
            this.ProgrammingLangExp_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High"});
            this.ProgrammingLangExp_comboBox.Location = new System.Drawing.Point(239, 196);
            this.ProgrammingLangExp_comboBox.Name = "ProgrammingLangExp_comboBox";
            this.ProgrammingLangExp_comboBox.Size = new System.Drawing.Size(135, 28);
            this.ProgrammingLangExp_comboBox.TabIndex = 24;
            this.ProgrammingLangExp_comboBox.SelectedIndexChanged += new System.EventHandler(this.ProgrammingLangExp_comboBox_SelectedIndexChanged);
            // 
            // virtualMachineExp_comboBox
            // 
            this.virtualMachineExp_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.virtualMachineExp_comboBox.FormattingEnabled = true;
            this.virtualMachineExp_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High"});
            this.virtualMachineExp_comboBox.Location = new System.Drawing.Point(239, 154);
            this.virtualMachineExp_comboBox.Name = "virtualMachineExp_comboBox";
            this.virtualMachineExp_comboBox.Size = new System.Drawing.Size(135, 28);
            this.virtualMachineExp_comboBox.TabIndex = 23;
            this.virtualMachineExp_comboBox.SelectedIndexChanged += new System.EventHandler(this.virtualMachineExp_comboBox_SelectedIndexChanged);
            // 
            // SWengineerCapability_comboBox
            // 
            this.SWengineerCapability_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWengineerCapability_comboBox.FormattingEnabled = true;
            this.SWengineerCapability_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.SWengineerCapability_comboBox.Location = new System.Drawing.Point(239, 112);
            this.SWengineerCapability_comboBox.Name = "SWengineerCapability_comboBox";
            this.SWengineerCapability_comboBox.Size = new System.Drawing.Size(135, 28);
            this.SWengineerCapability_comboBox.TabIndex = 22;
            this.SWengineerCapability_comboBox.SelectedIndexChanged += new System.EventHandler(this.SWengineerCapability_comboBox_SelectedIndexChanged);
            // 
            // appExp_comboBox
            // 
            this.appExp_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appExp_comboBox.FormattingEnabled = true;
            this.appExp_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.appExp_comboBox.Location = new System.Drawing.Point(239, 71);
            this.appExp_comboBox.Name = "appExp_comboBox";
            this.appExp_comboBox.Size = new System.Drawing.Size(135, 28);
            this.appExp_comboBox.TabIndex = 21;
            this.appExp_comboBox.SelectedIndexChanged += new System.EventHandler(this.appExp_comboBox_SelectedIndexChanged);
            // 
            // analystCapability_comboBox
            // 
            this.analystCapability_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.analystCapability_comboBox.FormattingEnabled = true;
            this.analystCapability_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.analystCapability_comboBox.Location = new System.Drawing.Point(239, 31);
            this.analystCapability_comboBox.Name = "analystCapability_comboBox";
            this.analystCapability_comboBox.Size = new System.Drawing.Size(135, 28);
            this.analystCapability_comboBox.TabIndex = 20;
            this.analystCapability_comboBox.SelectedIndexChanged += new System.EventHandler(this.analystCapability_comboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Programming Language Experience";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Applications Experience";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Virtual Machine Experience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Analyst Capability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Software Engineer Capability";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.applicationOfSWEmethods_comboBox);
            this.groupBox4.Controls.Add(this.useOfSWtools_comboBox);
            this.groupBox4.Controls.Add(this.reqDevSchedule_comboBox);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(444, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 160);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Project Attributes";
            // 
            // applicationOfSWEmethods_comboBox
            // 
            this.applicationOfSWEmethods_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.applicationOfSWEmethods_comboBox.FormattingEnabled = true;
            this.applicationOfSWEmethods_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.applicationOfSWEmethods_comboBox.Location = new System.Drawing.Point(294, 25);
            this.applicationOfSWEmethods_comboBox.Name = "applicationOfSWEmethods_comboBox";
            this.applicationOfSWEmethods_comboBox.Size = new System.Drawing.Size(135, 28);
            this.applicationOfSWEmethods_comboBox.TabIndex = 24;
            this.applicationOfSWEmethods_comboBox.SelectedIndexChanged += new System.EventHandler(this.applicationOfSWEmethods_comboBox_SelectedIndexChanged);
            // 
            // useOfSWtools_comboBox
            // 
            this.useOfSWtools_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.useOfSWtools_comboBox.FormattingEnabled = true;
            this.useOfSWtools_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.useOfSWtools_comboBox.Location = new System.Drawing.Point(294, 67);
            this.useOfSWtools_comboBox.Name = "useOfSWtools_comboBox";
            this.useOfSWtools_comboBox.Size = new System.Drawing.Size(135, 28);
            this.useOfSWtools_comboBox.TabIndex = 23;
            this.useOfSWtools_comboBox.SelectedIndexChanged += new System.EventHandler(this.useOfSWtools_comboBox_SelectedIndexChanged);
            // 
            // reqDevSchedule_comboBox
            // 
            this.reqDevSchedule_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very high"});
            this.reqDevSchedule_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reqDevSchedule_comboBox.FormattingEnabled = true;
            this.reqDevSchedule_comboBox.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.reqDevSchedule_comboBox.Location = new System.Drawing.Point(294, 108);
            this.reqDevSchedule_comboBox.Name = "reqDevSchedule_comboBox";
            this.reqDevSchedule_comboBox.Size = new System.Drawing.Size(135, 28);
            this.reqDevSchedule_comboBox.TabIndex = 22;
            this.reqDevSchedule_comboBox.SelectedIndexChanged += new System.EventHandler(this.reqDevSchedule_comboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(223, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Required development schedule";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Use of software tools";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(310, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Application of software engineering methods";
            // 
            // calculateEAF
            // 
            this.calculateEAF.Location = new System.Drawing.Point(366, 496);
            this.calculateEAF.Name = "calculateEAF";
            this.calculateEAF.Size = new System.Drawing.Size(160, 46);
            this.calculateEAF.TabIndex = 18;
            this.calculateEAF.Text = "Calculate Actual Effort";
            this.calculateEAF.UseVisualStyleBackColor = true;
            this.calculateEAF.Click += new System.EventHandler(this.calculateEAF_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(415, 556);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(652, 536);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "label17";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 603);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.calculateEAF);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ReqSWRelaibility_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SizeOfappDB_comboBox;
        private System.Windows.Forms.ComboBox ComplixtyOfProject_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox runtimePreformance_comboBox;
        private System.Windows.Forms.ComboBox volatilityOfVirtualMachineEnv_comboBox;
        private System.Windows.Forms.ComboBox MemoryConstraints_comboBox;
        private System.Windows.Forms.ComboBox reqTurnabout_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ProgrammingLangExp_comboBox;
        private System.Windows.Forms.ComboBox virtualMachineExp_comboBox;
        private System.Windows.Forms.ComboBox SWengineerCapability_comboBox;
        private System.Windows.Forms.ComboBox appExp_comboBox;
        private System.Windows.Forms.ComboBox analystCapability_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox applicationOfSWEmethods_comboBox;
        private System.Windows.Forms.ComboBox useOfSWtools_comboBox;
        private System.Windows.Forms.ComboBox reqDevSchedule_comboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calculateEAF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox MemotyConstraints_comboBox;
        private System.Windows.Forms.Label label17;
    }
}