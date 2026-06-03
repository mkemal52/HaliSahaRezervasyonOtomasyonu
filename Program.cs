using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliSahaRezervasyonOtomasyonu
{
    /// <summary>
    /// Program sınıfı - Uygulamanın giriş noktası (Entry Point).
    /// Windows Forms uygulaması burada başlatılır.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// [STAThread] -> Single Thread Apartment: Windows Forms için gereklidir.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
