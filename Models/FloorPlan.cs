﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HexagonSanDiego.Models
{
    public enum Status
    {
        Active,
        Deactive
    }
    public class FloorPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bed { get; set; }
        public int SqFeet { get; set; }
        public string Rent { get; set; }
        public int Deposit { get; set; }
        public string ImageUrl { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Status Status { get; set; } = Status.Active;

    }
}
