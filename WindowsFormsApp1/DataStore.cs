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
		public SerializableDictionary<ulong, ulong[]> tablePatientsToUSPs;

		public bool dataModified;
		public string currentFilePath;

		public ulong maxID = 0;

		public DataStore()
		{
			this.tablePatients = new SerializableDictionary<ulong, Patient>();
			this.tableUSPs = new SerializableDictionary<ulong, USP>();
			this.tablePatientsToUSPs = new SerializableDictionary<ulong, ulong[]>();

			this.dataModified = false;
			this.currentFilePath = "";
		}

		public ulong newPatientID()
		{
			return ++this.maxID;
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
