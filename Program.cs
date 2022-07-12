namespace OPCUAReadData
{
    internal static class Program
    {
        //public static ReadData Root = new ReadData();
        //public static Form1 theForm1 = new Form1(Root);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}