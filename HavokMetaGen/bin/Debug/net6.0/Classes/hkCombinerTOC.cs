using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkCombinerTOC: hkReferencedObject
	{
		public const string version = "0";
		public List<hkCombinerTOCTOCEntry> m_toc { get; set; }
		public const string m_toc_Name = "toc";
		public const string m_toc_Type = "ref";
		public List<int> m_toc_refId { get; set; }
		public const string m_toc_Class = "hkCombinerTOCTOCEntry";
		public const string m_toc_Array = "True";

	}
}
