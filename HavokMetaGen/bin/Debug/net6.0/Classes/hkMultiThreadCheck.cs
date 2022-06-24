using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkMultiThreadCheck
	{
		public const string version = "0";
		public int m_threadId { get; set; }
		public const string m_threadId_Name = "threadId";
		public const string m_threadId_Type = "int";
		public int m_stackTraceId { get; set; }
		public const string m_stackTraceId_Name = "stackTraceId";
		public const string m_stackTraceId_Type = "int";
		public int m_markCount { get; set; }
		public const string m_markCount_Name = "markCount";
		public const string m_markCount_Type = "int";
		public int m_markBitStack { get; set; }
		public const string m_markBitStack_Name = "markBitStack";
		public const string m_markBitStack_Type = "int";

	}
}
