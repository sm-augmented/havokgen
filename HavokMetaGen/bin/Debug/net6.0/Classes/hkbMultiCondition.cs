using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbMultiCondition: hkbCondition
	{
		public const string version = "0";
		public byte m_trueIfAny { get; set; }
		public const string m_trueIfAny_Name = "trueIfAny";
		public const string m_trueIfAny_Type = "byte";
		public List<hkbCondition> m_conditions { get; set; }
		public const string m_conditions_Name = "conditions";
		public const string m_conditions_Type = "ref";
		public List<int> m_conditions_refId { get; set; }
		public const string m_conditions_Class = "hkbCondition";
		public const string m_conditions_Array = "True";

	}
}
