// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void AddWidgetHandler(object o, AddWidgetArgs args);

	public class AddWidgetArgs : GLib.SignalArgs {
		public Gtk.Widget Widget{
			get {
				return (Gtk.Widget) Args [0];
			}
		}

	}
}