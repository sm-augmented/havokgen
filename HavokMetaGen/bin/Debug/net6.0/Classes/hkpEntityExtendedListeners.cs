using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpEntityExtendedListeners
	{
		public const string version = "0";
		public hkpEntitySmallArraySerializeOverrideType m_activationListeners { get; set; }
		public const string m_activationListeners_Name = "activationListeners";
		public const string m_activationListeners_Type = "struct";
		public const string m_activationListeners_Class = "hkpEntitySmallArraySerializeOverrideType";
		public hkpEntitySmallArraySerializeOverrideType m_entityListeners { get; set; }
		public const string m_entityListeners_Name = "entityListeners";
		public const string m_entityListeners_Type = "struct";
		public const string m_entityListeners_Class = "hkpEntitySmallArraySerializeOverrideType";

	}
}
