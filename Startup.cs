using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HelloWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                var a=5;
                var b=10;
                b=+20;
                
                //throw new Exception("aaa111");

                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
