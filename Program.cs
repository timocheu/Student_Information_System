using Student_Information_System.Forms;
using System.Drawing.Text;

namespace Student_Information_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configurations
            if (!IsFontExist("Poppins"))
            {
                throw new Exception("Error: Unable to find Poppins font");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        static bool IsFontExist(string fontname)
        {
            using (InstalledFontCollection fonts = new())
            {
                return fonts.Families
                    .Any(x => x.Name.Equals(fontname, StringComparison.CurrentCultureIgnoreCase));
            }
        }
    }
}
