using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stusign.Libraries
{
    public class reCAPTCHA
    {
        private readonly string _serverUrl;
        private readonly string _serverKey;

        public reCAPTCHA(SystemOptions systemOptions)
        {
            _serverUrl = "recaptcha.net";
            _serverKey = systemOptions.验证码key;
        }

        public reCaptchaResult Validate(string token,string ip = null)
        {
            return Task.Run(() =>
            {
                var client = new WebClient();
                var values = new NameValueCollection();

                values["secret"] = _serverKey;
                values["response"] = token;
                if (ip != null)
                    values["remoteip"] = ip;

                try
                {
                    var response = client.UploadValues("https://" + _serverUrl + "/recaptcha/api/siteverify ", values);
                    var res = JsonConvert.DeserializeObject<reCaptchaResult>(Encoding.Default.GetString(response));
                    return res;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return new reCaptchaResult
                    {
                        success = false
                    };
                }


            }).Result;
        }

        public class reCaptchaResult
        {
            public bool success;
            public string challenge_ts;
        }
    }

    public class reCaptchaValid:IActionFilter 
    {
        private readonly reCAPTCHA _reCaptcha;
        private readonly SystemOptions _systemOptions;

        public reCaptchaValid(reCAPTCHA reCaptcha,SystemOptions systemOptions)
        {
            _reCaptcha = reCaptcha;
            _systemOptions = systemOptions;
        }
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {         
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            
            var r = context.HttpContext.Request.Form.TryGetValue("reCaptchaToken", out StringValues reCaptchaToken);
            //两种情况直接跳转
            //关闭验证码 或 验证通过
            if(_systemOptions.使用验证码)
                if (!_reCaptcha.Validate(reCaptchaToken).success)
                {
                    //context.HttpContext.Response.Redirect("/Home/Reg?);
                    context.Result =new RedirectToActionResult("Index","Account",new
                    {
                        error = "验证码验证失败，请重试！"
                    });
                }

        }
    }
    
}
