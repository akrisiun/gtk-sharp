// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CellRendererSpin : Gtk.CellRendererText {

		public CellRendererSpin (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_spin_new();

		public CellRendererSpin () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellRendererSpin)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_cell_renderer_spin_new();
		}

		[GLib.Property ("adjustment")]
		public Gtk.Adjustment Adjustment {
			get {
				GLib.Value val = GetProperty ("adjustment");
				Gtk.Adjustment ret = (Gtk.Adjustment) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("adjustment", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("climb-rate")]
		public double ClimbRate {
			get {
				GLib.Value val = GetProperty ("climb-rate");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("climb-rate", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("digits")]
		public uint Digits {
			get {
				GLib.Value val = GetProperty ("digits");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("digits", val);
				val.Dispose ();
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkCellRendererSpinClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.CellRendererText)).GetClassSize ();
		static Dictionary<GLib.GType, GtkCellRendererSpinClass> class_structs;

		static GtkCellRendererSpinClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkCellRendererSpinClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkCellRendererSpinClass class_struct = (GtkCellRendererSpinClass) Marshal.PtrToStructure (class_ptr, typeof (GtkCellRendererSpinClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkCellRendererSpinClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_spin_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_cell_renderer_spin_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}