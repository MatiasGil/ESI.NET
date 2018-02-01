﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ESI.NET
{
    public static class ApiRequest
    {
        public async static Task<ApiResponse<T>> Execute<T>(ESIConfig config, RequestSecurity security, RequestMethod method, string endpoint, string[] parameters = null, object body = null)
        {
            HttpClient client = new HttpClient();

            string version = "latest";// EndpointVersions[endpoint];

            //Enforce user agent value
            var url = $"{config.BaseUrl}{version}{endpoint}?datasource={config.DataSource}";
            if (config.UserAgent == string.Empty || config.UserAgent == null)
                throw new Exception("For your protection, please provide a user_agent value. This can be your character name and/or project name. CCP will be more likely to contact you than just cut off access to ESI if you provide something that can identify you within the New Eden galaxy.");
            else
                client.DefaultRequestHeaders.Add("X-User-Agent", config.UserAgent);

            //Attach token to request header if this endpoint requires an authorized character
            if (security == RequestSecurity.Authenticated)
            {
                if (config.Token == null)
                    throw new Exception("The request endpoint requires SSO authentication and token data has not been provided.");
                else
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {config.Token}");
            }

            //Attach query string parameters
            var queryString = string.Empty;
            if (parameters != null)
            {
                queryString = string.Join("&", parameters);
                url += $"&{queryString}";
            }

            //Serialize post body data
            HttpContent postBody = null;
            if (body != null)
                postBody = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            //Get response from client based on request type
            //This is also where body variables will be created and attached as necessary
            HttpResponseMessage response = null;
            switch (method)
            {
                case RequestMethod.DELETE:
                    response = await client.DeleteAsync(url).ConfigureAwait(false);
                    break;

                case RequestMethod.GET:
                    response = await client.GetAsync(url).ConfigureAwait(false);
                    break;

                case RequestMethod.POST:
                    response = await client.PostAsync(url, postBody).ConfigureAwait(false);
                    break;

                case RequestMethod.PUT:
                    response = await client.PutAsync(url, postBody).ConfigureAwait(false);
                    break;
            }
            
            //Output final object
            var obj = new ApiResponse<T>(response, method, endpoint);
            return obj;
        }

        public enum RequestSecurity
        {
            Public,
            Authenticated
        }

        public enum RequestMethod
        {
            CONNECT,
            DELETE,
            GET,
            HEAD,
            POST,
            PUT,
            TRACE
        }
    }
}