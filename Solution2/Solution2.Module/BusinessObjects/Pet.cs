using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace Solution2.Module.BusinessObjects
{
    [DefaultClassOptions]
    [Persistent("Pets")]
    public class Pet : BaseObject
    { 
        public Pet(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { SetPropertyValue<int>(nameof(Id), ref _Id, value); }
        }


        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }


        private Master _Master;
        [Association]
        public Master Master
        {
            get { return _Master; }
            set { SetPropertyValue<Master>(nameof(Master), ref _Master, value); }
        }
    }
}