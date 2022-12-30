using deserializer2.Controllers;
using deserializer2.Interfaces;
using deserializer2.Model;
using deserializer2.View;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().ConfigureServices(Configure).Build();
var app = ActivatorUtilities.CreateInstance<App>(host.Services);
app.Start();
void Configure(IServiceCollection service)
{
    service.AddTransient<IMenu, Menu>();
    service.AddTransient<IDeserializer, Deserializer>();
    service.AddTransient<ISerializer, Serializer>();
    service.AddTransient<IResponseProvider,ResponseProvider>();
    service.AddTransient<IController, Controller>();
    service.AddTransient<IListViewer,ListViewer>();
    service.AddTransient<IValidator, Validator>();
}