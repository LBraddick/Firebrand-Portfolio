namespace Test_FrameWork
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "https://www.pluralsight.com/";
            private static string PageTitle = "Pluralsight - Hardcore Developer Training";

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
            }
        }
    }
}