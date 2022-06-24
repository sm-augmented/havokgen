using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpBvTreeShape: hkpShape
	{
		public const string version = "0";
		public byte m_bvTreeType { get; set; }
		public const string m_bvTreeType_Name = "bvTreeType";
		public const string m_bvTreeType_Type = "byte";

	}
}
