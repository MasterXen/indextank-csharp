using System;
using IndexTank.API.Client;

namespace IndexTank.API.Client {

	[Serializable]
    public class MaximumIndexesExceededException : Exception {

        public MaximumIndexesExceededException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}