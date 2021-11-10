using System;
using System.IO;
using System.Net;


namespace Lucrasoft.Creatio
{
    internal class CreatioLogin
    {
        private readonly string _appUrl;
        private CookieContainer _authCookie;
        private readonly string _authServiceUrl;
        private readonly string _userName;
        private readonly string _userPassword;


        /// <summary>
        /// 
        /// </summary>
        public string CookieHeader { get
            {
                return _authCookie.GetCookieHeader(new Uri(_appUrl));
            }
        }


        /// <summary>
        /// Add this value to the header with key: BPMCSRF
        /// </summary>
        public string AntiForgeHeader
        {
            get
            {
                var cookie = _authCookie.GetCookies(new Uri(_appUrl))["BPMCSRF"];
                if (cookie != null)
                {
                    return cookie.Value;
                }
                return "";
            }
        }

        public CreatioLogin(string appUrl, string userName, string userPassword)
        {
            _appUrl = appUrl;
            _authServiceUrl = _appUrl + @"/ServiceModel/AuthService.svc/Login";
            _userName = userName;
            _userPassword = userPassword;
        }
        public bool TryLogin()
        {
            var authData = @"{
                    ""UserName"":""" + _userName + @""",
                    ""UserPassword"":""" + _userPassword + @"""
                }";
            var request = CreateRequest(_authServiceUrl, authData);
            _authCookie = new CookieContainer();
            request.CookieContainer = _authCookie;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var responseMessage = reader.ReadToEnd();
                        //Console.WriteLine(responseMessage);
                        if (responseMessage.Contains("\"Code\":1"))
                        {
                            return false;
                            //
                            //throw new UnauthorizedAccessException($"Unauthorized {_userName} for {_appUrl}");
                        }
                    }
                    string authName = ".ASPXAUTH";
                    string authCookeValue = response.Cookies[authName].Value;
                    _authCookie.Add(new Uri(_appUrl), new Cookie(authName, authCookeValue));
                }
            }
            return true;
        }

        private HttpWebRequest CreateRequest(string url, string requestData = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.KeepAlive = true;
            if (!string.IsNullOrEmpty(requestData))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    using (var writer = new StreamWriter(requestStream))
                    {
                        writer.Write(requestData);
                    }
                }
            }
            return request;
        }
    }
}