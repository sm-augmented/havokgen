using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertyWeaponData: hkbEntityPropertyControlData
	{
		public const string version = "0";
		public int m_meleeWeaponDeployed { get; set; }
		public const string m_meleeWeaponDeployed_Name = "meleeWeaponDeployed";
		public const string m_meleeWeaponDeployed_Type = "int";
		public int m_rangeWeaponDeployed { get; set; }
		public const string m_rangeWeaponDeployed_Name = "rangeWeaponDeployed";
		public const string m_rangeWeaponDeployed_Type = "int";
		public int m_exoticWeaponDeployed { get; set; }
		public const string m_exoticWeaponDeployed_Name = "exoticWeaponDeployed";
		public const string m_exoticWeaponDeployed_Type = "int";

	}
}
