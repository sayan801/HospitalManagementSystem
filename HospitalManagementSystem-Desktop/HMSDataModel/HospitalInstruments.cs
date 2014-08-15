using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem.HmsDesign
{
	public class HospitalInstruments
	{
		string itemName;
		int itemId;
		List<string> itemTags;
		int itemDescription;
		ResourceTypeEnum itemType;
		List<string> itemUsers;
		List<PatientDomainEnum> patientDomainList;

		public void ItemGetUsage()
		{
			throw new NotImplementedException();
		}

		public List<PatientDomainEnum> GetDomainList()
		{
			throw new NotImplementedException();
		}
	}
}
