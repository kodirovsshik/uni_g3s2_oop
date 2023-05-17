using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public enum USPType : byte
	{
		na = 0,
	}

	[Serializable]
	public class USP
	{
        public ulong patientId;
        public USPType type;
		public DateTime procedureDate;
	}
}
