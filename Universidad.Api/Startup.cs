using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Universidad.Logica_.Models;

[assembly: OwinStartup(typeof(Universidad.Api.Startup))]

namespace Universidad.Api
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // Para obtener más información sobre cómo configurar la aplicación, visite https://go.microsoft.com/fwlink/?LinkID=316888
            //Configure to the context of Universitt Entity to use a single instance per request
            app.CreatePerOwinContext(UniversityEntities.create);
        }
    }
}
