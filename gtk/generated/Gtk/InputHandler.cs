// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void InputHandler(object o, InputArgs args);

	public class InputArgs : GLib.SignalArgs {
		public double NewValue{
			set {
				Args[0] = (double)value;
			}
		}

	}
}
