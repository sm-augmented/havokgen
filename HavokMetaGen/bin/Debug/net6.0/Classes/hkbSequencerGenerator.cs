using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbSequencerGenerator: hkbGenerator
	{
		public const string version = "0";
		public List<hkbSequenceTag> m_tags { get; set; }
		public const string m_tags_Name = "tags";
		public const string m_tags_Type = "ref";
		public List<int> m_tags_refId { get; set; }
		public const string m_tags_Class = "hkbSequenceTag";
		public const string m_tags_Array = "True";
		public hkbGenerator m_generator { get; set; }
		public const string m_generator_Name = "generator";
		public const string m_generator_Type = "ref";
		public int m_generator_refId { get; set; }
		public const string m_generator_Class = "hkbGenerator";

	}
}
