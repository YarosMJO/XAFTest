using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;

namespace Solution2.Module.BusinessObjects
{
    [NavigationItem("Masters")]
    [ModelDefault("Name", "Yakobs")]
    [Persistent("Masters")]
    public class Master : BaseObject
    {
        public int Count { get; set; }
        public Master(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            Count++;
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

        [NonPersistent]
        public string _MasterNumber => string.Format("User {0} is {1} master in our Camp", this.Name, this.Count);

        #region Associations

        [Association]
        public XPCollection<Pet> Pets
        {
            get { return GetCollection<Pet>(nameof(Pets)); }
        }

        #endregion
    }
}