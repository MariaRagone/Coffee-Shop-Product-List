using System;
using System.Collections.Generic;

namespace Coffee_Shop_Product_List.Models;

public partial class ProductTable
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public double? ProductPrice { get; set; }

    public string? ProductCategory { get; set; }

    public virtual ICollection<DetailsTable> DetailsTables { get; set; } = new List<DetailsTable>();
}
