
namespace Bai2
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
            this.serviceProcessInstallerBai2 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerBai2 = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerBai2
            // 
            this.serviceProcessInstallerBai2.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerBai2.Password = null;
            this.serviceProcessInstallerBai2.Username = null;
            // 
            // serviceInstallerBai2
            // 
            this.serviceInstallerBai2.Description = "Bai 2 demo";
            this.serviceInstallerBai2.DisplayName = "Bai2.Demo";
            this.serviceInstallerBai2.ServiceName = "Bai2";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerBai2,
            this.serviceInstallerBai2});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerBai2;
        private System.ServiceProcess.ServiceInstaller serviceInstallerBai2;
    }
}