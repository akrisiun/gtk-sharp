// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void FocusChangedHandler(object o, FocusChangedArgs args);

	public class FocusChangedArgs : GLib.SignalArgs {
		public Gtk.CellRenderer P0{
			get {
				return (Gtk.CellRenderer) Args [0];
			}
		}

		public string P1{
			get {
				return (string) Args [1];
			}
		}

	}
}
