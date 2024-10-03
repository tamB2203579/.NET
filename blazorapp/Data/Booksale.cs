using System;
using System.Collections.Generic;

namespace blazorapp.Data;

public partial class Booksale
{
    public int SaleId { get; set; }

    public string Title { get; set; } = null!;

    public int Quantity { get; set; }

    public double Price { get; set; }
}
