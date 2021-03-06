﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenClient.Protocols.OAuthWrap
{
    public class ClientAccountPasswordTokenRequest
    {
        public ClientAccountPasswordTokenRequest(string clientId, string clientSecret, string scope)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scope = scope;
        }

        public string ClientId { get; private set; }

        public string ClientSecret { get; private set; }

        public string Scope { get; private set; }
    }
}
