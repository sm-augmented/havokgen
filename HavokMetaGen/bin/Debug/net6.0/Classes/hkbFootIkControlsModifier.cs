using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbFootIkControlsModifier: hkbModifier
	{
		public const string version = "1";
		public hkbFootIkControlData m_controlData { get; set; }
		public const string m_controlData_Name = "controlData";
		public const string m_controlData_Type = "struct";
		public const string m_controlData_Class = "hkbFootIkControlData";
		public List<hkbFootIkControlsModifierLeg> m_legs { get; set; }
		public const string m_legs_Name = "legs";
		public const string m_legs_Type = "struct";
		public const string m_legs_Class = "hkbFootIkControlsModifierLeg";
		public const string m_legs_Array = "True";

	}
}
