using System;
using IndexTankClient.API.Client;

namespace IndexTank.API.Client {

    public class InvalidSyntaxException : Exception {

        public InvalidSyntaxException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}