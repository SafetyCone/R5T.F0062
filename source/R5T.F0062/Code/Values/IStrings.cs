using System;

using R5T.T0131;


namespace R5T.F0062
{
	[ValuesMarker]
	public partial interface IStrings : IValuesMarker
	{
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IStrings _Base => L0066.Strings.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public string DefaultLabelText => _Base.Ellipsis;
	}
}