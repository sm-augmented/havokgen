using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbClipTrigger
	{
		public const string version = "1";
		public float m_localTime { get; set; }
		public const string m_localTime_Name = "localTime";
		public const string m_localTime_Type = "real";
		public hkbEventProperty m_event { get; set; }
		public const string m_event_Name = "event";
		public const string m_event_Type = "struct";
		public const string m_event_Class = "hkbEventProperty";
		public byte m_relativeToEndOfClip { get; set; }
		public const string m_relativeToEndOfClip_Name = "relativeToEndOfClip";
		public const string m_relativeToEndOfClip_Type = "byte";
		public byte m_acyclic { get; set; }
		public const string m_acyclic_Name = "acyclic";
		public const string m_acyclic_Type = "byte";
		public byte m_isAnnotation { get; set; }
		public const string m_isAnnotation_Name = "isAnnotation";
		public const string m_isAnnotation_Type = "byte";

	}
}
