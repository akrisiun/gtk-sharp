// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IInitable : GLib.IWrapper {

		bool Init(GLib.Cancellable cancellable);
	}

	[GLib.GInterface (typeof (InitableAdapter))]
	public partial interface IInitableImplementor : GLib.IWrapper {

		bool Init (GLib.Cancellable cancellable);
	}
#endregion
}