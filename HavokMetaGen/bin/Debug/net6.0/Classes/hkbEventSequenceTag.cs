using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEventSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbEventProperty m_event { get; set; }
		public const string m_event_Name = "event";
		public const string m_event_Type = "struct";
		public const string m_event_Class = "hkbEventProperty";

	}
}
