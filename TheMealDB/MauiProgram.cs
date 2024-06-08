using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace TheMealDB
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("materialdesignicons.ttf", "MaterialFontFamily");
                }); 
#if __ANDROID__
            ImageHandler.Mapper.PrependToMapping(nameof(Microsoft.Maui.IImage.Source), (handler, view) => PrependToMappingImageSource(handler, view));
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

#if __ANDROID__
        public static void PrependToMappingImageSource(IImageHandler handler, Microsoft.Maui.IImage image)
        {
            handler.PlatformView?.Clear();
        }
#endif
    }
}
