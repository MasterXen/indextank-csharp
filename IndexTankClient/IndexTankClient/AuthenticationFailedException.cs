using System;
using IndexTankClient.API.Client;

namespace IndexTank.API.Client {

    public class AuthenticationFailedException : Exception {

        public AuthenticationFailedException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}