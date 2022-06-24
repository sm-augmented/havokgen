using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWeightedRandomSelectorWeightedGenerator
	{
		public const string version = "0";
		public float m_genWeight { get; set; }
		public const string m_genWeight_Name = "genWeight";
		public const string m_genWeight_Type = "real";
		public hkbGenerator m_gen { get; set; }
		public const string m_gen_Name = "gen";
		public const string m_gen_Type = "ref";
		public int m_gen_refId { get; set; }
		public const string m_gen_Class = "hkbGenerator";

	}
}
