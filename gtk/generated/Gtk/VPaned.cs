// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VPaned : Gtk.Paned {

		public VPaned (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vpaned_new();

		public VPaned () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (VPaned)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_vpaned_new();
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkVPanedClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Paned)).GetClassSize ();
		static Dictionary<GLib.GType, GtkVPanedClass> class_structs;

		static GtkVPanedClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkVPanedClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkVPanedClass class_struct = (GtkVPanedClass) Marshal.PtrToStructure (class_ptr, typeof (GtkVPanedClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkVPanedClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vpaned_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_vpaned_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}