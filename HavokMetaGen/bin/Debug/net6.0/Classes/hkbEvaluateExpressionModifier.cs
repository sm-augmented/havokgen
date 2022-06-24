using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEvaluateExpressionModifier: hkbModifier
	{
		public const string version = "1";
		public hkbExpressionDataArray m_expressions { get; set; }
		public const string m_expressions_Name = "expressions";
		public const string m_expressions_Type = "ref";
		public int m_expressions_refId { get; set; }
		public const string m_expressions_Class = "hkbExpressionDataArray";

	}
}
