using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpRagdollConstraintData: hkpConstraintData
	{
		public const string version = "0";
		public hkpRagdollConstraintDataAtoms m_atoms { get; set; }
		public const string m_atoms_Name = "atoms";
		public const string m_atoms_Type = "struct";
		public const string m_atoms_Class = "hkpRagdollConstraintDataAtoms";

	}
}
