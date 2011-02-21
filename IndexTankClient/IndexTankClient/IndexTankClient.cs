using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace IndexTank.API.Client {
    
    public class IndexTankClient {

		private const string CLIENT_USER_AGENT = "IndexTank-CSharp/1.0.0";

		// REPLACE THIS SECTION WITH HTTPVerbs
		private const string GET_METHOD = "GET"; 
		private const string PUT_METHOD = "PUT"; 
		private const string DELETE_METHOD = "DELETE";
		// HERE IT IS!
		private static HttpVerbs mVerbs = new HttpVerbs();
    
		private const string SEARCH_URL = "/search";
		private const string DOCS_URL = "/docs";
		private const string CATEGORIES_URL = "/docs/categories";
		private const string VARIABLES_URL = "/docs/variables";
		private const string PROMOTE_URL = "/promote";
		private const string FUNCTIONS_URL = "/functions";

		public Uri EndpointURL { get; set; }
		private string Credentials { get; set; }
    
		//private static const DateTime ISO8601_PARSER = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ssz");

		public IndexTankClient(string pEndpointURL) {
			/*this.EndpointURL = appendTrailingSlash(pEndpointURL);
			try {
				this.Credentials = new URI(pEndpointURL).getUserInfo();
			} catch (MalformedURLException e) {
				throw new IllegalArgumentException(e);
			}*/

			EndpointURL = new Uri(pEndpointURL);
			Console.Write(EndpointURL.UserInfo);
		}
    }
}
