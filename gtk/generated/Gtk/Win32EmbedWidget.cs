// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Win32EmbedWidget : Gtk.Window {

		public Win32EmbedWidget (IntPtr raw) : base(raw) {}

		protected Win32EmbedWidget() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkWin32EmbedWidgetClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Window)).GetClassSize ();
		static Dictionary<GLib.GType, GtkWin32EmbedWidgetClass> class_structs;

		static GtkWin32EmbedWidgetClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkWin32EmbedWidgetClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkWin32EmbedWidgetClass class_struct = (GtkWin32EmbedWidgetClass) Marshal.PtrToStructure (class_ptr, typeof (GtkWin32EmbedWidgetClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkWin32EmbedWidgetClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_win32_embed_widget_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_win32_embed_widget_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
