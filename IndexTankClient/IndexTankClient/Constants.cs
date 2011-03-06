using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexTankClient {
	class Constants {
		public const string URI_SEARCH_URL = "/search";
		public const string URI_DOCS_URL = "/docs";
		public const string URI_CATEGORIES_URL = "/docs/categories";
		public const string URI_VARIABLES_URL = "/docs/variables";
		public const string URI_PROMOTE_URL = "/promote";
		public const string URI_FUNCTIONS_URL = "/functions";
		public const string URI_INDEX_METADATA_NAME = "/v1/indexes/";

		public static string CLIENT_USER_AGENT = "IndexTank-CSharp/1.0.0";
	}
}
