
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	using TextBox = System.Windows.Forms.TextBox;
	using ComboBox = System.Windows.Forms.ComboBox;
	using NumericUpDown = System.Windows.Forms.NumericUpDown;
	using FieldList = System.Collections.ArrayList;

	class getFLMember
	{
		public static TextBox asTextBox(FieldList fields, int idx)
		{
			return (TextBox)(fields[idx]);
		}
		public static ComboBox asComboBox(FieldList fields, int idx)
		{
			return (ComboBox)(fields[idx]);
		}
		public static NumericUpDown asNumericUpDown(FieldList fields, int idx)
		{
			return (NumericUpDown)(fields[idx]);
		}
	}

	[Serializable]
	public class Patient
	{
		public string f, i, o;
		public DateTime birthdate;
		public bool gender;

		public string getFIOstring()
		{
			return f + " " + i + " " + o;
		}

		public void disassemble(FieldList fields)
		{
			getFLMember.asTextBox(fields, 0).Text = this.f;
			getFLMember.asTextBox(fields, 1).Text = this.i;
			getFLMember.asTextBox(fields, 2).Text = this.o;
			getFLMember.asNumericUpDown(fields, 3).Value = 1;
			getFLMember.asNumericUpDown(fields, 3).Value = 2;
			getFLMember.asNumericUpDown(fields, 3).Value = this.birthdate.Day;
			getFLMember.asComboBox(fields, 4).SelectedIndex = this.birthdate.Month - 1;
			getFLMember.asTextBox(fields, 5).Text = this.birthdate.Year.ToString();
			getFLMember.asComboBox(fields, 6).SelectedIndex = this.gender ? 1 : 0;
		}

        public void assemble(FieldList fields)
		{
			string f = ((TextBox)fields[0]).Text;
            string i = ((TextBox)fields[1]).Text;
            string o = ((TextBox)fields[2]).Text;

			int y;
			try
			{
				y = int.Parse(getFLMember.asTextBox(fields, 5).Text);
            }
			catch (Exception)
			{
				throw new Exception("Некорректный год");
			}

			DateTime date;
			try
            {
                date = new DateTime(
                    y,
                    getFLMember.asComboBox(fields, 4).SelectedIndex + 1,
                    (int)getFLMember.asNumericUpDown(fields, 3).Value
                    );

                if (date.Year < 1900)
					throw new Exception();
            }
			catch (Exception)
			{
				throw new Exception("Некорректная дата");
			}

            if (date.Date.AddDays(2) >= DateTime.Today)
                throw new Exception("Указанная дата ещё не наступила");

            var selected_gender = getFLMember.asComboBox(fields, 6).SelectedIndex;
			bool gender;
			if (selected_gender == 1)
				gender = true;
			else if (selected_gender == 0)
				gender = false;
			else
				throw new Exception("Укажите пол пациента");

			this.f = f;
			this.i = i;
			this.o = o;
			this.birthdate = date;
			this.gender = gender;
		}
	}
}
