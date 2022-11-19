using System;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface ICheckboxOperator : IFunctionalityMarker
	{
		/// <summary>
		/// This method returns a checkbox's value.
		/// It can be hard to remember which of a checkbox's properties contain it's value.
		/// The correct property is <see cref="CheckBox.Checked"/>.
		/// </summary>
		public bool GetValue(CheckBox checkBox)
        {
			var value = checkBox.Checked;
			return value;
        }
	}
}