// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.RecentManagerErrorGType))]
	public enum RecentManagerError {

		NotFound,
		InvalidUri,
		InvalidEncoding,
		NotRegistered,
		Read,
		Write,
		Unknown,
	}

	internal class RecentManagerErrorGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_manager_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_recent_manager_error_get_type ());
			}
		}
	}
#endregion
}
