// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.GrabStatusGType))]
	public enum GrabStatus {

		Success,
		AlreadyGrabbed = 1,
		InvalidTime = 2,
		NotViewable = 3,
		Frozen = 4,
	}

	internal class GrabStatusGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_grab_status_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_grab_status_get_type ());
			}
		}
	}
#endregion
}
