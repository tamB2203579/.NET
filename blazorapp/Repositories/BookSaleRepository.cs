using System.ComponentModel;
using blazorapp.Data;

namespace blazorapp.Repositories;

public class BookSaleRepository : IBookSaleRepository{
    BookSalesContext context;
    public BookSaleRepository(BookSalesContext context){
        this.context = context;
    }
    public async Task AddNewSale(Booksale booksale){
        this.context.Add(booksale);
        this.context.SaveChangesAsync();
    }
}