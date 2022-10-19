using System;
using System.Windows.Forms;

using R5T.T0142;


namespace R5T.F0062
{
    [DraftUtilityTypeMarker]
    public interface IHasNotifyIcon
    {
        NotifyIcon NotifyIcon { get; }
    }
}
