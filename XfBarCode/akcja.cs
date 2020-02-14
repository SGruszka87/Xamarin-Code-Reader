using System;
using System.Collections.Generic;
using System.Text;

namespace XfBarCode
{
    public delegate bool handler(string sKod, string sTyp);
    public delegate bool handler2(string sKod);
    public class Akcja
    {
        public static event handler DeviceSkanerUsed;
        public static event handler2 DeviceKeyPressed;

        public static bool DeviceActivity(string sKod, string sTyp)
        {
            bool bRet = true;
            try
            {
                if (sTyp == null)
                {
                    //obsluga przycisku
                    bRet = DeviceKeyPressed(sKod);
                    bRet = true;
                   
                }
                else
                {
                    // obsluga kodu
                    DeviceSkanerUsed(sKod, sTyp);
                    bRet = false;
                }
            }
            catch
            { }
            return bRet;
        }
    }
}
