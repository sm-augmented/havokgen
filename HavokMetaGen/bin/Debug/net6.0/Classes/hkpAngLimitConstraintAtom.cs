using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpAngLimitConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public byte m_isEnabled { get; set; }
		public const string m_isEnabled_Name = "isEnabled";
		public const string m_isEnabled_Type = "byte";
		public byte m_limitAxis { get; set; }
		public const string m_limitAxis_Name = "limitAxis";
		public const string m_limitAxis_Type = "byte";
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
