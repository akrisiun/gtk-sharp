// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IAsyncResult : GLib.IWrapper {

		GLib.Object SourceObject { 
			get;
		}
		IntPtr UserData { 
			get;
		}
	}

	[GLib.GInterface (typeof (AsyncResultAdapter))]
	public partial interface IAsyncResultImplementor : GLib.IWrapper {

		IntPtr UserData { get; }
		GLib.Object SourceObject { get; }
	}
#endregion
}
