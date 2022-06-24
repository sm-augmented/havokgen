using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpLimitedForceConstraintMotor: hkpConstraintMotor
	{
		public const string version = "0";
		public float m_minForce { get; set; }
		public const string m_minForce_Name = "minForce";
		public const string m_minForce_Type = "real";
		public float m_maxForce { get; set; }
		public const string m_maxForce_Name = "maxForce";
		public const string m_maxForce_Type = "real";

	}
}
