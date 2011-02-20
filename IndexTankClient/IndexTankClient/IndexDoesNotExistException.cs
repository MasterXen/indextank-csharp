using System;
using IndexTankClient.API.Client;

namespace IndexTank.API.Client {

    public class IndexDoesNotExistException : Exception {

        public IndexDoesNotExistException(HttpCodeException pSource) : base(pSource.Message) {
            // Marker class
        }
    }
}