using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCleanHandleModifier: hkbModifier
	{
		public const string version = "0";
		public hkbHandle m_handle { get; set; }
		public const string m_handle_Name = "handle";
		public const string m_handle_Type = "ref";
		public int m_handle_refId { get; set; }
		public const string m_handle_Class = "hkbHandle";

	}
}
