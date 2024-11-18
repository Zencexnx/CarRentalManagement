﻿namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }

        public DateTime DateIn { get; set; }
        public int VehicleID { get; set; }

        public int CustomerID { get; set; }
    }
}
