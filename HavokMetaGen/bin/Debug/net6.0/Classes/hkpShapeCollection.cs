using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpShapeCollection: hkpShape
	{
		public const string version = "0";
		public byte m_disableWelding { get; set; }
		public const string m_disableWelding_Name = "disableWelding";
		public const string m_disableWelding_Type = "byte";
		public byte m_collectionType { get; set; }
		public const string m_collectionType_Name = "collectionType";
		public const string m_collectionType_Type = "byte";

	}
}
