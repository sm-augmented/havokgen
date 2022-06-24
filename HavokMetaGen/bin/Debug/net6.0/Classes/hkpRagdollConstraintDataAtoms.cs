using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpRagdollConstraintDataAtoms
	{
		public const string version = "1";
		public hkpSetLocalTransformsConstraintAtom m_transforms { get; set; }
		public const string m_transforms_Name = "transforms";
		public const string m_transforms_Type = "struct";
		public const string m_transforms_Class = "hkpSetLocalTransformsConstraintAtom";
		public hkpSetupStabilizationAtom m_setupStabilization { get; set; }
		public const string m_setupStabilization_Name = "setupStabilization";
		public const string m_setupStabilization_Type = "struct";
		public const string m_setupStabilization_Class = "hkpSetupStabilizationAtom";
		public hkpRagdollMotorConstraintAtom m_ragdollMotors { get; set; }
		public const string m_ragdollMotors_Name = "ragdollMotors";
		public const string m_ragdollMotors_Type = "struct";
		public const string m_ragdollMotors_Class = "hkpRagdollMotorConstraintAtom";
		public hkpAngFrictionConstraintAtom m_angFriction { get; set; }
		public const string m_angFriction_Name = "angFriction";
		public const string m_angFriction_Type = "struct";
		public const string m_angFriction_Class = "hkpAngFrictionConstraintAtom";
		public hkpTwistLimitConstraintAtom m_twistLimit { get; set; }
		public const string m_twistLimit_Name = "twistLimit";
		public const string m_twistLimit_Type = "struct";
		public const string m_twistLimit_Class = "hkpTwistLimitConstraintAtom";
		public hkpConeLimitConstraintAtom m_coneLimit { get; set; }
		public const string m_coneLimit_Name = "coneLimit";
		public const string m_coneLimit_Type = "struct";
		public const string m_coneLimit_Class = "hkpConeLimitConstraintAtom";
		public hkpConeLimitConstraintAtom m_planesLimit { get; set; }
		public const string m_planesLimit_Name = "planesLimit";
		public const string m_planesLimit_Type = "struct";
		public const string m_planesLimit_Class = "hkpConeLimitConstraintAtom";
		public hkpBallSocketConstraintAtom m_ballSocket { get; set; }
		public const string m_ballSocket_Name = "ballSocket";
		public const string m_ballSocket_Type = "struct";
		public const string m_ballSocket_Class = "hkpBallSocketConstraintAtom";

	}
}
