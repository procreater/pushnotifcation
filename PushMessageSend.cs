using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CordovaSPA.Dal
{
    public class PushMessageSend
    {
        private Db db = new Db();
        public void SendMessage(Array deviceID, string Message, string Title)
        {
            var registryIds = db.Devices.Select(x => x.RegistryId).ToArray();
            
            for (int i = 0; i < registryIds.Length; i++)
            {
                string postData =
               "{ \"registration_ids\": [ \"" + registryIds[i] + "\" ], " +
               "\"data\": {\"title\":\"" + Title + "\", " +
               "\"message\":\"" + Message + "\", " +
              //"\"style\": \"inbox\"," +
              "\"soundname\":\"default\"," +
               "}}";

                string response = PushMessage.SendGCMNotification("tokenın", postData);
            }
        }
    }
}
