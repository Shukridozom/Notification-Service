using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System;

namespace Notification_Service
{
    public static class FCM_ServiceDependencyInjection
    {
        public static IServiceCollection AddFCM_Service(this IServiceCollection services)
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("demoproject-c60fa-firebase-adminsdk-tabze-8c1a724348.json"),
            });

            services.AddSingleton<IFCM_Service, FCM_Service>();

            return services;
        }
    }
}
