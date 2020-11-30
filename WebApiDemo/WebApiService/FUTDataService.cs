using Newtonsoft.Json.Linq;
using SQLModel.Models;
using SQLModel.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiService
{
    public class FUTDataService
    {
        private SqlConnection conn;
        FUTDataRepository<OO_FUTData> FUTDataRepository;
        public FUTDataService(SqlConnection conn)
        {
            this.conn = conn;
            FUTDataRepository = new FUTDataRepository<OO_FUTData>(conn);
        }

        public void Create(JObject data)
        {
            OO_FUTData OOFUTData = data.ToObject<OO_FUTData>();
            OOFUTData.CreateUser = "Lily";
            OOFUTData.CreateDate = Convert.ToDateTime(DateTime.Now);
            FUTDataRepository.Create(OOFUTData);
        }

        public void Update(JObject data)
        {
            OO_FUTData OOFUTData = data.ToObject<OO_FUTData>();
            OOFUTData.CreateUser = "Lily";
            OOFUTData.CreateDate = Convert.ToDateTime(DateTime.Now);
            FUTDataRepository.Update(OOFUTData);
        }

        public void Delete(JObject data)
        {
          
            FUTDataRepository.Delete(data);
        }
    }
}
