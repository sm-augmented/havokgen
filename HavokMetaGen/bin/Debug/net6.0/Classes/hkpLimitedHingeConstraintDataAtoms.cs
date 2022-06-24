using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpLimitedHingeConstraintDataAtoms
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
		public hkpAngMotorConstraintAtom m_angMotor { get; set; }
		public const string m_angMotor_Name = "angMotor";
		public const string m_angMotor_Type = "struct";
		public const string m_angMotor_Class = "hkpAngMotorConstraintAtom";
		public hkpAngFrictionConstraintAtom m_angFriction { get; set; }
		public const string m_angFriction_Name = "angFriction";
		public const string m_angFriction_Type = "struct";
		public const string m_angFriction_Class = "hkpAngFrictionConstraintAtom";
		public hkpAngLimitConstraintAtom m_angLimit { get; set; }
		public const string m_angLimit_Name = "angLimit";
		public const string m_angLimit_Type = "struct";
		public const string m_angLimit_Class = "hkpAngLimitConstraintAtom";
		public hkp2dAngConstraintAtom m_2dAng { get; set; }
		public const string m_2dAng_Name = "2dAng";
		public const string m_2dAng_Type = "struct";
		public const string m_2dAng_Class = "hkp2dAngConstraintAtom";
		public hkpBallSocketConstraintAtom m_ballSocket { get; set; }
		public const string m_ballSocket_Name = "ballSocket";
		public const string m_ballSocket_Type = "struct";
		public const string m_ballSocket_Class = "hkpBallSocketConstraintAtom";

	}
}
