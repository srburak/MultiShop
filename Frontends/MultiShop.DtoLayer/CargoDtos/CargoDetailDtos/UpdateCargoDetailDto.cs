﻿namespace MultiShop.DtoLayer.CargoDtos.CargoDetailDtos
{
    public class UpdateCargoDetailDto
    {
        public int CargoDetailId { get; set; }
        public string SenderCustomer { get; set; }
        public string ReceiverCustomer { get; set; }
        public int Barcode { get; set; }
        public int CargoCompanyId { get; set; }
       //public CargoCompany CargoCompany { get; set; }
    }
}
