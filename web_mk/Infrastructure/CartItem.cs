﻿using web_mk.Models;

namespace web_mk.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }
        public int Quantity { get; set; }
        public decimal? Value { get; set; }
    }
}