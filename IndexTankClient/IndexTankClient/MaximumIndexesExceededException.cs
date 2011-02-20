using System;
using IndexTankClient.API.Client;

namespace IndexTank.API.Client {

    public class MaximumIndexesExceededException : Exception {

        public MaximumIndexesExceededException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}