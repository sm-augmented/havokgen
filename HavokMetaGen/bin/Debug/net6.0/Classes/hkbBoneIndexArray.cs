using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBoneIndexArray: hkbBindable
	{
		public const string version = "0";
		public List<int> m_boneIndices { get; set; }
		public const string m_boneIndices_Name = "boneIndices";
		public const string m_boneIndices_Type = "int";
		public const string m_boneIndices_Array = "True";

	}
}
