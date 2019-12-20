namespace Solution2.Module.Controllers
{
    partial class PetController
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
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.Masters = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = null;
            this.simpleAction1.ConfirmationMessage = null;
            this.simpleAction1.Id = "266311f9-7c6c-4f1b-9855-4ace4cf0ae1a";
            this.simpleAction1.ToolTip = null;
            this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SimpleAction1_Execute);
            // 
            // Masters
            // 
            this.Masters.AcceptButtonCaption = null;
            this.Masters.CancelButtonCaption = null;
            this.Masters.Caption = "Masters";
            this.Masters.ConfirmationMessage = null;
            this.Masters.Id = "Masters";
            this.Masters.ToolTip = null;
            this.Masters.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.Masters_CustomizePopupWindowParams);
            this.Masters.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.Masters_Execute);
            // 
            // PetController
            // 
            this.Actions.Add(this.simpleAction1);
            this.Actions.Add(this.Masters);
            this.ViewControlsCreated += new System.EventHandler(this.PetController_ViewControlsCreated);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction Masters;
    }
}
