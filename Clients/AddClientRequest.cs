﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class AddClientRequest
    {
        public string AdminUserId { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
        public string ClientLegalName { get; set; }
        public string ClientRFC { get; set; }
    }
}
