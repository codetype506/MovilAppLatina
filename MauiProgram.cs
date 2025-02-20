﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MovilApp.IServicios;
using MovilApp.Servicios;
using MovilApp.Vistas;

namespace MovilApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>().UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<ClientesPage>();
            builder.Services.AddSingleton<IGeneralAPI, GeneralAPI>();
            builder.Services.AddSingleton<IServicioCliente, ServicioCliente>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}