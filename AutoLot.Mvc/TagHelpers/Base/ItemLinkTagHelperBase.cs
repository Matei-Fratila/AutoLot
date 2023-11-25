namespace AutoLot.Mvc.TagHelpers.Base;

public abstract class ItemLinkTagHelperBase : TagHelper
{
    private readonly string _controllerName;

    protected readonly IUrlHelper UrlHelper;
    protected string ActionName { get; set; }

    //used as html attrivute item-id=""
    public int? ItemId { get; set; }

    public ItemLinkTagHelperBase(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
    {
        UrlHelper = urlHelperFactory.GetUrlHelper(contextAccessor.ActionContext);
        _controllerName = contextAccessor.ActionContext.ActionDescriptor.RouteValues["controller"];
    }

    protected void BuildContent(TagHelperOutput output, string cssClassName, string displayText, string fontAwesomeName)
    {
        output.TagName = "a"; // Replaces <item-> with <a> tag
        var target = (ItemId.HasValue)
            ? UrlHelper.Action(ActionName, _controllerName, new { id = ItemId })
            : UrlHelper.Action(ActionName, _controllerName);
        output.Attributes.SetAttribute("href", target);
        output.Attributes.Add("class", cssClassName);
        output.Content.AppendHtml($@"{displayText} <i class=""fas fa-{fontAwesomeName}""></i>");
    }
}
