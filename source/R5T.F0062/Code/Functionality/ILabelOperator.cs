using System;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface ILabelOperator : IFunctionalityMarker
	{
		public void Reset(Label label)
		{
			var text = Instances.Strings.DefaultLabelText;

			var color = Instances.Colors.DefaultForeColor;

			label.Text = text;
			label.ForeColor = color;
		}

		public void SetTrueOrFalse(
			Label label,
			bool trueOrFalse)
        {
			var text = trueOrFalse.ToString_PascalCase();

			var color = Instances.ColorOperator.GetTextColorForTrueOrFalse(trueOrFalse);

			label.Text = text;
			label.ForeColor = color;
        }
	}
}