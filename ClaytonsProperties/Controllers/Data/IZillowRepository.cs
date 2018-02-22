using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ClaytonsProperties.Controllers.Data
{
    public interface IZillowRepository
    {
        Task<object> GetPropertyAsync(int propertyId);
    }
}