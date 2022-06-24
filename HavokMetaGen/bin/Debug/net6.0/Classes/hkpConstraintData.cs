using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConstraintData: hkReferencedObject
	{
		public const string version = "0";
		public int m_userData { get; set; }
		public const string m_userData_Name = "userData";
		public const string m_userData_Type = "int";

	}
}
