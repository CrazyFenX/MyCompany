using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Service
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;

        public AdminAreaAuthorization(string _area, string _policy)
        {
            this.area = _area;
            this.policy = _policy;
        }
        public void Apply(ControllerModel controller)
        {
            throw new NotImplementedException();
        }
    }
}
