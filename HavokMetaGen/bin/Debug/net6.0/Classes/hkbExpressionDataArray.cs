using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbExpressionDataArray: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbExpressionData> m_expressionsData { get; set; }
		public const string m_expressionsData_Name = "expressionsData";
		public const string m_expressionsData_Type = "struct";
		public const string m_expressionsData_Class = "hkbExpressionData";
		public const string m_expressionsData_Array = "True";

	}
}
