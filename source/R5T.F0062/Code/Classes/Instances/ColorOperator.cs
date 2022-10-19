using System;


namespace R5T.F0062
{
	public class ColorOperator : IColorOperator
	{
		#region Infrastructure

	    public static IColorOperator Instance { get; } = new ColorOperator();

	    private ColorOperator()
	    {
        }

	    #endregion
	}
}