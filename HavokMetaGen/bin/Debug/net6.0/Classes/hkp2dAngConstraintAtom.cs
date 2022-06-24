using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkp2dAngConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public byte m_freeRotationAxis { get; set; }
		public const string m_freeRotationAxis_Name = "freeRotationAxis";
		public const string m_freeRotationAxis_Type = "byte";

	}
}
