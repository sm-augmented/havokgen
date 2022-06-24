using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAlignCharacterModifier: hkbModifier
	{
		public const string version = "0";
		public int m_alignMode { get; set; }
		public const string m_alignMode_Name = "alignMode";
		public const string m_alignMode_Type = "int";
		public List<float> m_alignVector { get; set; }
		public const string m_alignVector_Name = "alignVector";
		public const string m_alignVector_Type = "vec4";
		public float m_angleOffset { get; set; }
		public const string m_angleOffset_Name = "angleOffset";
		public const string m_angleOffset_Type = "real";
		public float m_maxRotation { get; set; }
		public const string m_maxRotation_Name = "maxRotation";
		public const string m_maxRotation_Type = "real";
		public byte m_clampRotationAngle { get; set; }
		public const string m_clampRotationAngle_Name = "clampRotationAngle";
		public const string m_clampRotationAngle_Type = "byte";
		public float m_lastTimeStep { get; set; }
		public const string m_lastTimeStep_Name = "lastTimeStep";
		public const string m_lastTimeStep_Type = "real";

	}
}
