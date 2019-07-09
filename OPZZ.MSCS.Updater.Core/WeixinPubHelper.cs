using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class WeixinPubHelper
    {
        public static WeixinResult PublishText(WeixinTexMsg text, string url)
        {
            var client = new RestClient("https://qyapi.weixin.qq.com/cgi-bin/");
            var request = new RestRequest(url, Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(text);

            var response = client.Execute<WeixinResult>(request);
            var result = response.Data;
            return result;
        }
    }

    public class WeixinTexMsg
    {
        public WeixinTexMsg()
        {
            msgtype = "text";
            text = new Content();
        }

        public string msgtype { get; set; }

        public Content text { get; set; }

        public class Content
        {
            public Content()
            {
                mentioned_list = new List<string>();
            }

            public string content { get; set; }
            public List<string> mentioned_list { get; set; }
        }
    }

    public class WeixinResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
