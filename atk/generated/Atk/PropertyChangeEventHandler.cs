// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

	public delegate void PropertyChangeEventHandler(object o, PropertyChangeArgs args);

	public class PropertyChangeArgs : GLib.SignalArgs {
		public Atk.PropertyValues Values{
			get {
				return (Atk.PropertyValues) Args [0];
			}
		}

	}
}
