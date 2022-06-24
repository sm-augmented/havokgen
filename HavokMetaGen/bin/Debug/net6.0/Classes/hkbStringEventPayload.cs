using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStringEventPayload: hkbEventPayload
	{
		public const string version = "0";
		public string m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "string";

	}
}
