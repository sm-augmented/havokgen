using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxVertexBufferVertexData
	{
		public const string version = "0";
		public List<List<float>> m_vectorData { get; set; }
		public const string m_vectorData_Name = "vectorData";
		public const string m_vectorData_Type = "vec4";
		public const string m_vectorData_Array = "True";
		public List<float> m_floatData { get; set; }
		public const string m_floatData_Name = "floatData";
		public const string m_floatData_Type = "real";
		public const string m_floatData_Array = "True";
		public List<int> m_uint32Data { get; set; }
		public const string m_uint32Data_Name = "uint32Data";
		public const string m_uint32Data_Type = "int";
		public const string m_uint32Data_Array = "True";
		public List<int> m_uint16Data { get; set; }
		public const string m_uint16Data_Name = "uint16Data";
		public const string m_uint16Data_Type = "int";
		public const string m_uint16Data_Array = "True";
		public List<byte> m_uint8Data { get; set; }
		public const string m_uint8Data_Name = "uint8Data";
		public const string m_uint8Data_Type = "byte";
		public const string m_uint8Data_Array = "True";
		public int m_numVerts { get; set; }
		public const string m_numVerts_Name = "numVerts";
		public const string m_numVerts_Type = "int";
		public int m_vectorStride { get; set; }
		public const string m_vectorStride_Name = "vectorStride";
		public const string m_vectorStride_Type = "int";
		public int m_floatStride { get; set; }
		public const string m_floatStride_Name = "floatStride";
		public const string m_floatStride_Type = "int";
		public int m_uint32Stride { get; set; }
		public const string m_uint32Stride_Name = "uint32Stride";
		public const string m_uint32Stride_Type = "int";
		public int m_uint16Stride { get; set; }
		public const string m_uint16Stride_Name = "uint16Stride";
		public const string m_uint16Stride_Type = "int";
		public int m_uint8Stride { get; set; }
		public const string m_uint8Stride_Name = "uint8Stride";
		public const string m_uint8Stride_Type = "int";

	}
}
