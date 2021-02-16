using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities_.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
