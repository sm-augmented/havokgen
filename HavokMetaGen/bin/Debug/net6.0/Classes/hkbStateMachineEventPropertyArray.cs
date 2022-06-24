using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStateMachineEventPropertyArray: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbEventProperty> m_events { get; set; }
		public const string m_events_Name = "events";
		public const string m_events_Type = "struct";
		public const string m_events_Class = "hkbEventProperty";
		public const string m_events_Array = "True";

	}
}
