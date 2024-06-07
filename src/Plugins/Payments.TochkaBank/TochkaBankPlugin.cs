using Grand.Business.Core.Extensions;
using Grand.Business.Core.Interfaces.Common.Localization;
using Grand.Infrastructure.Plugins;
using System.Threading.Tasks;

public class TochkaBankPlugin : BasePlugin
    {
        private readonly ITranslationService _translationService;
        private readonly ILanguageService _languageService;

        public TochkaBankPlugin(ITranslationService translationService,ILanguageService languageService)
        {
            _translationService = translationService;
            _languageService = languageService;
        }
		
        public override string ConfigurationUrl()
        {
            return "/Admin/TochkaBankPlugin/Configure";
        }

        public async override Task Install()
        {            
            await this.AddOrUpdatePluginTranslateResource(_translationService,     _languageService, "Plugins.Payments.TochkaBank.Value", "Sample value");
            await base.Install();
        }

        public async override Task Uninstall()
        {
            await this.DeletePluginTranslationResource(_translationService, _languageService, "Plugins.Payments.TochkaBank.Value");
            await base.Uninstall();
        }
    }