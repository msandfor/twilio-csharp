/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// CreateValidationRequestOptions
    /// </summary>
    public class CreateValidationRequestOptions : IOptions<ValidationRequestResource> 
    {
        /// <summary>
        /// The SID of the Account responsible for the new Caller ID
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The phone number to verify in E.164 format
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The number of seconds to delay before initiating the verification call
        /// </summary>
        public int? CallDelay { get; set; }
        /// <summary>
        /// The digits to dial after connecting the verification call
        /// </summary>
        public string Extension { get; set; }
        /// <summary>
        /// The URL we should call to send status information to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The HTTP method we should use to call status_callback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        /// <summary>
        /// Construct a new CreateValidationRequestOptions
        /// </summary>
        /// <param name="phoneNumber"> The phone number to verify in E.164 format </param>
        public CreateValidationRequestOptions(Types.PhoneNumber phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (CallDelay != null)
            {
                p.Add(new KeyValuePair<string, string>("CallDelay", CallDelay.ToString()));
            }

            if (Extension != null)
            {
                p.Add(new KeyValuePair<string, string>("Extension", Extension));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            return p;
        }
    }

}