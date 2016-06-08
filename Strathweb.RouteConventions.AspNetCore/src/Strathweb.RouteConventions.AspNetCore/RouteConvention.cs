using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Strathweb.RouteConventions.AspNetCore
{
    public class RouteConvention : IApplicationModelConvention
    {
        private readonly IRouteTemplateProvider _routeTemplateProvider;

        public RouteConvention(IRouteTemplateProvider routeTemplateProvider)
        {
            _routeTemplateProvider = routeTemplateProvider;
        }

        public void Apply(ApplicationModel application)
        {
            var centralPrefix = new AttributeRouteModel(_routeTemplateProvider);
            foreach (var controller in application.Controllers)
            {
                var attributeRouteSelectors = controller.Selectors.Where(x => x.AttributeRouteModel != null).ToList();
                if (attributeRouteSelectors.Any())
                {
                    foreach (var selectorModel in attributeRouteSelectors)
                    {
                        selectorModel.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(centralPrefix,
                            selectorModel.AttributeRouteModel);
                    }
                }
            }
        }
    }
}
