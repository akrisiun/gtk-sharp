// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void MoveScrollHandler(object o, MoveScrollArgs args);

	public class MoveScrollArgs : GLib.SignalArgs {
		public Gtk.ScrollType P0{
			get {
				return (Gtk.ScrollType) Args [0];
			}
		}

	}
}