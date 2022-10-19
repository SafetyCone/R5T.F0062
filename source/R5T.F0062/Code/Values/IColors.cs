using System;
using System.Drawing;
using System.Windows.Forms;

using R5T.T0131;


namespace R5T.F0062
{
	[ValuesMarker]
	public partial interface IColors : IValuesMarker
	{
		public Color DefaultForeColor => Control.DefaultForeColor;
	}
}