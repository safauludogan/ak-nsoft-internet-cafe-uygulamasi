﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace subp2
{
    class i_control
    {
        public bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
