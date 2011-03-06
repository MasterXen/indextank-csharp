using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexTank.Example {
	class Program {
		static void Main(string[] args) {
			var oPrivateUri = new Uri("http://:2c21UZAeiakR5I@8ye9v.api.indextank.com");
			var oClient = new IndexTank.API.Client.IndexTankClient(oPrivateUri);
			var oTestIndex = oClient.GetIndex("test_index");
			Console.WriteLine(oTestIndex.CreationTime);
			Console.ReadLine();
		}
	}
}
