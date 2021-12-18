using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cocomo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //product attributes 
        double ReqSWRelaibility = 1.0, SizeOfappDB = 1.0, ComplixtyOfProject = 1.0;

        //hardware attributes
        double runtimePreformance = 1.0, MemoryConstraints = 1.0, volatilityOfVirtualMachineEnv = 1.0, reqTurnabout = 1.0;

        //personal attributes
        double analystCapability = 1.0, appExp = 1.0, SWengineerCapability = 1.0, virtualMachineExp = 1.0, ProgrammingLangExp = 1.0;

        //project attributes
        double applicationOfSWEmethods = 1.0, useOfSWtools = 1.0, reqDevSchedule = 1.0;

        double EAF;
        public static double actualEffort;



        //product attributes 
        private void ReqSWRelaibility_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReqSWRelaibility_comboBox.SelectedItem == "Very Low")
            {
                ReqSWRelaibility =0.75;
            }
            else if (ReqSWRelaibility_comboBox.SelectedItem == "Low")
            {
                ReqSWRelaibility = 0.88;
            }
            else if (ReqSWRelaibility_comboBox.SelectedItem == "Nominal")
            {
                ReqSWRelaibility = 1.0;
            }
            else if (ReqSWRelaibility_comboBox.SelectedItem == "High")
            {
                ReqSWRelaibility = 1.15;
            }
            else if (ReqSWRelaibility_comboBox.SelectedItem == "Very High")
            {
                ReqSWRelaibility = 1.40;
            }
        }

        private void SizeOfappDB_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SizeOfappDB_comboBox.SelectedItem == "Low")
            {
                SizeOfappDB = 0.94;
            }
            else if (SizeOfappDB_comboBox.SelectedItem == "Nominal")
            {
                SizeOfappDB = 1.0;
            }
            else if (SizeOfappDB_comboBox.SelectedItem == "High")
            {
                SizeOfappDB = 1.08;
            }
            else if (SizeOfappDB_comboBox.SelectedItem == "Very High")
            {
                SizeOfappDB = 1.16;
            }
        }

        private void ComplixtyOfProject_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComplixtyOfProject_comboBox.SelectedItem == "Very Low")
            {
                ComplixtyOfProject = 0.70;
            }
            else if (ComplixtyOfProject_comboBox.SelectedItem == "Low")
            {
                ComplixtyOfProject = 0.85;
            }
            else if (ComplixtyOfProject_comboBox.SelectedItem == "Nominal")
            {
                ComplixtyOfProject = 1.0;
            }
            else if (ComplixtyOfProject_comboBox.SelectedItem == "High")
            {
                ComplixtyOfProject = 1.15;
            }
            else if (ComplixtyOfProject_comboBox.SelectedItem == "Very High")
            {
                ComplixtyOfProject = 1.30;
            }
            else if (ComplixtyOfProject_comboBox.SelectedItem == "Extra High")
            {
                ComplixtyOfProject = 1.65;
            }
        }
        
        


        //hardware attributes
        private void runtimePreformance_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (runtimePreformance_comboBox.SelectedItem == "Nominal")
            {
                runtimePreformance = 1.0;
            }
            else if (runtimePreformance_comboBox.SelectedItem == "High")
            {
                runtimePreformance = 1.11;
            }
            else if (runtimePreformance_comboBox.SelectedItem == "Very High")
            {
                runtimePreformance = 1.30;
            }
            else if (runtimePreformance_comboBox.SelectedItem == "Extra High")
            {
                runtimePreformance = 1.66;
            }

        }

      
        private void MemoryConstraints_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemoryConstraints_comboBox.SelectedItem == "Nominal")
            {
                MemoryConstraints = 1.0;
            }
            else if (MemoryConstraints_comboBox.SelectedItem == "High")
            {
                MemoryConstraints = 1.06;
            }
            else if (MemoryConstraints_comboBox.SelectedItem == "Very High")
            {
                MemoryConstraints = 1.21;
            }
            else if (MemoryConstraints_comboBox.SelectedItem == "Extra High")
            {
                MemoryConstraints = 1.56;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void volatilityOfVirtualMachineEnv_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (volatilityOfVirtualMachineEnv_comboBox.SelectedItem == "Low")
            {
                volatilityOfVirtualMachineEnv = 0.87;
            }
            else if (volatilityOfVirtualMachineEnv_comboBox.SelectedItem == "Nominal")
            {
                volatilityOfVirtualMachineEnv = 1.0;
            }
            else if (volatilityOfVirtualMachineEnv_comboBox.SelectedItem == "High")
            {
                volatilityOfVirtualMachineEnv = 1.15;
            }
            else if (volatilityOfVirtualMachineEnv_comboBox.SelectedItem == "Very High")
            {
                volatilityOfVirtualMachineEnv = 1.30;
            }
            
        }
        
        private void reqTurnabout_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reqTurnabout_comboBox.SelectedItem == "Low")
            {
                reqTurnabout = 0.87;
            }
            else if (reqTurnabout_comboBox.SelectedItem == "Nominal")
            {
                reqTurnabout = 1.0;
            }
            else if (reqTurnabout_comboBox.SelectedItem == "High")
            {
                reqTurnabout = 1.07;
            }
            else if (reqTurnabout_comboBox.SelectedItem == "Very High")
            {
                reqTurnabout = 1.15;
            }
        }




        //personal attributes
        private void analystCapability_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (analystCapability_comboBox.SelectedItem == "Very Low")
            {
                analystCapability = 1.46;
            }
            else if (analystCapability_comboBox.SelectedItem == "Low")
            {
                analystCapability = 1.19;
            }
            else if (analystCapability_comboBox.SelectedItem == "Nominal")
            {
                analystCapability = 1.0;
            }
            else if (analystCapability_comboBox.SelectedItem == "High")
            {
                analystCapability = 0.86;
            }
            else if (analystCapability_comboBox.SelectedItem == "Very High")
            {
                analystCapability = 0.71;
            }
           
        }
        
        private void appExp_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appExp_comboBox.SelectedItem == "Very Low")
            {
                appExp = 1.29;
            }
            else if (appExp_comboBox.SelectedItem == "Low")
            {
                appExp = 1.13;
            }
            else if (appExp_comboBox.SelectedItem == "Nominal")
            {
                appExp = 1.0;
            }
            else if (appExp_comboBox.SelectedItem == "High")
            {
                appExp = 0.91;
            }
            else if (appExp_comboBox.SelectedItem == "Very High")
            {
                appExp = 0.82;
            }
        }

     
        private void SWengineerCapability_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appExp_comboBox.SelectedItem == "Very Low")
            {
                SWengineerCapability = 1.42;
            }
            else if (appExp_comboBox.SelectedItem == "Low")
            {
                SWengineerCapability = 1.17;
            }
            else if (appExp_comboBox.SelectedItem == "Nominal")
            {
                SWengineerCapability = 1.0;
            }
            else if (appExp_comboBox.SelectedItem == "High")
            {
                SWengineerCapability = 0.86;
            }
            else if (appExp_comboBox.SelectedItem == "Very High")
            {
                SWengineerCapability = 0.70;
            }
        }

        private void virtualMachineExp_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (virtualMachineExp_comboBox.SelectedItem == "Very Low")
            {
                virtualMachineExp = 1.21;
            }
            else if (virtualMachineExp_comboBox.SelectedItem == "Low")
            {
                virtualMachineExp = 1.10;
            }
            else if (virtualMachineExp_comboBox.SelectedItem == "Nominal")
            {
                virtualMachineExp = 1.0;
            }
            else if (virtualMachineExp_comboBox.SelectedItem == "High")
            {
                virtualMachineExp = 0.90;
            }
        }

        private void ProgrammingLangExp_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProgrammingLangExp_comboBox.SelectedItem == "Very Low")
            {
                ProgrammingLangExp = 1.14;
            }
            else if (ProgrammingLangExp_comboBox.SelectedItem == "Low")
            {
                ProgrammingLangExp = 1.07;
            }
            else if (ProgrammingLangExp_comboBox.SelectedItem == "Nominal")
            {
                ProgrammingLangExp = 1.0;
            }
            else if (ProgrammingLangExp_comboBox.SelectedItem == "High")
            {
                ProgrammingLangExp = 0.95;
            }
        }



        //project attributes  
        private void applicationOfSWEmethods_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (applicationOfSWEmethods_comboBox.SelectedItem == "Very Low")
            {
                applicationOfSWEmethods = 1.24;
            }
            else if (applicationOfSWEmethods_comboBox.SelectedItem == "Low")
            {
                applicationOfSWEmethods = 1.08;
            }
            else if (applicationOfSWEmethods_comboBox.SelectedItem == "Nominal")
            {
                applicationOfSWEmethods = 1.0;
            }
            else if (applicationOfSWEmethods_comboBox.SelectedItem == "High")
            {
                applicationOfSWEmethods = 0.91;
            }
            else if (applicationOfSWEmethods_comboBox.SelectedItem == "Very High")
            {
                applicationOfSWEmethods = 0.82;
            }
        }
        
        private void useOfSWtools_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (useOfSWtools_comboBox.SelectedItem == "Very Low")
            {
                useOfSWtools = 1.24;
            }
            else if (useOfSWtools_comboBox.SelectedItem == "Low")
            {
                useOfSWtools = 1.10;
            }
            else if (useOfSWtools_comboBox.SelectedItem == "Nominal")
            {
                useOfSWtools = 1.0;
            }
            else if (useOfSWtools_comboBox.SelectedItem == "High")
            {
                useOfSWtools = 0.91;
            }
            else if (useOfSWtools_comboBox.SelectedItem == "Very High")
            {
                useOfSWtools = 0.83;
            }
        }
        
        private void reqDevSchedule_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reqDevSchedule_comboBox.SelectedItem == "Very Low")
            {
                reqDevSchedule = 1.23;
            }
            else if (reqDevSchedule_comboBox.SelectedItem == "Low")
            {
                reqDevSchedule = 1.08;
            }
            else if (reqDevSchedule_comboBox.SelectedItem == "Nominal")
            {
                reqDevSchedule = 1.0;
            }
            else if (reqDevSchedule_comboBox.SelectedItem == "High")
            {
                reqDevSchedule = 1.04;
            }
            else if (reqDevSchedule_comboBox.SelectedItem == "Very High")
            {
                reqDevSchedule = 1.10;
            }
        }

        //Calculate the value
        private void calculateEAF_Click(object sender, EventArgs e)
        {
            EAF = ReqSWRelaibility * SizeOfappDB * ComplixtyOfProject * 
                runtimePreformance *MemoryConstraints *volatilityOfVirtualMachineEnv * reqTurnabout * 
                analystCapability * appExp *  SWengineerCapability * virtualMachineExp *  ProgrammingLangExp * 
                applicationOfSWEmethods *  useOfSWtools * reqDevSchedule;
            actualEffort = Form3.newEffort * EAF;
            int newactualEffort = Convert.ToInt32(actualEffort);

            label16.Text = newactualEffort.ToString();
            label17.Text = EAF.ToString();
        }




    }
}
