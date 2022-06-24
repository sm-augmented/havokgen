using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSkeletonMapper: hkReferencedObject
	{
		public const string version = "0";
		public hkaSkeletonMapperData m_mapping { get; set; }
		public const string m_mapping_Name = "mapping";
		public const string m_mapping_Type = "struct";
		public const string m_mapping_Class = "hkaSkeletonMapperData";

	}
}
