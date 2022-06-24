using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEventBase
	{
		public const string version = "0";
		public int m_id { get; set; }
		public const string m_id_Name = "id";
		public const string m_id_Type = "int";
		public hkbEventPayload m_payload { get; set; }
		public const string m_payload_Name = "payload";
		public const string m_payload_Type = "ref";
		public int m_payload_refId { get; set; }
		public const string m_payload_Class = "hkbEventPayload";

	}
}
