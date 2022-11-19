using System;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.F0062
{
	[FunctionalityMarker]
	public partial interface ITextBoxOperator : IFunctionalityMarker
	{
		/// <summary>
		/// It can be hard to remember which event of a <see cref="TextBox"/> should be handled for text changed.
		/// The correct event is <see cref="Control.TextChanged"/>.
		/// This event is fired every time a key is entered.
		/// </summary>
		public void AddTextChangedHandler(
			TextBox textBox,
			EventHandler textChangedHandler)
        {
			textBox.TextChanged += textChangedHandler;
        }

		/// <summary>
		/// It can be hard to remember which property of a <see cref="TextBox"/> contains its value.
		/// The correct property is <see cref="TextBox.Text"/>.
		/// </summary>
		public string Get_Value(TextBox textBox)
        {
			var value = textBox.Text;
			return value;
        }

		/// <summary>
		/// It can be hard to remember which property of a <see cref="TextBox"/> contains its value.
		/// The correct property is <see cref="TextBox.Text"/>.
		/// </summary>
		public void Set_Value(TextBox textBox, string value)
        {
			textBox.Text = value;
        }

		/// <inheritdoc cref="AddTextChangedHandler(TextBox, EventHandler)"/>
		public void RemoveTextChangedHandler(
			TextBox textBox,
			EventHandler textChangedHandler)
		{
			textBox.TextChanged -= textChangedHandler;
		}
	}
}