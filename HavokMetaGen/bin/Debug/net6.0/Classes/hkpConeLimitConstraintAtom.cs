using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConeLimitConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public byte m_isEnabled { get; set; }
		public const string m_isEnabled_Name = "isEnabled";
		public const string m_isEnabled_Type = "byte";
		public byte m_twistAxisInA { get; set; }
		public const string m_twistAxisInA_Name = "twistAxisInA";
		public const string m_twistAxisInA_Type = "byte";
		public byte m_refAxisInB { get; set; }
		public const string m_refAxisInB_Name = "refAxisInB";
		public const string m_refAxisInB_Type = "byte";
		public byte m_angleMeasurementMode { get; set; }
		public const string m_angleMeasurementMode_Name = "angleMeasurementMode";
		public const string m_angleMeasurementMode_Type = "byte";
		public byte m_memOffsetToAngleOffset { get; set; }
		public const string m_memOffsetToAngleOffset_Name = "memOffsetToAngleOffset";
		public const string m_memOffsetToAngleOffset_Type = "byte";
		public float m_minAngle { get; set; }
		public const string m_minAngle_Name = "minAngle";
		public const string m_minAngle_Type = "real";
		public float m_maxAngle { get; set; }
		public const string m_maxAngle_Name = "maxAngle";
		public const string m_maxAngle_Type = "real";
		public float m_angularLimitsTauFactor { get; set; }
		public const string m_angularLimitsTauFactor_Name = "angularLimitsTauFactor";
		public const string m_angularLimitsTauFactor_Type = "real";

	}
}
