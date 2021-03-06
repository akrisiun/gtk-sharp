// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RemoteActionInfo : IEquatable<RemoteActionInfo> {

		public string Name;
		private IntPtr _parameter_type;
		public bool Enabled;
		private IntPtr _state;

		public static GLib.RemoteActionInfo Zero = new GLib.RemoteActionInfo ();

		public static GLib.RemoteActionInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GLib.RemoteActionInfo.Zero;
			return (GLib.RemoteActionInfo) Marshal.PtrToStructure (raw, typeof (GLib.RemoteActionInfo));
		}

		public bool Equals (RemoteActionInfo other)
		{
			return true && Name.Equals (other.Name) && _parameter_type.Equals (other._parameter_type) && Enabled.Equals (other.Enabled) && _state.Equals (other._state);
		}

		public override bool Equals (object other)
		{
			return other is RemoteActionInfo && Equals ((RemoteActionInfo) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Name.GetHashCode () ^ _parameter_type.GetHashCode () ^ Enabled.GetHashCode () ^ _state.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
