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
    public partial class SMSController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SMSController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SMSController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SMSController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get Sent Message List
        /// </summary>
        /// <param name="enddate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="fromdate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="length">Required parameter: Ending index value to fetch the campaign detail.</param>
        /// <param name="start">Required parameter: Starting index value to fetch the campaign detail.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetSentMessageList(
                DateTime enddate,
                DateTime fromdate,
                int length,
                int start)
        {
            Task<dynamic> t = GetSentMessageListAsync(enddate, fromdate, length, start);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Sent Message List
        /// </summary>
        /// <param name="enddate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="fromdate">Required parameter: Date format must be in yyyy-mm-dd</param>
        /// <param name="length">Required parameter: Ending index value to fetch the campaign detail.</param>
        /// <param name="start">Required parameter: Starting index value to fetch the campaign detail.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetSentMessageListAsync(
                DateTime enddate,
                DateTime fromdate,
                int length,
                int start)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/SMS");

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

        /// <summary>
        /// Get Sent Message Status
        /// </summary>
        /// <param name="messageId">Required parameter: MessageId of message</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetSentMessageStatus(int messageId)
        {
            Task<dynamic> t = GetSentMessageStatusAsync(messageId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Sent Message Status
        /// </summary>
        /// <param name="messageId">Required parameter: MessageId of message</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetSentMessageStatusAsync(int messageId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/MessageStatus");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "MessageId", messageId },
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
        /// Create SMS
        /// </summary>
        /// <param name="message">Required parameter: text message to send</param>
        /// <param name="mobileNumber">Required parameter: Use mobile number as comma sepreated to send message on multiple mobile number e.g. 78461230,78945612</param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="coRelator">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="linkId">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="groupId">Optional parameter: Valid group-id of current user (only for group message otherwise leave empty string)</param>
        /// <param name="scheduleTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <param name="serviceId">Optional parameter: Parameter required for using SDP OnSubscription Service</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetCreateSMS(
                string message,
                string mobileNumber,
                string senderId,
                string coRelator = null,
                bool? isFlash = null,
                bool? isUnicode = null,
                string linkId = null,
                string groupId = null,
                string scheduleTime = null,
                string serviceId = null)
        {
            Task<dynamic> t = GetCreateSMSAsync(message, mobileNumber, senderId, coRelator, isFlash, isUnicode, linkId, groupId, scheduleTime, serviceId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create SMS
        /// </summary>
        /// <param name="message">Required parameter: text message to send</param>
        /// <param name="mobileNumber">Required parameter: Use mobile number as comma sepreated to send message on multiple mobile number e.g. 78461230,78945612</param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="coRelator">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="linkId">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="groupId">Optional parameter: Valid group-id of current user (only for group message otherwise leave empty string)</param>
        /// <param name="scheduleTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <param name="serviceId">Optional parameter: Parameter required for using SDP OnSubscription Service</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetCreateSMSAsync(
                string message,
                string mobileNumber,
                string senderId,
                string coRelator = null,
                bool? isFlash = null,
                bool? isUnicode = null,
                string linkId = null,
                string groupId = null,
                string scheduleTime = null,
                string serviceId = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/SendSMS");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Message", message },
                { "MobileNumber", mobileNumber },
                { "SenderId", senderId },
                { "CoRelator", coRelator },
                { "Is_Flash", isFlash },
                { "Is_Unicode", isUnicode },
                { "LinkId", linkId },
                { "groupId", groupId },
                { "scheduleTime", scheduleTime },
                { "serviceId", serviceId },
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
        /// Create SMS
        /// </summary>
        /// <param name="message">Required parameter: text message to send</param>
        /// <param name="mobileNumber">Required parameter: Use mobile number as comma sepreated to send message on multiple mobile number e.g. 78461230,78945612</param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="coRelator">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="linkId">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="groupId">Optional parameter: Valid group-id of current user (only for group message otherwise leave empty string)</param>
        /// <param name="scheduleTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <param name="serviceId">Optional parameter: Parameter required for using SDP OnSubscription Service</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic CreateSMS(
                string message,
                string mobileNumber,
                string senderId,
                string coRelator = null,
                bool? isFlash = null,
                bool? isUnicode = null,
                string linkId = null,
                string groupId = null,
                string scheduleTime = null,
                string serviceId = null)
        {
            Task<dynamic> t = CreateSMSAsync(message, mobileNumber, senderId, coRelator, isFlash, isUnicode, linkId, groupId, scheduleTime, serviceId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create SMS
        /// </summary>
        /// <param name="message">Required parameter: text message to send</param>
        /// <param name="mobileNumber">Required parameter: Use mobile number as comma sepreated to send message on multiple mobile number e.g. 78461230,78945612</param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="coRelator">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="linkId">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="groupId">Optional parameter: Valid group-id of current user (only for group message otherwise leave empty string)</param>
        /// <param name="scheduleTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <param name="serviceId">Optional parameter: Parameter required for using SDP OnSubscription Service</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateSMSAsync(
                string message,
                string mobileNumber,
                string senderId,
                string coRelator = null,
                bool? isFlash = null,
                bool? isUnicode = null,
                string linkId = null,
                string groupId = null,
                string scheduleTime = null,
                string serviceId = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/SendSMS");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Message", message },
                { "MobileNumber", mobileNumber },
                { "SenderId", senderId },
                { "CoRelator", coRelator },
                { "Is_Flash", isFlash },
                { "Is_Unicode", isUnicode },
                { "LinkId", linkId },
                { "groupId", groupId },
                { "scheduleTime", scheduleTime },
                { "serviceId", serviceId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
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
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null);

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
        /// Create Bulk SMS
        /// </summary>
        /// <param name="mobileNumberMessage">Required parameter: Please ensure while submitting the request the message should be passed in encoded format. e.g. 78461230^test~78945612^hello</param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="coRelator">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="linkId">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="scheduleTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <param name="serviceId">Optional parameter: Parameter required for using SDP OnSubscription Service</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetCreateBulkSMS(
                string mobileNumberMessage,
                string senderId,
                string coRelator = null,
                bool? isFlash = null,
                bool? isUnicode = null,
                string linkId = null,
                DateTime? scheduleTime = null,
                string serviceId = null)
        {
            Task<dynamic> t = GetCreateBulkSMSAsync(mobileNumberMessage, senderId, coRelator, isFlash, isUnicode, linkId, scheduleTime, serviceId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create Bulk SMS
        /// </summary>
        /// <param name="mobileNumberMessage">Required parameter: Please ensure while submitting the request the message should be passed in encoded format. e.g. 78461230^test~78945612^hello</param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="coRelator">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="linkId">Optional parameter: Parameter required for using SDP OnDemand Service</param>
        /// <param name="scheduleTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <param name="serviceId">Optional parameter: Parameter required for using SDP OnSubscription Service</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetCreateBulkSMSAsync(
                string mobileNumberMessage,
                string senderId,
                string coRelator = null,
                bool? isFlash = null,
                bool? isUnicode = null,
                string linkId = null,
                DateTime? scheduleTime = null,
                string serviceId = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/SendBulkSMS");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "MobileNumber_Message", mobileNumberMessage },
                { "SenderId", senderId },
                { "CoRelator", coRelator },
                { "Is_Flash", isFlash },
                { "Is_Unicode", isUnicode },
                { "LinkId", linkId },
                { "scheduleTime", (scheduleTime.HasValue) ? scheduleTime.Value.ToString("yyyy'-'MM'-'dd") : null },
                { "serviceId", serviceId },
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
        /// Create Bulk SMS
        /// </summary>
        /// <param name="messageParameters">Required parameter: Example: </param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="scheduleDateTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic CreateBulkSMS(
                List<string> messageParameters,
                string senderId,
                bool? isFlash = null,
                bool? isUnicode = null,
                DateTime? scheduleDateTime = null)
        {
            Task<dynamic> t = CreateBulkSMSAsync(messageParameters, senderId, isFlash, isUnicode, scheduleDateTime);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create Bulk SMS
        /// </summary>
        /// <param name="messageParameters">Required parameter: Example: </param>
        /// <param name="senderId">Required parameter: Approved Sender Id</param>
        /// <param name="isFlash">Optional parameter: Is_Flash is true or false for flash message</param>
        /// <param name="isUnicode">Optional parameter: Is_Unicode is true or false for unicode message</param>
        /// <param name="scheduleDateTime">Optional parameter: scheduleTime Date in yyyy-MM-dd HH:MM (only for schedule message)</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateBulkSMSAsync(
                List<string> messageParameters,
                string senderId,
                bool? isFlash = null,
                bool? isUnicode = null,
                DateTime? scheduleDateTime = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/SendBulkSMS");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "MessageParameters", messageParameters },
                { "ScheduleDateTime", (scheduleDateTime.HasValue) ? scheduleDateTime.Value.ToString("yyyy'-'MM'-'dd") : null }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "SenderId", senderId },
                { "Is_Flash", isFlash },
                { "Is_Unicode", isUnicode },
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
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null);

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