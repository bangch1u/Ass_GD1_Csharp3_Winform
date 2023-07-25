using Ass_GD1_Bangntph30138.View;
namespace Ass_GD1_Bangntph30138
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new fLogin());
        }
        //Scaffold-DbContext 'Data Source=BANGCHIU105\SQLEXPRESS01;Initial Catalog=FPL_DaoTao;Integrated Security=True ;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force

    }
}