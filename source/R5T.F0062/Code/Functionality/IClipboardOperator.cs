using System;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface IClipboardOperator : IFunctionalityMarker
	{
		public void SetText(string text)
        {
			Clipboard.SetText(text);
        }
	}
}