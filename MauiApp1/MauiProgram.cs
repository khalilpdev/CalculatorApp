using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        /// <summary>
        /// https://youtu.be/3OQSEO2Ubus?t=268
        /// </summary>
        /// <returns></returns>
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
