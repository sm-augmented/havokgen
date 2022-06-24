using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertyControlsModifier: hkbModifier
	{
		public const string version = "1";
		public hkbEntityPropertyControlData m_controlData { get; set; }
		public const string m_controlData_Name = "controlData";
		public const string m_controlData_Type = "ref";
		public int m_controlData_refId { get; set; }
		public const string m_controlData_Class = "hkbEntityPropertyControlData";

	}
}
