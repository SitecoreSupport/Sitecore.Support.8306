namespace Sitecore.Support.XA.Feature.Context.Repositories.LanguageSelector
{
  using Sitecore.Data.Items;
  using Sitecore.Links;

  public class LanguageSelectorRepository : Sitecore.XA.Feature.Context.Repositories.LanguageSelector.LanguageSelectorRepository
  {
    protected override UrlOptions BuildUrlOptions(Item item)
    {
      UrlOptions defaultOptions = base.BuildUrlOptions(item);
      #region Changed code
      defaultOptions.LanguageLocation = Sitecore.Links.LinkManager.LanguageLocation; 
      #endregion
      return defaultOptions;
    }
  }
}