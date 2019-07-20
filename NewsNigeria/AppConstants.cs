using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewsNigeria
{
    class AppConstants
    {
        public static string AppId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "";
                    default:
                        return "";

                }
            }
        }

        public static string BannerId
        {
            get
            {
                switch(Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-5351106223622825/1177948240";
                    default:
                        return "ca-app-pub-5351106223622825/1177948240";
                }
            }
        }
    }
}
