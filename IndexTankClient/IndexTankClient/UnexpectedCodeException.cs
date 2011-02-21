using System;
using IndexTank.API.Client;

namespace IndexTank.API.Client {

	[Serializable]
    public class UnexpectedCodeException : HttpCodeException {

        public UnexpectedCodeException(HttpCodeException pSource) {
            throw pSource;
	    }
    }
}
