using MockEcommerce.Debugging;

namespace MockEcommerce
{
    public class MockEcommerceConsts
    {
        public const string LocalizationSourceName = "MockEcommerce";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8eac4d78571c4196b4510fb564099fe7";
    }
}
