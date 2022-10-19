using System;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface INotifyIconOperator : IFunctionalityMarker
	{
		/// <summary>
		/// For use in the <see cref="Form.OnResize(EventArgs)"/> event handler.
		/// </summary>
		public void MinimizeToSytemTray<TForm>(TForm form)
			where TForm : Form, IHasNotifyIcon
        {
			// If the form is minimized, hide it from the task bar and show the system tray icon (represented by the NotifyIcon control).
			if (form.WindowState == FormWindowState.Minimized)
			{
				form.Hide();

				form.NotifyIcon.Visible = true;
			}
		}

		public void ExpandFromSystemTray<TForm>(TForm form)
			where TForm : Form, IHasNotifyIcon
        {
			form.Show();

			form.WindowState = FormWindowState.Normal;

			form.NotifyIcon.Visible = false;
		}

		/// <summary>
		/// Returns a disengage action.
		/// </summary>
		public Action EngageMinimizeToSystemTray<TForm>(TForm form)
			where TForm : Form, IHasNotifyIcon
        {
            void FormResizeHandler(object sender, EventArgs eventArgs)
            {
                this.MinimizeToSytemTray(form);
            }

            void MouseDoubleClickHandler(object sender, MouseEventArgs mouseEventArgs)
            {
                this.ExpandFromSystemTray(form);
            }

            form.Resize += FormResizeHandler;
			form.NotifyIcon.MouseDoubleClick += MouseDoubleClickHandler;

			var disengageAction = () =>
			{
				form.Resize -= FormResizeHandler;
				form.NotifyIcon.MouseDoubleClick -= MouseDoubleClickHandler;
			};

			return disengageAction;
		}
	}
}