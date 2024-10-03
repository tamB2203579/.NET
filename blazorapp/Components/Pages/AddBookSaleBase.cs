using blazorapp.Data;
using blazorapp.Repositories;
using Microsoft.AspNetCore.Components;

namespace blazorapp.Components.Pages;

public partial class AddBookSaleBase : ComponentBase
{
    public Booksale bookSale { get; set; } = new Booksale();

    // Dependency Injection
    [Inject]
    IBookSaleRepository bookSaleRepository { get; set; }

    [Inject]
    NavigationManager navigationManager { get; set; }

    public async Task handleValidSubmit(){
        await bookSaleRepository.AddNewSale(bookSale);
        navigationManager.NavigateTo("/");
    }
    public async Task Form_Calculate()
    {
        handleValidSubmit();
    }
}
