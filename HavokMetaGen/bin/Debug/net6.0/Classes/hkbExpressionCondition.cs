using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbExpressionCondition: hkbCondition
	{
		public const string version = "1";
		public string m_expression { get; set; }
		public const string m_expression_Name = "expression";
		public const string m_expression_Type = "string";

	}
}
