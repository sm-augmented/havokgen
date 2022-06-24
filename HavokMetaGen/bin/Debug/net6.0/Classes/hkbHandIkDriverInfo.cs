using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbHandIkDriverInfo: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbHandIkDriverInfoHand> m_hands { get; set; }
		public const string m_hands_Name = "hands";
		public const string m_hands_Type = "struct";
		public const string m_hands_Class = "hkbHandIkDriverInfoHand";
		public const string m_hands_Array = "True";
		public int m_fadeInOutCurve { get; set; }
		public const string m_fadeInOutCurve_Name = "fadeInOutCurve";
		public const string m_fadeInOutCurve_Type = "int";

	}
}
