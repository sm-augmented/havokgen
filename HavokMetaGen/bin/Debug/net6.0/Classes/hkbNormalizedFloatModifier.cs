using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbNormalizedFloatModifier: hkbModifier
	{
		public const string version = "0";
		public float m_rangeMin { get; set; }
		public const string m_rangeMin_Name = "rangeMin";
		public const string m_rangeMin_Type = "real";
		public float m_rangeMax { get; set; }
		public const string m_rangeMax_Name = "rangeMax";
		public const string m_rangeMax_Type = "real";
		public float m_inputValue { get; set; }
		public const string m_inputValue_Name = "inputValue";
		public const string m_inputValue_Type = "real";
		public byte m_invert { get; set; }
		public const string m_invert_Name = "invert";
		public const string m_invert_Type = "byte";
		public float m_outputValue { get; set; }
		public const string m_outputValue_Name = "outputValue";
		public const string m_outputValue_Type = "real";

	}
}
