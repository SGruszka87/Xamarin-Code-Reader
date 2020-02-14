using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XfBarCode
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cpBarCode_Appearing(object sender, EventArgs e)
        {
            Akcja.DeviceKeyPressed += Akcja_DeviceKeyPressed;
            Akcja.DeviceSkanerUsed += Akcja_DeviceSkanerUsed;
        }

        private bool Akcja_DeviceSkanerUsed(string sKod, string sTyp)
        {
            if (sKod.StartsWith("P")) // Jeżeli kod zaczyna się od "P" np "P43123-123-55" to tutaj wskakuje do tego if'a
            {
                               
            }
            if (sKod.Contains(@"/") || sKod.Contains(@"-")) // Jeżeli kod ma w sobie "/" lub "-" to wskakuje do tego if'a 
            {
               
            }

            if (sKod.Length == 4)  // Jeżeli długość kodu wynosi 4 to tutaj wskakuje do tego if'a 
            {
               
            }
            return true;
        }

        private bool Akcja_DeviceKeyPressed(string sKod)
        {
            //Jeśli zostanie naciśnięty przycisk Enter na klawiaturze to wskoczy nam do tego if'a
            if (sKod == "Enter")
            {
                  
            }
            


            return true;
        }

        private void cpBarCode_Disappearing(object sender, EventArgs e)
        {
            Akcja.DeviceKeyPressed -= Akcja_DeviceKeyPressed;
            Akcja.DeviceSkanerUsed -= Akcja_DeviceSkanerUsed;
        }

        
    }
}
