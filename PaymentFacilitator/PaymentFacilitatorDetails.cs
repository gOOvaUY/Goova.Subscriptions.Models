﻿using Goova.Subscriptions.Models.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.PaymentFacilitator
{
    public class PaymentFacilitatorDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<int> PaymentFacilitatorCommerceIds { get; set; }
        public int PaymentFacilitatorPlexoId { get; set; }
    }
}
