using Newtonsoft.Json.Linq;
using SQLModel.Models;
using SQLModel.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiService.Interface;

namespace WebApiService
{
    public class SMSDataService
    {
        private SqlConnection conn;
        SMSDataRepository<OO_SMSData> SMSDataRepository;
        public SMSDataService(SqlConnection conn)
        {
            this.conn = conn;
            SMSDataRepository = new SMSDataRepository<OO_SMSData>(conn);
        }

        public void Create(JObject data)
        {
            OO_SMSData OOSMSData = data.ToObject<OO_SMSData>();
            OOSMSData.CreateUser = "Lily";
            OOSMSData.CreateDate = Convert.ToDateTime(DateTime.Now);
            SMSDataRepository.Create(OOSMSData);
        }

        public string Get(JObject data)
        {
            return SMSDataRepository.Get(data);
        }

    }

        
    
}
