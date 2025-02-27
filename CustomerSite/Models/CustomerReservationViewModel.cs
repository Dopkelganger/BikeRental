﻿using BikeRentalApi.Models;
using System;

namespace CustomerSite.Models
{
    public class CustomerReservationViewModel
    {
        public Customer Customer { get; set; }
        public int DaysRequested { get; set; }
        public int RequestedBikeId { get; set; }
    }
}
