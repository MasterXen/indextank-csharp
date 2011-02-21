using System;
using IndexTank.API.Client;

namespace IndexTank.API.Client {

	[Serializable]
    public class AuthenticationFailedException : Exception {

        public AuthenticationFailedException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}