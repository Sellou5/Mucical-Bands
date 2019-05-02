﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.Networking.Connectivity;

namespace Bands
{
    class InternetConnection
    {
        public static bool IsConnectedToInternet()
        {
            ConnectionProfile connectionProfile = NetworkInformation.GetInternetConnectionProfile();
            return (connectionProfile != null && connectionProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
        }
    }
}
