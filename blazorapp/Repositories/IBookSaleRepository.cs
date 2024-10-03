using blazorapp.Data;

namespace blazorapp.Repositories;

public interface IBookSaleRepository{
    Task AddNewSale(Booksale booksale);
}