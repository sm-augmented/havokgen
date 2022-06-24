using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbPoweredRagdollControlData
	{
		public const string version = "3";
		public float m_maxForce { get; set; }
		public const string m_maxForce_Name = "maxForce";
		public const string m_maxForce_Type = "real";
		public float m_tau { get; set; }
		public const string m_tau_Name = "tau";
		public const string m_tau_Type = "real";
		public float m_damping { get; set; }
		public const string m_damping_Name = "damping";
		public const string m_damping_Type = "real";
		public float m_proportionalRecoveryVelocity { get; set; }
		public const string m_proportionalRecoveryVelocity_Name = "proportionalRecoveryVelocity";
		public const string m_proportionalRecoveryVelocity_Type = "real";
		public float m_constantRecoveryVelocity { get; set; }
		public const string m_constantRecoveryVelocity_Name = "constantRecoveryVelocity";
		public const string m_constantRecoveryVelocity_Type = "real";

	}
}
