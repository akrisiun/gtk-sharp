// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ChildNotifiedHandler(object o, ChildNotifiedArgs args);

	public class ChildNotifiedArgs : GLib.SignalArgs {
		public IntPtr Pspec{
			get {
				return (IntPtr) Args [0];
			}
		}

	}
}
