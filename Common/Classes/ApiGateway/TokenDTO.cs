﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Common.Classes.ApiGateway
{
    public class TokenDTO
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public int expires_in { get; set; }
    }
}
