using System;
using IndexTankClient.API.Client;

namespace IndexTank.API.Client {

    public class IndexAlreadyExistsException : Exception {
        public IndexAlreadyExistsException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}