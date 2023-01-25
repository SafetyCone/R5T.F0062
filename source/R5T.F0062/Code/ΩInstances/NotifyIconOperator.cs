using System;


namespace R5T.F0062
{
    public class NotifyIconOperator : INotifyIconOperator
    {
        #region Infrastructure

        public static INotifyIconOperator Instance { get; } = new NotifyIconOperator();

        private NotifyIconOperator()
        {
        }

        #endregion
    }
}