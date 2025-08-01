using DeepSubconciusClass;

namespace DeepSubconciusDesk
{
    internal static class Program
    {
        public static Usuario UsuarioLogado { get; set; } = new Usuario();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}