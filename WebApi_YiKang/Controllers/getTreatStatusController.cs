// 2023-07-02, Bruce

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace WebApi_YiKang.Controllers
{
    /// <summary>
    /// 获取计划治疗方案（getTreatStatus - 数据下行）
    /// </summary>
    [RoutePrefix("devices/getTreatStatus")]
    public class getTreatStatusController : ApiController
    {
        static int index = 0;

        [HttpGet]
        public HttpResponseMessage Get(string deviceId, string recordId)
        {
            string res = "";
            switch (index)
            {
                case 0:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":null,\"total\":0}";
                    break;
                case 1:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":0,\"total\":0}";
                    break;
                case 2:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":1,\"total\":0}";
                    break;
                case 3:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":2,\"total\":0}";
                    break;
                case 4:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":3,\"total\":0}";
                    break;
            }
            index++;
            if (index > 4)
                index = 0;
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(res, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }

    }
}