﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Issuers
{
    [System.Serializable]
    public class IssuerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public byte[] Picture { get; set; }
        public int PlexoId { get; set; }
        public bool Active { get; set; }
    }
}