using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventMangementSystem.Models
{
    public class EventInventory
    {
        public int EventInventoryId { get; set; }
        public int EventId { get; set; }
        public int InventoryId { get; set; }
        public int QuantityRequired { get; set; }

        public virtual Event Event { get; set; }
        public virtual Inventory Inventory { get; set; }
    }

    



}