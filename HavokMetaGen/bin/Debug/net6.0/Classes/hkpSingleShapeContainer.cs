using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpSingleShapeContainer: hkpShapeContainer
	{
		public const string version = "0";
		public hkpShape m_childShape { get; set; }
		public const string m_childShape_Name = "childShape";
		public const string m_childShape_Type = "ref";
		public int m_childShape_refId { get; set; }
		public const string m_childShape_Class = "hkpShape";

	}
}
