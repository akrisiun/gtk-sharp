// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DBusAuthMechanismExternal : GLib.DBusAuthMechanism {

		public DBusAuthMechanismExternal (IntPtr raw) : base(raw) {}

		protected DBusAuthMechanismExternal() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GDBusAuthMechanismExternalClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.DBusAuthMechanism)).GetClassSize ();
		static Dictionary<GLib.GType, GDBusAuthMechanismExternalClass> class_structs;

		static GDBusAuthMechanismExternalClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GDBusAuthMechanismExternalClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GDBusAuthMechanismExternalClass class_struct = (GDBusAuthMechanismExternalClass) Marshal.PtrToStructure (class_ptr, typeof (GDBusAuthMechanismExternalClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GDBusAuthMechanismExternalClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

#endregion
	}
}
