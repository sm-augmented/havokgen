using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertySequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbEntityPropertyControlData m_property { get; set; }
		public const string m_property_Name = "property";
		public const string m_property_Type = "ref";
		public int m_property_refId { get; set; }
		public const string m_property_Class = "hkbEntityPropertyControlData";

	}
}
