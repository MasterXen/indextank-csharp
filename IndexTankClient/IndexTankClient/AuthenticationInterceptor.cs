using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Http;
using Microsoft.Http.Headers;

namespace IndexTankClient {
	class AuthenticationInterceptor : HttpProcessingStage {

		public override void ProcessRequest(HttpRequestMessage pRequest) {
			pRequest.Headers.UserAgent.Add(ProductOrComment.Parse(Constants.CLIENT_USER_AGENT));

			// Extract private password and remove from the supplied URI
			var oUserInfo = pRequest.Uri.UserInfo;
			//var oEncodedPassword = ASCIIEncoding.ASCII.GetBytes(oUserInfo
			pRequest.Headers.Authorization = Credential.CreateBasic(String.Empty, pRequest.Uri.UserInfo.Split(':')[1]);

			var oCleanedUri = pRequest.Uri.ToString().Replace(oUserInfo, String.Empty).Replace("@", String.Empty);
			pRequest.Uri = new Uri(oCleanedUri);
		}

		public override void ProcessResponse(HttpResponseMessage pResponse) {
			// DO NOTHING
		}
	}
}
