using System;


namespace R5T.F0062
{
	public class Colors : IColors
	{
		#region Infrastructure

	    public static IColors Instance { get; } = new Colors();

	    private Colors()
	    {
        }

	    #endregion
	}
}