using CustomerAccountsUsingRaptorDb.Views;

namespace CustomerAccountsUsingRaptorDb.Common
{
    public static class Globals
    {
        public static RaptorDB.RaptorDB RaptorDb { get; set; }

        /// <summary>
        /// Starts RaptorDb
        /// </summary>
        public static void StartRaptorDb()
        {
            //Set up a perpetual "data" folder in the application's executing directory (i.e. /bin/debug)
            RaptorDb = RaptorDB.RaptorDB.Open("data");
            RaptorDB.Global.RequirePrimaryView = false;

            //Register entity views with RaptorDb
            RaptorDb.RegisterView(new CongTyView());
        }

        /// <summary>
        /// Stops RaptorDb
        /// </summary>
        public static void StopRaptorDb()
        {
            //Shut down RaptorDb
            RaptorDb.Shutdown();
        }
    }
}
