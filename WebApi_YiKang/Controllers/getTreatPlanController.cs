// 2022-12-16, Bruce

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
    /// 获取计划治疗方案（getTreatPlan - 数据下行）
    /// </summary>
    [RoutePrefix("devices/getTreatPlan")]
    public class getTreatPlanController : ApiController
    {
        static int index = 0;

        [HttpGet]
        public HttpResponseMessage Get(string deviceId, string sysCode)
        {
            string res = "";
            switch (index)
            {
                case 0:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":{\"recordId\":\"771aa7b86aba4d24871a074b3a8b499d\",\"patientName\":\"张三\",\"patientId\":\"0D3F61E4D60E4BF196DD\",\"sex\":\"男\",\"age\":\"51\",\"deviceId\":\"20220720SL4V3S001\",\"dev_param\":{\"TreatType\":1,\"TrainMode\":0,\"VelocityCur\":20,\"VelocityReduction\":1,\"Duration\":30,\"RestDuration\":10,\"AngleFromLeft\":2,\"AngleToLeft\":20,\"AngleFromRight\":2,\"AngleToRight\":20,\"ScrampSensitivityLeft\":40,\"ScrampSensitivityRight\":40}},\"total\":0}";
                    break;
                case 1:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":{\"recordId\":\"771aa7b86aba4d24871a074b3a8b499d\",\"patientName\":\"张三\",\"patientId\":\"0D3F61E4D60E4BF196DD\",\"sex\":\"男\",\"age\":\"51\",\"deviceId\":\"20220720SL4V3S001\",\"dev_param\":{}},\"total\":0}";
                    break;
                case 2:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":{\"recordId\":\"771aa7b86aba4d24871a074b3a8b499d\",\"patientName\":\"张三\",\"patientId\":\"0D3F61E4D60E4BF196DD\",\"sex\":\"男\",\"age\":\"51\",\"deviceId\":\"20220720SL4V3S001\",\"dev_param\":null},\"total\":0}";
                    break;
                case 3:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":{},\"total\":0}";
                    break;
                case 4:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":{},\"total\":0}";
                    break;
                case 5:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":null,\"total\":0}";
                    break;
                case 6:
                    res = "{\"code\":1,\"msg\":\"成功\",\"obj\":\"1\",\"total\":0}";
                    break;
            }
            index++;
            if (index > 6)
                index = 0;
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(res, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }

    }
}