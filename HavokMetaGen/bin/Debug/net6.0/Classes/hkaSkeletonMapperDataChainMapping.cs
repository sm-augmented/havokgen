using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSkeletonMapperDataChainMapping
	{
		public const string version = "0";
		public int m_startBoneA { get; set; }
		public const string m_startBoneA_Name = "startBoneA";
		public const string m_startBoneA_Type = "int";
		public int m_endBoneA { get; set; }
		public const string m_endBoneA_Name = "endBoneA";
		public const string m_endBoneA_Type = "int";
		public int m_startBoneB { get; set; }
		public const string m_startBoneB_Name = "startBoneB";
		public const string m_startBoneB_Type = "int";
		public int m_endBoneB { get; set; }
		public const string m_endBoneB_Name = "endBoneB";
		public const string m_endBoneB_Type = "int";
		public List<float> m_startAFromBTransform { get; set; }
		public const string m_startAFromBTransform_Name = "startAFromBTransform";
		public const string m_startAFromBTransform_Type = "vec12";
		public List<float> m_endAFromBTransform { get; set; }
		public const string m_endAFromBTransform_Name = "endAFromBTransform";
		public const string m_endAFromBTransform_Type = "vec12";

	}
}
