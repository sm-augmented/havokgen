using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSkeletonMapperDataSimpleMapping
	{
		public const string version = "0";
		public int m_boneA { get; set; }
		public const string m_boneA_Name = "boneA";
		public const string m_boneA_Type = "int";
		public int m_boneB { get; set; }
		public const string m_boneB_Name = "boneB";
		public const string m_boneB_Type = "int";
		public List<float> m_aFromBTransform { get; set; }
		public const string m_aFromBTransform_Name = "aFromBTransform";
		public const string m_aFromBTransform_Type = "vec12";

	}
}
