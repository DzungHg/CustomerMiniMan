using CustomerAccountsUsingRaptorDb.Entities;
using CustomerAccountsUsingRaptorDb.Views.Schemas;
using RaptorDB;

namespace CustomerAccountsUsingRaptorDb.Views
{
    [RegisterView]
    public class CongTyView : View<CongTy>
    {
        public CongTyView()
        {
            this.Name = "CongTyView";
            this.Description = "A primary view for a CongTy object";
            this.isPrimaryList = true;
            this.isActive = true;
            this.BackgroundIndexing = false;
            this.Version = 1;
            this.ConsistentSaveToThisView = true;
            this.TransactionMode = false;

            this.Schema = typeof (CongTyViewRowSchema);

            this.Mapper = (api, docId, doc) =>
            {
                api.EmitObject(docId, doc);
            };
        }
    }
}
