




using System.Web.Http;

namespace WebHookApplication
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveGitHubWebHooks();

        }
    }
}
