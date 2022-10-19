using System;

using R5T.T0131;


namespace R5T.F0062
{
	[ValuesMarker]
	public partial interface IStrings : IValuesMarker
	{
		public string DefaultLabelText => Z0000.Strings.Instance.Ellipsis;
	}
}