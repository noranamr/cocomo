
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
            this.TDEV_txtbox = new System.Windows.Forms.Label();
            this.effort_i_textbox = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.KLOC_txtbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ReqSWRelaibility_comboBox.Location = new System.Drawing.Point(269, 30);
            this.ReqSWRelaibility_comboBox.Name = "ReqSWRelaibility_comboBox";
            this.ReqSWRelaibility_comboBox.Size = new System.Drawing.Size(119, 29);
            this.ReqSWRelaibility_comboBox.TabIndex = 0;
            this.ReqSWRelaibility_comboBox.SelectedIndexChanged += new System.EventHandler(this.ReqSWRelaibility_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Required Software Reliability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size of application database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
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
            this.SizeOfappDB_comboBox.Location = new System.Drawing.Point(269, 70);
            this.SizeOfappDB_comboBox.Name = "SizeOfappDB_comboBox";
            this.SizeOfappDB_comboBox.Size = new System.Drawing.Size(119, 29);
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
            this.ComplixtyOfProject_comboBox.Location = new System.Drawing.Point(269, 103);
            this.ComplixtyOfProject_comboBox.Name = "ComplixtyOfProject_comboBox";
            this.ComplixtyOfProject_comboBox.Size = new System.Drawing.Size(119, 29);
            this.ComplixtyOfProject_comboBox.TabIndex = 5;
            this.ComplixtyOfProject_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComplixtyOfProject_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Run-time preformance constraints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Memory constraints";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Volatility of virtual machine enviroment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 21);
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
            this.runtimePreformance_comboBox.Location = new System.Drawing.Point(290, 40);
            this.runtimePreformance_comboBox.Name = "runtimePreformance_comboBox";
            this.runtimePreformance_comboBox.Size = new System.Drawing.Size(119, 29);
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
            this.volatilityOfVirtualMachineEnv_comboBox.Location = new System.Drawing.Point(290, 120);
            this.volatilityOfVirtualMachineEnv_comboBox.Name = "volatilityOfVirtualMachineEnv_comboBox";
            this.volatilityOfVirtualMachineEnv_comboBox.Size = new System.Drawing.Size(119, 29);
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
            this.MemoryConstraints_comboBox.Location = new System.Drawing.Point(290, 78);
            this.MemoryConstraints_comboBox.Name = "MemoryConstraints_comboBox";
            this.MemoryConstraints_comboBox.Size = new System.Drawing.Size(119, 29);
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
            this.reqTurnabout_comboBox.Location = new System.Drawing.Point(290, 161);
            this.reqTurnabout_comboBox.Name = "reqTurnabout_comboBox";
            this.reqTurnabout_comboBox.Size = new System.Drawing.Size(119, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(70, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 151);
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
            this.groupBox2.Location = new System.Drawing.Point(876, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 230);
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
            this.groupBox3.Location = new System.Drawing.Point(70, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 253);
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
            this.ProgrammingLangExp_comboBox.Location = new System.Drawing.Point(269, 206);
            this.ProgrammingLangExp_comboBox.Name = "ProgrammingLangExp_comboBox";
            this.ProgrammingLangExp_comboBox.Size = new System.Drawing.Size(151, 29);
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
            this.virtualMachineExp_comboBox.Location = new System.Drawing.Point(269, 162);
            this.virtualMachineExp_comboBox.Name = "virtualMachineExp_comboBox";
            this.virtualMachineExp_comboBox.Size = new System.Drawing.Size(151, 29);
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
            this.SWengineerCapability_comboBox.Location = new System.Drawing.Point(269, 118);
            this.SWengineerCapability_comboBox.Name = "SWengineerCapability_comboBox";
            this.SWengineerCapability_comboBox.Size = new System.Drawing.Size(151, 29);
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
            this.appExp_comboBox.Location = new System.Drawing.Point(269, 75);
            this.appExp_comboBox.Name = "appExp_comboBox";
            this.appExp_comboBox.Size = new System.Drawing.Size(151, 29);
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
            this.analystCapability_comboBox.Location = new System.Drawing.Point(269, 33);
            this.analystCapability_comboBox.Name = "analystCapability_comboBox";
            this.analystCapability_comboBox.Size = new System.Drawing.Size(151, 29);
            this.analystCapability_comboBox.TabIndex = 20;
            this.analystCapability_comboBox.SelectedIndexChanged += new System.EventHandler(this.analystCapability_comboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Programming Language Experience";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Applications Experience";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Virtual Machine Experience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Analyst Capability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 21);
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
            this.groupBox4.Location = new System.Drawing.Point(653, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 168);
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
            this.applicationOfSWEmethods_comboBox.Location = new System.Drawing.Point(331, 26);
            this.applicationOfSWEmethods_comboBox.Name = "applicationOfSWEmethods_comboBox";
            this.applicationOfSWEmethods_comboBox.Size = new System.Drawing.Size(151, 29);
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
            this.useOfSWtools_comboBox.Location = new System.Drawing.Point(331, 70);
            this.useOfSWtools_comboBox.Name = "useOfSWtools_comboBox";
            this.useOfSWtools_comboBox.Size = new System.Drawing.Size(151, 29);
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
            this.reqDevSchedule_comboBox.Location = new System.Drawing.Point(331, 113);
            this.reqDevSchedule_comboBox.Name = "reqDevSchedule_comboBox";
            this.reqDevSchedule_comboBox.Size = new System.Drawing.Size(151, 29);
            this.reqDevSchedule_comboBox.TabIndex = 22;
            this.reqDevSchedule_comboBox.SelectedIndexChanged += new System.EventHandler(this.reqDevSchedule_comboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Required development schedule";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Use of software tools";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Application of software engineering methods";
            // 
            // calculateEAF
            // 
            this.calculateEAF.Location = new System.Drawing.Point(565, 567);
            this.calculateEAF.Name = "calculateEAF";
            this.calculateEAF.Size = new System.Drawing.Size(180, 48);
            this.calculateEAF.TabIndex = 18;
            this.calculateEAF.Text = "Calculate Actual Effort";
            this.calculateEAF.UseVisualStyleBackColor = true;
            this.calculateEAF.Click += new System.EventHandler(this.calculateEAF_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(597, 641);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = " Actual Effort";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(721, 641);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 21);
            this.label17.TabIndex = 20;
            this.label17.Text = "EAF";
            // 
            // TDEV_txtbox
            // 
            this.TDEV_txtbox.AutoSize = true;
            this.TDEV_txtbox.Location = new System.Drawing.Point(1251, 656);
            this.TDEV_txtbox.Name = "TDEV_txtbox";
            this.TDEV_txtbox.Size = new System.Drawing.Size(47, 21);
            this.TDEV_txtbox.TabIndex = 27;
            this.TDEV_txtbox.Text = "TDEV";
            // 
            // effort_i_textbox
            // 
            this.effort_i_textbox.AutoSize = true;
            this.effort_i_textbox.Location = new System.Drawing.Point(58, 233);
            this.effort_i_textbox.Name = "effort_i_textbox";
            this.effort_i_textbox.Size = new System.Drawing.Size(22, 21);
            this.effort_i_textbox.TabIndex = 26;
            this.effort_i_textbox.Text = "Ei";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1061, 642);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 49);
            this.button3.TabIndex = 25;
            this.button3.Text = "Calculate TDEV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(308, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 104);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 21);
            this.label20.TabIndex = 2;
            this.label20.Text = "Choose project type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Organic",
            "Semi-detached",
            "Embedded"});
            this.comboBox1.Location = new System.Drawing.Point(25, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calculate Effort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KLOC_txtbox
            // 
            this.KLOC_txtbox.Location = new System.Drawing.Point(34, 113);
            this.KLOC_txtbox.Name = "KLOC_txtbox";
            this.KLOC_txtbox.Size = new System.Drawing.Size(140, 29);
            this.KLOC_txtbox.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 21);
            this.label21.TabIndex = 21;
            this.label21.Text = "Enter K lines of code:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 783);
            this.Controls.Add(this.TDEV_txtbox);
            this.Controls.Add(this.effort_i_textbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KLOC_txtbox);
            this.Controls.Add(this.label21);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label TDEV_txtbox;
        private System.Windows.Forms.Label effort_i_textbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox KLOC_txtbox;
        private System.Windows.Forms.Label label21;
    }
}