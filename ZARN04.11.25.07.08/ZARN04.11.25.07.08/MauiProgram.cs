﻿// The entry point for configuring the MAUI app. It sets up MAUI essentials fonts, registers the BlazorWebView, and 
// crucially, registers device-specific services (like the MAUI implementation of IFormFactor found in ZARN04.11.25.07.08.Services.FormFactor)
using Microsoft.Extensions.Logging;
using ZARN04._11._25._07._08.Shared.Services;
using ZARN04._11._25._07._08.Services;

namespace ZARN04._11._25._07._08;

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
            });

        // Add device-specific services used by the ZARN04._11._25._07._08.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

}
