using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbModifierGenerator: hkbGenerator
	{
		public const string version = "0";
		public hkbModifier m_modifier { get; set; }
		public const string m_modifier_Name = "modifier";
		public const string m_modifier_Type = "ref";
		public int m_modifier_refId { get; set; }
		public const string m_modifier_Class = "hkbModifier";
		public hkbGenerator m_generator { get; set; }
		public const string m_generator_Name = "generator";
		public const string m_generator_Type = "ref";
		public int m_generator_refId { get; set; }
		public const string m_generator_Class = "hkbGenerator";

	}
}
