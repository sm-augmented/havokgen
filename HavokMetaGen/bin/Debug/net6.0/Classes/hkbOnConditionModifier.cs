using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbOnConditionModifier: hkbModifier
	{
		public const string version = "0";
		public hkbModifier m_modifierOnTrue { get; set; }
		public const string m_modifierOnTrue_Name = "modifierOnTrue";
		public const string m_modifierOnTrue_Type = "ref";
		public int m_modifierOnTrue_refId { get; set; }
		public const string m_modifierOnTrue_Class = "hkbModifier";
		public hkbModifier m_modifierOnFalse { get; set; }
		public const string m_modifierOnFalse_Name = "modifierOnFalse";
		public const string m_modifierOnFalse_Type = "ref";
		public int m_modifierOnFalse_refId { get; set; }
		public const string m_modifierOnFalse_Class = "hkbModifier";
		public hkbCondition m_triggerCondition { get; set; }
		public const string m_triggerCondition_Name = "triggerCondition";
		public const string m_triggerCondition_Type = "ref";
		public int m_triggerCondition_refId { get; set; }
		public const string m_triggerCondition_Class = "hkbCondition";
		public byte m_lastConditionValue { get; set; }
		public const string m_lastConditionValue_Name = "lastConditionValue";
		public const string m_lastConditionValue_Type = "byte";

	}
}
