using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpBallSocketConstraintAtom: hkpConstraintAtom
	{
		public const string version = "3";
		public byte m_solvingMethod { get; set; }
		public const string m_solvingMethod_Name = "solvingMethod";
		public const string m_solvingMethod_Type = "byte";
		public byte m_bodiesToNotify { get; set; }
		public const string m_bodiesToNotify_Name = "bodiesToNotify";
		public const string m_bodiesToNotify_Type = "byte";
		public byte m_velocityStabilizationFactor { get; set; }
		public const string m_velocityStabilizationFactor_Name = "velocityStabilizationFactor";
		public const string m_velocityStabilizationFactor_Type = "byte";
		public float m_maxImpulse { get; set; }
		public const string m_maxImpulse_Name = "maxImpulse";
		public const string m_maxImpulse_Type = "real";
		public float m_inertiaStabilizationFactor { get; set; }
		public const string m_inertiaStabilizationFactor_Name = "inertiaStabilizationFactor";
		public const string m_inertiaStabilizationFactor_Type = "real";

	}
}
