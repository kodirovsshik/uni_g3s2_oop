using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	[Serializable]
	public class DataStore
	{
		public SerializableDictionary<ulong, Patient> tablePatients;
		public SerializableDictionary<ulong, USP> tableUSPs;
		public SerializableDictionary<ulong, List<ulong>> tablePatientsToUSPs;

		public bool dataModified;
		public string currentFilePath;

		public ulong maxPatientID = 0;
		public ulong maxProcedureID = 0;

		public DataStore()
		{
			this.tablePatients = new SerializableDictionary<ulong, Patient>();
			this.tableUSPs = new SerializableDictionary<ulong, USP>();
			this.tablePatientsToUSPs = new SerializableDictionary<ulong, List<ulong>>();

			this.dataModified = false;
			this.currentFilePath = "";
		}

		public ulong newPatientID()
		{
			return ++this.maxPatientID;
		}
		public ulong newProcedureID()
		{
			return ++this.maxProcedureID;
		}
	}

	public class ListBoxItem
	{
        public string displayedString;
        public ulong id;

        public ListBoxItem(string displayedString, ulong id)
		{
			this.displayedString = displayedString;
			this.id = id;
		}

        public override string ToString()
		{
			return this.displayedString;
		}
	}
}
