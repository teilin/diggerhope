using System;
using Facebook;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace DiggerHope.Services
{
    public class FacebookService
    {
        private readonly IHostingEnvironment _env;
        private readonly AppSettings _appSettings;
        private readonly IMemoryCache _cache;
        private readonly FacebookClient _fbClient;

        public FacebookService(
            IHostingEnvironment environment,
            IOptions<AppSettings> appSetting,
            IMemoryCache cache
        )
        {
            _env = environment;
            _cache = cache;
            _appSettings = appSetting.Value;

            _fbClient = new FacebookClient();
        }

        private async void GetImages()
        {
            _fbClient.Get("");
        }
    }
}