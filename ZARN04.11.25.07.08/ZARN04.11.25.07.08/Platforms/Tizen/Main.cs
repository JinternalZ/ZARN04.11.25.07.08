using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ZARN04._11._25._07._08;

class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
