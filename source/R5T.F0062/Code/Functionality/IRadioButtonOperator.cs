using System;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface IRadioButtonOperator : IFunctionalityMarker
	{
		public void IfChecked(
			RadioButton radioButton,
			Action action)
        {
			var isChecked = radioButton.Checked;
			if(isChecked)
            {
				action();
            }
        }
	}
}