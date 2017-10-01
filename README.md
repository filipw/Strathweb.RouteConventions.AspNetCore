### 📢 IMPORTANT 📢 This feature has been added to [WebApiContrib.Core](https://github.com/WebApiContrib/WebAPIContrib.Core)

# Strathweb.RouteConventions.AspNetCore

ASP.NET Core MVC application model convention allowing you to specify a global route prefix that will be applied implicitly on every controller.

## Usage

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(opt =>
        {
            // now each route on every controller gets an "api" prefix
            opt.UseCentralRoutePrefix(new RouteAttribute("api"));
        });
    }
    
## Further reading

More info and background - [in a blog post](http://www.strathweb.com/2016/06/global-route-prefix-with-asp-net-core-mvc-revisited/)
