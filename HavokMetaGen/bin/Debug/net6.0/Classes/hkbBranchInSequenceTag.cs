using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBranchInSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public int m_branchId { get; set; }
		public const string m_branchId_Name = "branchId";
		public const string m_branchId_Type = "int";

	}
}
