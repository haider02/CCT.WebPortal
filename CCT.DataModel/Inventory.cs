//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCT.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int InventoryMasterId { get; set; }
        public int DiscountId { get; set; }
        public int ShopId { get; set; }
        public string InventoryTitle { get; set; }
        public string InventoryDescription { get; set; }
        public string PriceValueType { get; set; }
        public Nullable<decimal> UpPriceValue { get; set; }
        public decimal InventoryPrice { get; set; }
        public Nullable<bool> IsOutOfStock { get; set; }
    }
}
