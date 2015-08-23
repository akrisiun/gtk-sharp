// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PageSetup : GLib.Object {

		public PageSetup (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_page_setup_new();

		public PageSetup () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_page_setup_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gtk_page_setup_new_from_file(IntPtr file_name, out IntPtr error);

		public unsafe PageSetup (string file_name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_file_name = GLib.Marshaller.StringToFilenamePtr (file_name);
			IntPtr error = IntPtr.Zero;
			Raw = gtk_page_setup_new_from_file(native_file_name, out error);
			GLib.Marshaller.Free (native_file_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gtk_page_setup_new_from_key_file(IntPtr key_file, IntPtr group_name, out IntPtr error);

		public unsafe PageSetup (GLib.KeyFile key_file, string group_name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr error = IntPtr.Zero;
			Raw = gtk_page_setup_new_from_key_file(key_file == null ? IntPtr.Zero : key_file.Handle, native_group_name, out error);
			GLib.Marshaller.Free (native_group_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkPageSetupClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkPageSetupClass> class_structs;

		static GtkPageSetupClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkPageSetupClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkPageSetupClass class_struct = (GtkPageSetupClass) Marshal.PtrToStructure (class_ptr, typeof (GtkPageSetupClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkPageSetupClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_page_setup_copy(IntPtr raw);

		public Gtk.PageSetup Copy() {
			IntPtr raw_ret = gtk_page_setup_copy(Handle);
			Gtk.PageSetup ret = GLib.Object.GetObject(raw_ret, true) as Gtk.PageSetup;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_bottom_margin(IntPtr raw, int unit);

		public double GetBottomMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_bottom_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_left_margin(IntPtr raw, int unit);

		public double GetLeftMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_left_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_page_setup_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_orientation(IntPtr raw, int orientation);

		public Gtk.PageOrientation Orientation { 
			get {
				int raw_ret = gtk_page_setup_get_orientation(Handle);
				Gtk.PageOrientation ret = (Gtk.PageOrientation) raw_ret;
				return ret;
			}
			set {
				gtk_page_setup_set_orientation(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_page_height(IntPtr raw, int unit);

		public double GetPageHeight(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_page_height(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_page_width(IntPtr raw, int unit);

		public double GetPageWidth(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_page_width(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_paper_height(IntPtr raw, int unit);

		public double GetPaperHeight(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_paper_height(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_page_setup_get_paper_size(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_paper_size(IntPtr raw, IntPtr size);

		public Gtk.PaperSize PaperSize { 
			get {
				IntPtr raw_ret = gtk_page_setup_get_paper_size(Handle);
				Gtk.PaperSize ret = raw_ret == IntPtr.Zero ? null : (Gtk.PaperSize) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.PaperSize), false);
				return ret;
			}
			set {
				gtk_page_setup_set_paper_size(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_paper_width(IntPtr raw, int unit);

		public double GetPaperWidth(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_paper_width(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_right_margin(IntPtr raw, int unit);

		public double GetRightMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_right_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_page_setup_get_top_margin(IntPtr raw, int unit);

		public double GetTopMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_top_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_page_setup_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_page_setup_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gtk_page_setup_load_file(IntPtr raw, IntPtr file_name, out IntPtr error);

		public unsafe bool LoadFile(string file_name) {
			IntPtr native_file_name = GLib.Marshaller.StringToPtrGStrdup (file_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_page_setup_load_file(Handle, native_file_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gtk_page_setup_load_key_file(IntPtr raw, IntPtr key_file, IntPtr group_name, out IntPtr error);

		public unsafe bool LoadKeyFile(GLib.KeyFile key_file, string group_name) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_page_setup_load_key_file(Handle, key_file == null ? IntPtr.Zero : key_file.Handle, native_group_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_bottom_margin(IntPtr raw, double margin, int unit);

		public void SetBottomMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_bottom_margin(Handle, margin, (int) unit);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_left_margin(IntPtr raw, double margin, int unit);

		public void SetLeftMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_left_margin(Handle, margin, (int) unit);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_paper_size_and_default_margins(IntPtr raw, IntPtr size);

		public Gtk.PaperSize PaperSizeAndDefaultMargins { 
			set {
				gtk_page_setup_set_paper_size_and_default_margins(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_right_margin(IntPtr raw, double margin, int unit);

		public void SetRightMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_right_margin(Handle, margin, (int) unit);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_set_top_margin(IntPtr raw, double margin, int unit);

		public void SetTopMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_top_margin(Handle, margin, (int) unit);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gtk_page_setup_to_file(IntPtr raw, IntPtr file_name, out IntPtr error);

		public unsafe bool ToFile(string file_name) {
			IntPtr native_file_name = GLib.Marshaller.StringToFilenamePtr (file_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_page_setup_to_file(Handle, native_file_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_page_setup_to_key_file(IntPtr raw, IntPtr key_file, IntPtr group_name);

		public void ToKeyFile(GLib.KeyFile key_file, string group_name) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			gtk_page_setup_to_key_file(Handle, key_file == null ? IntPtr.Zero : key_file.Handle, native_group_name);
			GLib.Marshaller.Free (native_group_name);
		}

#endregion
	}
}
