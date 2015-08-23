// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Viewport : Gtk.Bin, Gtk.IScrollable {

		public Viewport (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_new(IntPtr hadjustment, IntPtr vadjustment);

		public Viewport (Gtk.Adjustment hadjustment, Gtk.Adjustment vadjustment) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Viewport)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (hadjustment != null) {
					names.Add ("hadjustment");
					vals.Add (new GLib.Value (hadjustment));
				}
				if (vadjustment != null) {
					names.Add ("vadjustment");
					vals.Add (new GLib.Value (vadjustment));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_viewport_new(hadjustment == null ? IntPtr.Zero : hadjustment.Handle, vadjustment == null ? IntPtr.Zero : vadjustment.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_viewport_get_shadow_type(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_viewport_set_shadow_type(IntPtr raw, int type);

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get  {
				int raw_ret = gtk_viewport_get_shadow_type(Handle);
				Gtk.ShadowType ret = (Gtk.ShadowType) raw_ret;
				return ret;
			}
			set  {
				gtk_viewport_set_shadow_type(Handle, (int) value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkViewportClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Bin)).GetClassSize ();
		static Dictionary<GLib.GType, GtkViewportClass> class_structs;

		static GtkViewportClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkViewportClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkViewportClass class_struct = (GtkViewportClass) Marshal.PtrToStructure (class_ptr, typeof (GtkViewportClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkViewportClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_get_bin_window(IntPtr raw);

		public Gdk.Window BinWindow { 
			get {
				IntPtr raw_ret = gtk_viewport_get_bin_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_viewport_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_viewport_get_view_window(IntPtr raw);

		public Gdk.Window ViewWindow { 
			get {
				IntPtr raw_ret = gtk_viewport_get_view_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_hadjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hadjustment(IntPtr raw, IntPtr hadjustment);

		[GLib.Property ("hadjustment")]
		public Gtk.Adjustment Hadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_hadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_hadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_vadjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vadjustment(IntPtr raw, IntPtr vadjustment);

		[GLib.Property ("vadjustment")]
		public Gtk.Adjustment Vadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_vadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_vadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_hscroll_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("hscroll-policy")]
		public Gtk.ScrollablePolicy HscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_hscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_hscroll_policy(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_vscroll_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("vscroll-policy")]
		public Gtk.ScrollablePolicy VscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_vscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_vscroll_policy(Handle, (int) value);
			}
		}

#endregion
	}
}
