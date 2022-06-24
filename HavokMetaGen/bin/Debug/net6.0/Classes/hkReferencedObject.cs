using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkReferencedObject: hkBaseObject
	{
		public const string version = "0";
		public int m_memSizeAndFlags { get; set; }
		public const string m_memSizeAndFlags_Name = "memSizeAndFlags";
		public const string m_memSizeAndFlags_Type = "int";
		public int m_referenceCount { get; set; }
		public const string m_referenceCount_Name = "referenceCount";
		public const string m_referenceCount_Type = "int";

	}
}
