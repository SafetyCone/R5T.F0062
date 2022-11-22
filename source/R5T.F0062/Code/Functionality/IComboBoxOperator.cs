using System;

using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface IComboBoxOperator : IFunctionalityMarker
	{
		public string Get_ValueString(ComboBox comboBox)
		{
			var value = comboBox.SelectedItem as string;
			return value;
		}
	}
}