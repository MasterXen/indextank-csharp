using System;
using IndexTankClient.API.Client;

namespace IndexTank.API.Client {

    public class UnexpectedCodeException : HttpCodeException {

        public UnexpectedCodeException(HttpCodeException pSource) {
            throw pSource;
	    }
    }
}
