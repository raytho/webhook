




using System.Web.Http;

namespace GenericJsonWebHook
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveGenericJsonWebHooks();

        }
    }
}
