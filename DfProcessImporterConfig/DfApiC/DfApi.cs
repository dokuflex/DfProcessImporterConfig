using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DfProcessImporterConfig.DfApiC
{
    class DfApi
    {
        private readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly HttpClient client;

        public readonly string apiUrl;

        public string ApiTicket { get; set; }

        public DfApi(string apiUrl)
        {
            client = new HttpClient();
            this.apiUrl = apiUrl;
        }


        public async Task<bool> loginAsync(string apiUser, string apiPassword)
        {

            client.BaseAddress = new Uri(this.apiUrl);

            Logger.InfoFormat("Login into Dokuflex with {0}", apiUser);

            var values = new[] {
                            new KeyValuePair<string,string>("emailAddress",apiUser),
                            new KeyValuePair<string,string>("password",apiPassword)
            };

            var content = new FormUrlEncodedContent(values);

            var result = await client.PostAsync("/services/restExt/login", content);

            var resultStr = await result.Content.ReadAsStringAsync();


            var loginInfo = JsonConvert.DeserializeObject<LoginInfo>(resultStr);

            if (loginInfo.res == "ok")
            {
                Logger.InfoFormat("Dokuflex login success");
                ApiTicket = loginInfo.ticket;
                return true;
            }
            else
            {
                Logger.ErrorFormat("Dokuflex login failed");
            }

            return false;
        }

        public async Task<List<Process>> getProcess()
        {
            Logger.InfoFormat("Getting process");

            List<Process> processList = new List<Process>();


            var values = new[] {
                            new KeyValuePair<string,string>("ticket",ApiTicket),
            };

            var content = new FormUrlEncodedContent(values);

            var result = await client.PostAsync("/services/rest/process/listProcesses", content);

            var resultStr = await result.Content.ReadAsStringAsync();

            if (!String.IsNullOrWhiteSpace(resultStr))
            {
                var processes = JsonConvert.DeserializeObject<Processes>(resultStr);

                if (processes.res == "ok")
                {
                    Logger.InfoFormat("Get process success");
                    processList = processes.elements;
                }
                else
                {
                    Logger.ErrorFormat("Fail Getting process");
                }
            }
            else
            {
                Logger.ErrorFormat("Fail Getting process");
            }
            return processList;
        }

        public async Task<List<UserGroup>> getUserGroups()
        {
            //Logger.InfoFormat("Getting communitys");

            List<UserGroup> userGroupList = new List<UserGroup>();


            var values = new[] {
                            new KeyValuePair<string,string>("ticket",ApiTicket),
            };

            var content = new FormUrlEncodedContent(values);

            var result = await client.PostAsync("/services/rest/getUserGroups", content);

            var resultStr = await result.Content.ReadAsStringAsync();

            if (!String.IsNullOrWhiteSpace(resultStr))
            {
                var userGroups = JsonConvert.DeserializeObject<UserGroups>(resultStr);

                if (userGroups.res == "ok")
                {
                    Logger.InfoFormat("Get communitys success");
                    userGroupList = userGroups.groups;
                }
                else
                {
                    Logger.ErrorFormat("Fail Getting communitys");
                }
            }
            else
            {
                Logger.ErrorFormat("Fail Getting communitys");
            }
            return userGroupList;
        }

    }
}
