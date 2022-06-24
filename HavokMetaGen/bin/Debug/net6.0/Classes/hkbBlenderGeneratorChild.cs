using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBlenderGeneratorChild: hkbBindable
	{
		public const string version = "2";
		public hkbGenerator m_generator { get; set; }
		public const string m_generator_Name = "generator";
		public const string m_generator_Type = "ref";
		public int m_generator_refId { get; set; }
		public const string m_generator_Class = "hkbGenerator";
		public hkbBoneWeightArray m_boneWeights { get; set; }
		public const string m_boneWeights_Name = "boneWeights";
		public const string m_boneWeights_Type = "ref";
		public int m_boneWeights_refId { get; set; }
		public const string m_boneWeights_Class = "hkbBoneWeightArray";
		public float m_weight { get; set; }
		public const string m_weight_Name = "weight";
		public const string m_weight_Type = "real";
		public float m_worldFromModelWeight { get; set; }
		public const string m_worldFromModelWeight_Name = "worldFromModelWeight";
		public const string m_worldFromModelWeight_Type = "real";

	}
}
