// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class HSV : Gtk.Widget {

		public HSV (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_hsv_new();

		public HSV () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HSV)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_hsv_new();
		}

		[GLib.Signal("move")]
		public event Gtk.MoveHandler Move {
			add {
				this.AddSignalHandler ("move", value, typeof (Gtk.MoveArgs));
			}
			remove {
				this.RemoveSignalHandler ("move", value);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			GtkHSVClass class_iface = GetClassStruct (gtype, false);
			class_iface.Changed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				HSV __obj = GLib.Object.GetObject (inst, false) as HSV;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.HSV), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Changed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static MoveNativeDelegate Move_cb_delegate;
		static MoveNativeDelegate MoveVMCallback {
			get {
				if (Move_cb_delegate == null)
					Move_cb_delegate = new MoveNativeDelegate (Move_cb);
				return Move_cb_delegate;
			}
		}

		static void OverrideMove (GLib.GType gtype)
		{
			OverrideMove (gtype, MoveVMCallback);
		}

		static void OverrideMove (GLib.GType gtype, MoveNativeDelegate callback)
		{
			GtkHSVClass class_iface = GetClassStruct (gtype, false);
			class_iface.Move = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MoveNativeDelegate (IntPtr inst, int type);

		static void Move_cb (IntPtr inst, int type)
		{
			try {
				HSV __obj = GLib.Object.GetObject (inst, false) as HSV;
				__obj.OnMove ((Gtk.DirectionType) type);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.HSV), ConnectionMethod="OverrideMove")]
		protected virtual void OnMove (Gtk.DirectionType type)
		{
			InternalMove (type);
		}

		private void InternalMove (Gtk.DirectionType type)
		{
			MoveNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Move;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) type);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkHSVClass {
			public ChangedNativeDelegate Changed;
			public MoveNativeDelegate Move;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Widget)).GetClassSize ();
		static Dictionary<GLib.GType, GtkHSVClass> class_structs;

		static GtkHSVClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkHSVClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkHSVClass class_struct = (GtkHSVClass) Marshal.PtrToStructure (class_ptr, typeof (GtkHSVClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkHSVClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_hsv_get_color(IntPtr raw, out double h, out double s, out double v);

		public void GetColor(out double h, out double s, out double v) {
			gtk_hsv_get_color(Handle, out h, out s, out v);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_hsv_get_metrics(IntPtr raw, out int size, out int ring_width);

		public void GetMetrics(out int size, out int ring_width) {
			gtk_hsv_get_metrics(Handle, out size, out ring_width);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_hsv_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_hsv_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_hsv_is_adjusting(IntPtr raw);

		public bool IsAdjusting { 
			get {
				bool raw_ret = gtk_hsv_is_adjusting(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_hsv_set_color(IntPtr raw, double h, double s, double v);

		public void SetColor(double h, double s, double v) {
			gtk_hsv_set_color(Handle, h, s, v);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_hsv_set_metrics(IntPtr raw, int size, int ring_width);

		public void SetMetrics(int size, int ring_width) {
			gtk_hsv_set_metrics(Handle, size, ring_width);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_hsv_to_rgb(double h, double s, double v, out double r, out double g, out double b);

		public static void ToRgb(double h, double s, double v, out double r, out double g, out double b) {
			gtk_hsv_to_rgb(h, s, v, out r, out g, out b);
		}

#endregion
	}
}