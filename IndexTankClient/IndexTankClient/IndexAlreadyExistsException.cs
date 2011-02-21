using System;
using IndexTank.API.Client;

namespace IndexTank.API.Client {

	[Serializable]
    public class IndexAlreadyExistsException : Exception {
        public IndexAlreadyExistsException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}