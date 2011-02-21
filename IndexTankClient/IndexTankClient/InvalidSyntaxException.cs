using System;
using IndexTank.API.Client;

namespace IndexTank.API.Client {

	[Serializable]
    public class InvalidSyntaxException : Exception {

        public InvalidSyntaxException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}