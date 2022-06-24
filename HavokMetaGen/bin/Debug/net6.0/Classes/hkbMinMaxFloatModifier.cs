using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbMinMaxFloatModifier: hkbModifier
	{
		public const string version = "0";
		public float m_inputValue { get; set; }
		public const string m_inputValue_Name = "inputValue";
		public const string m_inputValue_Type = "real";
		public float m_outputValue { get; set; }
		public const string m_outputValue_Name = "outputValue";
		public const string m_outputValue_Type = "real";
		public float m_maxLimit { get; set; }
		public const string m_maxLimit_Name = "maxLimit";
		public const string m_maxLimit_Type = "real";
		public float m_minLimit { get; set; }
		public const string m_minLimit_Name = "minLimit";
		public const string m_minLimit_Type = "real";
		public byte m_useMaxLimit { get; set; }
		public const string m_useMaxLimit_Name = "useMaxLimit";
		public const string m_useMaxLimit_Type = "byte";
		public byte m_useMinLimit { get; set; }
		public const string m_useMinLimit_Name = "useMinLimit";
		public const string m_useMinLimit_Type = "byte";

	}
}
