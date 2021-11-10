using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terrasoft.Configuration.OData;

namespace Lucrasoft.Creatio
{
    public class CreatioClient
    {

        private readonly string baseUrl;
        private bool isLoggedInSuccess = false;
        private CreatioLogin loginBasic;
        private DefaultContainer container;

        private Uri serviceRoot
        {
            get
            {
                return new Uri($"{baseUrl}/0/odata");
            }
        }

        public CreatioClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public bool LoginUserPass(string username, string password)
        {
            loginBasic = new CreatioLogin(this.baseUrl, username, password);
            isLoggedInSuccess = loginBasic.TryLogin();

            container = new DefaultContainer(serviceRoot);
            container.BuildingRequest += (sender, eventargs) =>
            {
                eventargs.Headers.Add("Cookie", loginBasic.CookieHeader);
                eventargs.Headers.Add("BPMCSRF", loginBasic.AntiForgeHeader);
            };


            return isLoggedInSuccess;
        }

        public DefaultContainer GetContainer
        {
            get
            {
                if (!isLoggedInSuccess) return null;
                return container;
            }
        }

       
    }
}
