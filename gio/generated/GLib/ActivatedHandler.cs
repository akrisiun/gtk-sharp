// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void ActivatedHandler(object o, ActivatedArgs args);

	public class ActivatedArgs : GLib.SignalArgs {
		public GLib.Variant Parameter{
			get {
				return (GLib.Variant) Args [0];
			}
		}

	}
}
