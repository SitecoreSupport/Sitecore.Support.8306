namespace Sitecore.Support.XA.Feature.Context.Pipelines.IoC
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.XA.Feature.Context.Repositories.LanguageSelector;
  using Sitecore.XA.Feature.Context.Repositories.SiteSelector;
  using Sitecore.XA.Foundation.IOC.Pipelines.IOC;

  public class RegisterContextServices : Sitecore.XA.Feature.Context.Pipelines.IoC.RegisterContextServices
  {
    public override void Process(IocArgs args)
    {
      args.ServiceCollection.AddTransient<ISiteSelectorRepository, SiteSelectorRepository>();
      args.ServiceCollection.AddTransient<ILanguageSelectorRepository, Sitecore.Support.XA.Feature.Context.Repositories.LanguageSelector.LanguageSelectorRepository>();
    }
  }
}