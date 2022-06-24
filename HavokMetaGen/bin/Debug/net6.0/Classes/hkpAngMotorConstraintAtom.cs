using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpAngMotorConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public byte m_isEnabled { get; set; }
		public const string m_isEnabled_Name = "isEnabled";
		public const string m_isEnabled_Type = "byte";
		public byte m_motorAxis { get; set; }
		public const string m_motorAxis_Name = "motorAxis";
		public const string m_motorAxis_Type = "byte";
		public int m_initializedOffset { get; set; }
		public const string m_initializedOffset_Name = "initializedOffset";
		public const string m_initializedOffset_Type = "int";
		public int m_previousTargetAngleOffset { get; set; }
		public const string m_previousTargetAngleOffset_Name = "previousTargetAngleOffset";
		public const string m_previousTargetAngleOffset_Type = "int";
		public int m_correspondingAngLimitSolverResultOffset { get; set; }
		public const string m_correspondingAngLimitSolverResultOffset_Name = "correspondingAngLimitSolverResultOffset";
		public const string m_correspondingAngLimitSolverResultOffset_Type = "int";
		public float m_targetAngle { get; set; }
		public const string m_targetAngle_Name = "targetAngle";
		public const string m_targetAngle_Type = "real";
		public hkpConstraintMotor m_motor { get; set; }
		public const string m_motor_Name = "motor";
		public const string m_motor_Type = "ref";
		public int m_motor_refId { get; set; }
		public const string m_motor_Class = "hkpConstraintMotor";

	}
}
