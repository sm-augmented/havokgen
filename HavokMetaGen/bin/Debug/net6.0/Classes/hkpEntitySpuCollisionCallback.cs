using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpEntitySpuCollisionCallback
	{
		public const string version = "0";
		public int m_capacity { get; set; }
		public const string m_capacity_Name = "capacity";
		public const string m_capacity_Type = "int";
		public byte m_eventFilter { get; set; }
		public const string m_eventFilter_Name = "eventFilter";
		public const string m_eventFilter_Type = "byte";
		public byte m_userFilter { get; set; }
		public const string m_userFilter_Name = "userFilter";
		public const string m_userFilter_Type = "byte";

	}
}
