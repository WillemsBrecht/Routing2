using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing2.Common
{
    public class GenderOptionConstraint : IRouteConstraint {
        public bool Match(HttpContext httpContext, IRouter route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {
            return Enum.GetNames(typeof(GenderOptions)).Any(s => s.ToLowerInvariant() == values[parameterName].ToString().ToLowerInvariant());
        }
    }
}
