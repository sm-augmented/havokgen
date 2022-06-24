using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWeightedRandomSelector: hkbGenerator
	{
		public const string version = "0";
		public List<hkbWeightedRandomSelectorWeightedGenerator> m_generators { get; set; }
		public const string m_generators_Name = "generators";
		public const string m_generators_Type = "ref";
		public List<int> m_generators_refId { get; set; }
		public const string m_generators_Class = "hkbWeightedRandomSelectorWeightedGenerator";
		public const string m_generators_Array = "True";
		public int m_currentGeneratorIndex { get; set; }
		public const string m_currentGeneratorIndex_Name = "currentGeneratorIndex";
		public const string m_currentGeneratorIndex_Type = "int";

	}
}
