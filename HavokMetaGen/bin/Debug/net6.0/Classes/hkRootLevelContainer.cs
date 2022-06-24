using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkRootLevelContainer
	{
		public const string version = "0";
		public List<hkRootLevelContainerNamedVariant> m_namedVariants { get; set; }
		public const string m_namedVariants_Name = "namedVariants";
		public const string m_namedVariants_Type = "struct";
		public const string m_namedVariants_Class = "hkRootLevelContainerNamedVariant";
		public const string m_namedVariants_Array = "True";

	}
}
