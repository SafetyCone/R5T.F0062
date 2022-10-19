using System;
using System.Drawing;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface IColorOperator : IFunctionalityMarker
	{
		public Color GetTextColorForTrueOrFalse(bool trueOrFalse)
        {
			var color = trueOrFalse
				? Color.Green
				: Color.Red
				;

			return color;
        }
	}
}