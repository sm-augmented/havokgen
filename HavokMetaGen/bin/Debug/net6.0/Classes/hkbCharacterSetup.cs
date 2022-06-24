using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCharacterSetup: hkReferencedObject
	{
		public const string version = "2";
		public List<hkaSkeletonMapper> m_retargetingSkeletonMappers { get; set; }
		public const string m_retargetingSkeletonMappers_Name = "retargetingSkeletonMappers";
		public const string m_retargetingSkeletonMappers_Type = "ref";
		public List<int> m_retargetingSkeletonMappers_refId { get; set; }
		public const string m_retargetingSkeletonMappers_Class = "hkaSkeletonMapper";
		public const string m_retargetingSkeletonMappers_Array = "True";
		public hkaSkeleton m_animationSkeleton { get; set; }
		public const string m_animationSkeleton_Name = "animationSkeleton";
		public const string m_animationSkeleton_Type = "ref";
		public int m_animationSkeleton_refId { get; set; }
		public const string m_animationSkeleton_Class = "hkaSkeleton";
		public hkaSkeletonMapper m_ragdollToAnimationSkeletonMapper { get; set; }
		public const string m_ragdollToAnimationSkeletonMapper_Name = "ragdollToAnimationSkeletonMapper";
		public const string m_ragdollToAnimationSkeletonMapper_Type = "ref";
		public int m_ragdollToAnimationSkeletonMapper_refId { get; set; }
		public const string m_ragdollToAnimationSkeletonMapper_Class = "hkaSkeletonMapper";
		public hkaSkeletonMapper m_animationToRagdollSkeletonMapper { get; set; }
		public const string m_animationToRagdollSkeletonMapper_Name = "animationToRagdollSkeletonMapper";
		public const string m_animationToRagdollSkeletonMapper_Type = "ref";
		public int m_animationToRagdollSkeletonMapper_refId { get; set; }
		public const string m_animationToRagdollSkeletonMapper_Class = "hkaSkeletonMapper";
		public hkbCharacterData m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "ref";
		public int m_data_refId { get; set; }
		public const string m_data_Class = "hkbCharacterData";

	}
}
