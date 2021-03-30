
namespace Bai3
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerBai3 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerBai3 = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerBai3
            // 
            this.serviceProcessInstallerBai3.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerBai3.Password = null;
            this.serviceProcessInstallerBai3.Username = null;
            // 
            // serviceInstallerBai3
            // 
            this.serviceInstallerBai3.Description = "Bai 3 demo";
            this.serviceInstallerBai3.DisplayName = "Bai3.Demo";
            this.serviceInstallerBai3.ServiceName = "Bai3";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerBai3,
            this.serviceInstallerBai3});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerBai3;
        private System.ServiceProcess.ServiceInstaller serviceInstallerBai3;
    }
}