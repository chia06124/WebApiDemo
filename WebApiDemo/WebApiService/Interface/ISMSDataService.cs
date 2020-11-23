using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiService.Interface
{
    interface ISMSDataService
    {
        void Create(JObject data);
    }
}
