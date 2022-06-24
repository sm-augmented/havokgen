using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSkeletonMapperData
	{
		public const string version = "1";
		public hkaSkeleton m_skeletonA { get; set; }
		public const string m_skeletonA_Name = "skeletonA";
		public const string m_skeletonA_Type = "ref";
		public int m_skeletonA_refId { get; set; }
		public const string m_skeletonA_Class = "hkaSkeleton";
		public hkaSkeleton m_skeletonB { get; set; }
		public const string m_skeletonB_Name = "skeletonB";
		public const string m_skeletonB_Type = "ref";
		public int m_skeletonB_refId { get; set; }
		public const string m_skeletonB_Class = "hkaSkeleton";
		public List<hkaSkeletonMapperDataSimpleMapping> m_simpleMappings { get; set; }
		public const string m_simpleMappings_Name = "simpleMappings";
		public const string m_simpleMappings_Type = "struct";
		public const string m_simpleMappings_Class = "hkaSkeletonMapperDataSimpleMapping";
		public const string m_simpleMappings_Array = "True";
		public List<hkaSkeletonMapperDataChainMapping> m_chainMappings { get; set; }
		public const string m_chainMappings_Name = "chainMappings";
		public const string m_chainMappings_Type = "struct";
		public const string m_chainMappings_Class = "hkaSkeletonMapperDataChainMapping";
		public const string m_chainMappings_Array = "True";
		public List<int> m_unmappedBones { get; set; }
		public const string m_unmappedBones_Name = "unmappedBones";
		public const string m_unmappedBones_Type = "int";
		public const string m_unmappedBones_Array = "True";
		public List<float> m_extractedMotionMapping { get; set; }
		public const string m_extractedMotionMapping_Name = "extractedMotionMapping";
		public const string m_extractedMotionMapping_Type = "vec12";
		public byte m_keepUnmappedLocal { get; set; }
		public const string m_keepUnmappedLocal_Name = "keepUnmappedLocal";
		public const string m_keepUnmappedLocal_Type = "byte";
		public int m_mappingType { get; set; }
		public const string m_mappingType_Name = "mappingType";
		public const string m_mappingType_Type = "int";

	}
}
