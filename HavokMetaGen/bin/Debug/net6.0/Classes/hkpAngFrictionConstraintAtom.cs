using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpAngFrictionConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public byte m_isEnabled { get; set; }
		public const string m_isEnabled_Name = "isEnabled";
		public const string m_isEnabled_Type = "byte";
		public byte m_firstFrictionAxis { get; set; }
		public const string m_firstFrictionAxis_Name = "firstFrictionAxis";
		public const string m_firstFrictionAxis_Type = "byte";
		public byte m_numFrictionAxes { get; set; }
		public const string m_numFrictionAxes_Name = "numFrictionAxes";
		public const string m_numFrictionAxes_Type = "byte";
		public float m_maxFrictionTorque { get; set; }
		public const string m_maxFrictionTorque_Name = "maxFrictionTorque";
		public const string m_maxFrictionTorque_Type = "real";

	}
}
