using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpRagdollMotorConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public byte m_isEnabled { get; set; }
		public const string m_isEnabled_Name = "isEnabled";
		public const string m_isEnabled_Type = "byte";
		public int m_initializedOffset { get; set; }
		public const string m_initializedOffset_Name = "initializedOffset";
		public const string m_initializedOffset_Type = "int";
		public int m_previousTargetAnglesOffset { get; set; }
		public const string m_previousTargetAnglesOffset_Name = "previousTargetAnglesOffset";
		public const string m_previousTargetAnglesOffset_Type = "int";
		public List<float> m_target_bRca { get; set; }
		public const string m_target_bRca_Name = "target_bRca";
		public const string m_target_bRca_Type = "vec12";
		public List<hkpConstraintMotor> m_motors { get; set; }
		public const string m_motors_Name = "motors";
		public const string m_motors_Type = "ref";
		public List<int> m_motors_refId { get; set; }
		public const string m_motors_Class = "hkpConstraintMotor";
		public const string m_motors_Count = "3";

	}
}
