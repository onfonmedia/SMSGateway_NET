/*
 * OnfonMediaSMSGateway.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using OnfonMediaSMSGateway.Standard;
using OnfonMediaSMSGateway.Standard.Utilities;
using OnfonMediaSMSGateway.Standard.Http.Request;
using OnfonMediaSMSGateway.Standard.Http.Response;
using OnfonMediaSMSGateway.Standard.Http.Client;
using OnfonMediaSMSGateway.Standard.Exceptions;

namespace OnfonMediaSMSGateway.Standard.Controllers
{
    public partial class CampaignController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CampaignController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CampaignController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CampaignController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get Campaign Message Status
        /// </summary>
        /// <param name="campaignId">Required parameter: First user have to call Get Campaigns api for CampaignId</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetCampaignMessageStatus(int campaignId)
        {
            Task<dynamic> t = GetCampaignMessageStatusAsync(campaignId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Campaign Message Status
        /// </summary>
        /// <param name="campaignId">Required parameter: First user have to call Get Campaigns api for CampaignId</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetCampaignMessageStatusAsync(int campaignId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Campaign/Statistics");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "campaignId", campaignId },
                { "ApiKey", Configuration.ApiKey },
                { "ClientId", Configuration.ClientId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("AccessKey", Configuration.AccessKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get Campaigns
        /// </summary>
        /// <param name="enddate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="fromdate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="length">Required parameter: Ending index value to fetch the campaign detail.</param>
        /// <param name="start">Required parameter: Starting index value to fetch the campaign detail.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetCampaigns(
                DateTime enddate,
                DateTime fromdate,
                int length,
                int start)
        {
            Task<dynamic> t = GetCampaignsAsync(enddate, fromdate, length, start);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Campaigns
        /// </summary>
        /// <param name="enddate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="fromdate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="length">Required parameter: Ending index value to fetch the campaign detail.</param>
        /// <param name="start">Required parameter: Starting index value to fetch the campaign detail.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetCampaignsAsync(
                DateTime enddate,
                DateTime fromdate,
                int length,
                int start)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Campaign");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "enddate", enddate.ToString("yyyy'-'MM'-'dd") },
                { "fromdate", fromdate.ToString("yyyy'-'MM'-'dd") },
                { "length", length },
                { "start", start },
                { "ApiKey", Configuration.ApiKey },
                { "ClientId", Configuration.ClientId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("AccessKey", Configuration.AccessKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 