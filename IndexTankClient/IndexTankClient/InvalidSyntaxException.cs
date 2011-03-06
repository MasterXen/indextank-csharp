using System;
using IndexTank.API.Client;
using Microsoft.ServiceModel.Web;
using System.Net;

namespace IndexTank.API.Client {

	[Serializable]
	public class InvalidSyntaxException : WebProtocolException {

        public InvalidSyntaxException(HttpStatusCode pCode) : base(pCode) {
            // Marker class
        }
    }
}