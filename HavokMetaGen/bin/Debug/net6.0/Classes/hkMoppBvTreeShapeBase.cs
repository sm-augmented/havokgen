using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkMoppBvTreeShapeBase: hkpBvTreeShape
	{
		public const string version = "0";
		public hkpMoppCode m_code { get; set; }
		public const string m_code_Name = "code";
		public const string m_code_Type = "ref";
		public int m_code_refId { get; set; }
		public const string m_code_Class = "hkpMoppCode";
		public int m_moppDataSize { get; set; }
		public const string m_moppDataSize_Name = "moppDataSize";
		public const string m_moppDataSize_Type = "int";
		public List<float> m_codeInfoCopy { get; set; }
		public const string m_codeInfoCopy_Name = "codeInfoCopy";
		public const string m_codeInfoCopy_Type = "vec4";

	}
}
