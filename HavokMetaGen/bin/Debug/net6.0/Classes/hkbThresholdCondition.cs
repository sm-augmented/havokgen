using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbThresholdCondition: hkbCondition
	{
		public const string version = "0";
		public float m_minRange { get; set; }
		public const string m_minRange_Name = "minRange";
		public const string m_minRange_Type = "real";
		public float m_maxRange { get; set; }
		public const string m_maxRange_Name = "maxRange";
		public const string m_maxRange_Type = "real";
		public byte m_exclusive { get; set; }
		public const string m_exclusive_Name = "exclusive";
		public const string m_exclusive_Type = "byte";
		public byte m_invert { get; set; }
		public const string m_invert_Name = "invert";
		public const string m_invert_Type = "byte";
		public int m_inputValue { get; set; }
		public const string m_inputValue_Name = "inputValue";
		public const string m_inputValue_Type = "int";

	}
}
