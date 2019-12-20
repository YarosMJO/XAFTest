using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Solution2.Module.BusinessObjects;

namespace Solution2.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PetController : ViewController
    {
        public PetController()
        {
            InitializeComponent();
            TargetObjectType = typeof(Pet);

            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void SimpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace space = View.ObjectSpace.CreateNestedObjectSpace();


        }

        private void Masters_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
           
        }

        private void PetController_ViewControlsCreated(object sender, EventArgs e)
        {

        }

        private void Masters_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var separateObjectSpace = Application.CreateObjectSpace(typeof(Master));

            //DetailView rootDetailView = (DetailView)Application.MainWindow.View;
            //var fundItemMetadata = separateObjectSpace.GetObjectByKey<FundItemMetadata>(((FundItemMetadata)(rootDetailView.CurrentObject)).Id);
            var newObj = new Master(((XPObjectSpace)separateObjectSpace).Session);
           
            var source= new CollectionSource(ObjectSpace,typeof(Master),false);
            e.View = Application.CreateListView("Master_ListView", source, false);
            e.DialogController.SaveOnAccept = false;
        }
    }
}
