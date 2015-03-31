﻿using System.Runtime.Serialization;
using GogoKit.Models;
using HalKit.Json;
using HalKit.Models;
using HalKit.Resources;

namespace GogoKit.Resources
{
    public class Listing : Resource
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "number_of_tickets")]
        public int? NumberOfTickets { get; set; }

        [DataMember(Name = "seating")]
        public Seating Seating { get; set; }

        [DataMember(Name = "pickup_available")]
        public bool? IsPickupAvailable { get; set; }

        [DataMember(Name = "download_available")]
        public bool? IsDownloadAvailable { get; set; }

        [DataMember(Name = "ticket_price")]
        public Money TicketPrice { get; set; }

        [DataMember(Name = "estimated_ticket_price")]
        public Money EstimatedTicketPrice { get; set; }

        [DataMember(Name = "estimated_total_ticket_price")]
        public Money EstimatedTotalTicketPrice { get; set; }

        [DataMember(Name = "estimated_booking_fee")]
        public Money EstimatedBookingFee { get; set; }

        [DataMember(Name = "estimated_shipping")]
        public Money EstimatedShipping { get; set; }

        [DataMember(Name = "estimated_vat")]
        public Money EstimatedVat { get; set; }

        [DataMember(Name = "estimated_total_charge")]
        public Money EstimatedTotalCharge { get; set; }

        [Embedded("ticket_type")]
        public TicketType TicketType { get; set; }

        public Link PurchasePreviewLink
        {
            get { return Links["listing:purchasepreview"]; }
        }
    }
}
