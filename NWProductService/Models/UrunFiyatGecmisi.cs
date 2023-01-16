using System;
using System.Collections.Generic;

namespace NWProductService.Models;

public partial class UrunFiyatGecmisi
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public decimal? OldPrice { get; set; }

    public decimal? NewPrice { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
