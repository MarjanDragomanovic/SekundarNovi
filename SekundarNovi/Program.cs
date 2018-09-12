using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekundarNovi
{
    static class Program
    {
        //Create an instance of the splash screen
        static SplashScreen splashScreen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmOsnovna());

            //Inicialize the splashscreen. Say the welcome message.
            splashScreen = new SplashScreen();
            splashScreen.Show();
            //splashScreen.SayWelcome();

            //Create an instance of FrmOsnovna and hook into shown and closed events.
            FrmOsnovna osnovna = new FrmOsnovna();
            osnovna.Shown += osnovna_Shown;
            osnovna.FormClosed += osnovna_FormClosed;

            Application.Run(osnovna);
        }

        static void osnovna_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hide the calling form
            Form form = sender as Form;
            form.Hide();

            //Show the splash screen and say goodbay.
            splashScreen.Show();
            //splashScreen.SayGoodBay();
            System.Threading.Thread.Sleep(1000);  //Pauziraj sekundu.
        }

        static void osnovna_Shown(object sender, EventArgs e)
        {
            // Hide splashScreen.
            splashScreen.Hide();
        }
    }
}
