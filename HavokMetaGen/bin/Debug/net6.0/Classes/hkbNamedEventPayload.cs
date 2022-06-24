using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbNamedEventPayload: hkbEventPayload
	{
		public const string version = "0";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";

	}
}
