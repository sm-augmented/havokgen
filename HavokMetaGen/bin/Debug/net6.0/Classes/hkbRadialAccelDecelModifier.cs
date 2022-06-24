using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbRadialAccelDecelModifier: hkbModifier
	{
		public const string version = "0";
		public float m_inputValue { get; set; }
		public const string m_inputValue_Name = "inputValue";
		public const string m_inputValue_Type = "real";
		public float m_outputValue { get; set; }
		public const string m_outputValue_Name = "outputValue";
		public const string m_outputValue_Type = "real";
		public float m_maxAccel { get; set; }
		public const string m_maxAccel_Name = "maxAccel";
		public const string m_maxAccel_Type = "real";
		public float m_maxDecel { get; set; }
		public const string m_maxDecel_Name = "maxDecel";
		public const string m_maxDecel_Type = "real";
		public float m_minRadial { get; set; }
		public const string m_minRadial_Name = "minRadial";
		public const string m_minRadial_Type = "real";
		public float m_maxRadial { get; set; }
		public const string m_maxRadial_Name = "maxRadial";
		public const string m_maxRadial_Type = "real";
		public float m_lastFrameValue { get; set; }
		public const string m_lastFrameValue_Name = "lastFrameValue";
		public const string m_lastFrameValue_Type = "real";
		public float m_lastTimeStep { get; set; }
		public const string m_lastTimeStep_Name = "lastTimeStep";
		public const string m_lastTimeStep_Type = "real";

	}
}
