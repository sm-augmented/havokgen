using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbNegateCondition: hkbCondition
	{
		public const string version = "0";
		public hkbCondition m_condition { get; set; }
		public const string m_condition_Name = "condition";
		public const string m_condition_Type = "ref";
		public int m_condition_refId { get; set; }
		public const string m_condition_Class = "hkbCondition";

	}
}
