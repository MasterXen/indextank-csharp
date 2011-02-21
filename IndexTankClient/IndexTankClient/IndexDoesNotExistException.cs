using System;
using IndexTank.API.Client;

namespace IndexTank.API.Client {

	[Serializable]
    public class IndexDoesNotExistException : Exception {

        public IndexDoesNotExistException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}