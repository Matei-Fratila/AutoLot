namespace AutoLot.Mvc.ViewComponents;

public class MenuViewComponent : ViewComponent
{
    private readonly IMakeDataService _dataService;
    public MenuViewComponent(IMakeDataService dataService)
    {
        _dataService = dataService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var makes = (await _dataService.GetAllAsync()).ToList();
        if (!makes.Any())
        {
            return new ContentViewComponentResult("Unable to get the makes");
        }
        return View("MenuView", makes);
    }
}
