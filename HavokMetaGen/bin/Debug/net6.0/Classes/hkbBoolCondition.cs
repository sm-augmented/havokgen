using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBoolCondition: hkbCondition
	{
		public const string version = "0";
		public List<hkbBoolConditionBooleanValue> m_trueBooleans { get; set; }
		public const string m_trueBooleans_Name = "trueBooleans";
		public const string m_trueBooleans_Type = "struct";
		public const string m_trueBooleans_Class = "hkbBoolConditionBooleanValue";
		public const string m_trueBooleans_Array = "True";
		public List<hkbBoolConditionBooleanValue> m_falseBooleans { get; set; }
		public const string m_falseBooleans_Name = "falseBooleans";
		public const string m_falseBooleans_Type = "struct";
		public const string m_falseBooleans_Class = "hkbBoolConditionBooleanValue";
		public const string m_falseBooleans_Array = "True";

	}
}
