#region License
//   Copyright 2010 John Sheehan
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using System;

namespace Twilio
{
	/// <summary>
	/// An Application instance resource represents a single Twilio Application.
	/// </summary>
	public class Application : TwilioBase
	{
		/// <summary>
		/// A 34 character string that uniquely identifies this account.
		/// </summary>
		public string Sid { get; set; }
		/// <summary>
		/// The date that this account was created, given as GMT
		/// </summary>
		public DateTime DateCreated { get; set; }
		/// <summary>
		/// The date that this account was last updated, given in as GMT
		/// </summary>
		public DateTime DateUpdated { get; set; }
		/// <summary>
		/// A human readable description of this account, up to 64 characters long. By default the FriendlyName is your email address.
		/// </summary>
		public string FriendlyName { get; set; }
		/// <summary>
		/// The unique id of the Account responsible for this phone number.
		/// </summary>
		public string AccountSid { get; set; }
		/// <summary>
		/// Calls to this phone number will start a new TwiML session with this API version.
		/// </summary>
		public string ApiVersion { get; set; }
		/// <summary>
		/// Look up the caller's caller-ID name from the CNAM database (additional charges apply)
		/// </summary>
		public bool VoiceCallerIdLookup { get; set; }
		/// <summary>
		/// The URL Twilio will request when this phone number receives a call.
		/// </summary>
		public string VoiceUrl { get; set; }
		/// <summary>
		/// The HTTP method Twilio will use when requesting the above Url. Either GET or POST.
		/// </summary>
		public string VoiceMethod { get; set; }
		/// <summary>
		/// The URL that Twilio will request if an error occurs retrieving or executing the TwiML requested by Url.
		/// </summary>
		public string VoiceFallbackUrl { get; set; }
		/// <summary>
		/// The HTTP method Twilio will use when requesting the VoiceFallbackUrl. Either GET or POST.
		/// </summary>
		public string VoiceFallbackMethod { get; set; }
		/// <summary>
		/// The URL that Twilio will request to pass status parameters (such as call ended) to your application.
		/// </summary>
		public string StatusCallback { get; set; }
		/// <summary>
		/// The HTTP method Twilio will use to make requests to the StatusCallbackUrl. Either GET or POST.
		/// </summary>
		public string StatusCallbackMethod { get; set; }
		/// <summary>
		/// The URL Twilio will request when receiving an incoming SMS message to this number.
		/// </summary>
		public string SmsUrl { get; set; }
		/// <summary>
		/// The HTTP method Twilio will use when making requests to the SmsUrl. Either GET or POST.
		/// </summary>
		public string SmsMethod { get; set; }
		/// <summary>
		/// The URL that Twilio will request if an error occurs retrieving or executing the TwiML from SmsUrl.
		/// </summary>
		public string SmsFallbackUrl { get; set; }
		/// <summary>
		/// The HTTP method Twilio will use when requesting the above URL. Either GET or POST.
		/// </summary>
		public string SmsFallbackMethod { get; set; }
	}
}