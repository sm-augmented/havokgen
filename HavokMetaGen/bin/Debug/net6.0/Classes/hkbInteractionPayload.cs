using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbInteractionPayload: hkReferencedObject
	{
		public const string version = "0";
		public float m_fraction { get; set; }
		public const string m_fraction_Name = "fraction";
		public const string m_fraction_Type = "real";

	}
}
