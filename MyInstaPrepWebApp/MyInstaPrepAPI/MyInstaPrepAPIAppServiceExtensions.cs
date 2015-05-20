using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace MyInstaPrepWebApp
{
    public static class MyInstaPrepAPIAppServiceExtensions
    {
        public static MyInstaPrepAPI CreateMyInstaPrepAPI(this IAppServiceClient client)
        {
            return new MyInstaPrepAPI(client.CreateHandler());
        }

        public static MyInstaPrepAPI CreateMyInstaPrepAPI(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new MyInstaPrepAPI(client.CreateHandler(handlers));
        }

        public static MyInstaPrepAPI CreateMyInstaPrepAPI(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new MyInstaPrepAPI(uri, client.CreateHandler(handlers));
        }

        public static MyInstaPrepAPI CreateMyInstaPrepAPI(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new MyInstaPrepAPI(rootHandler, client.CreateHandler(handlers));
        }
    }
}
