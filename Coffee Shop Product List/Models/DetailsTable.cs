using System;
using System.Collections.Generic;

namespace Coffee_Shop_Product_List.Models;

public partial class DetailsTable
{
    public int Id { get; set; }

    public int? Cals { get; set; }

    public int ProductId { get; set; }

    public virtual ProductTable Product { get; set; } = null!;
}
