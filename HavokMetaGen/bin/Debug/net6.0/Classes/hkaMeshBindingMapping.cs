using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaMeshBindingMapping
	{
		public const string version = "0";
		public List<int> m_mapping { get; set; }
		public const string m_mapping_Name = "mapping";
		public const string m_mapping_Type = "int";
		public const string m_mapping_Array = "True";

	}
}
