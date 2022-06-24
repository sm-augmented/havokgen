using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBoneWeightArray: hkbBindable
	{
		public const string version = "0";
		public List<float> m_boneWeights { get; set; }
		public const string m_boneWeights_Name = "boneWeights";
		public const string m_boneWeights_Type = "real";
		public const string m_boneWeights_Array = "True";

	}
}
