using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpLimitedHingeConstraintData: hkpConstraintData
	{
		public const string version = "0";
		public hkpLimitedHingeConstraintDataAtoms m_atoms { get; set; }
		public const string m_atoms_Name = "atoms";
		public const string m_atoms_Type = "struct";
		public const string m_atoms_Class = "hkpLimitedHingeConstraintDataAtoms";

	}
}
