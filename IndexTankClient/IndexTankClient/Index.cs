using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace IndexTankClient {
	[DataContract]
	public class Index {

		[DataMember(Name="started")]
		public bool IsStarted { get; set; }

		[DataMember(Name = "code")]
		public string Code { get; set; }

		[DataMember(Name = "creation_time")]
		internal string CreationTime_Internal { get; set; }

		public DateTime CreationTime {
			get {
				return DateTime.Parse(CreationTime_Internal);
			}
		}

		[DataMember(Name = "size")]
		public int Size { get; set; }
	}
}
