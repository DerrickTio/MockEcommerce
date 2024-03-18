using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MockEcommerce.Localization
{
    public static class MockEcommerceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MockEcommerceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MockEcommerceLocalizationConfigurer).GetAssembly(),
                        "MockEcommerce.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
