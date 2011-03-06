using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Http;
using System.Runtime.Serialization.Json;
using IndexTankClient;

namespace IndexTank.API.Client {
    
    public class IndexTankClient {
		public Uri EndpointURL { get; set; }
		private string Credentials { get; set; }
		private HttpClient mClient = new HttpClient();
    
		//private static const DateTime ISO8601_PARSER = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ssz");

		public IndexTankClient(Uri pEndpointURL) {
			EndpointURL = pEndpointURL;
			mClient.Stages.Add(new AuthenticationInterceptor());
		}

		public Index GetIndex(string pIndexName) {
			HttpResponseMessage oResponse = mClient.Get(new Uri(EndpointURL, Constants.URI_INDEX_METADATA_NAME + pIndexName));
			oResponse.EnsureStatusIsSuccessful();
			var oSerializer = new DataContractJsonSerializer(typeof(Index));
			return oResponse.Content.ReadAsJsonDataContract<Index>(oSerializer);
		}
    }
}
