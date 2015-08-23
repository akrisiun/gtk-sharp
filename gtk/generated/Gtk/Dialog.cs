// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Dialog : Gtk.Window {

		public Dialog (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_dialog_new();

		public Dialog () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Dialog)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_dialog_new();
		}

		[GLib.Signal("close")]
		public event System.EventHandler Close {
			add {
				this.AddSignalHandler ("close", value);
			}
			remove {
				this.RemoveSignalHandler ("close", value);
			}
		}

		[GLib.Signal("response")]
		public event Gtk.ResponseHandler Response {
			add {
				this.AddSignalHandler ("response", value, typeof (Gtk.ResponseArgs));
			}
			remove {
				this.RemoveSignalHandler ("response", value);
			}
		}

		static ResponseNativeDelegate Response_cb_delegate;
		static ResponseNativeDelegate ResponseVMCallback {
			get {
				if (Response_cb_delegate == null)
					Response_cb_delegate = new ResponseNativeDelegate (Response_cb);
				return Response_cb_delegate;
			}
		}

		static void OverrideResponse (GLib.GType gtype)
		{
			OverrideResponse (gtype, ResponseVMCallback);
		}

		static void OverrideResponse (GLib.GType gtype, ResponseNativeDelegate callback)
		{
			GtkDialogClass class_iface = GetClassStruct (gtype, false);
			class_iface.Response = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ResponseNativeDelegate (IntPtr inst, int response_id);

		static void Response_cb (IntPtr inst, int response_id)
		{
			try {
				Dialog __obj = GLib.Object.GetObject (inst, false) as Dialog;
				__obj.OnResponse ((Gtk.ResponseType) response_id);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Dialog), ConnectionMethod="OverrideResponse")]
		protected virtual void OnResponse (Gtk.ResponseType response_id)
		{
			InternalResponse (response_id);
		}

		private void InternalResponse (Gtk.ResponseType response_id)
		{
			ResponseNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Response;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) response_id);
		}

		static CloseNativeDelegate Close_cb_delegate;
		static CloseNativeDelegate CloseVMCallback {
			get {
				if (Close_cb_delegate == null)
					Close_cb_delegate = new CloseNativeDelegate (Close_cb);
				return Close_cb_delegate;
			}
		}

		static void OverrideClose (GLib.GType gtype)
		{
			OverrideClose (gtype, CloseVMCallback);
		}

		static void OverrideClose (GLib.GType gtype, CloseNativeDelegate callback)
		{
			GtkDialogClass class_iface = GetClassStruct (gtype, false);
			class_iface.Close = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseNativeDelegate (IntPtr inst);

		static void Close_cb (IntPtr inst)
		{
			try {
				Dialog __obj = GLib.Object.GetObject (inst, false) as Dialog;
				__obj.OnClose ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Dialog), ConnectionMethod="OverrideClose")]
		protected virtual void OnClose ()
		{
			InternalClose ();
		}

		private void InternalClose ()
		{
			CloseNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Close;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkDialogClass {
			public ResponseNativeDelegate Response;
			public CloseNativeDelegate Close;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Window)).GetClassSize ();
		static Dictionary<GLib.GType, GtkDialogClass> class_structs;

		static GtkDialogClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkDialogClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkDialogClass class_struct = (GtkDialogClass) Marshal.PtrToStructure (class_ptr, typeof (GtkDialogClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkDialogClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_dialog_add_action_widget(IntPtr raw, IntPtr child, int response_id);

		public void AddActionWidget(Gtk.Widget child, int response_id) {
			gtk_dialog_add_action_widget(Handle, child == null ? IntPtr.Zero : child.Handle, response_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_dialog_add_button(IntPtr raw, IntPtr button_text, int response_id);

		public Gtk.Widget AddButton(string button_text, int response_id) {
			IntPtr native_button_text = GLib.Marshaller.StringToPtrGStrdup (button_text);
			IntPtr raw_ret = gtk_dialog_add_button(Handle, native_button_text, response_id);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			GLib.Marshaller.Free (native_button_text);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_dialog_get_action_area(IntPtr raw);

		public Gtk.ButtonBox ActionArea { 
			get {
				IntPtr raw_ret = gtk_dialog_get_action_area(Handle);
				Gtk.ButtonBox ret = GLib.Object.GetObject(raw_ret) as Gtk.ButtonBox;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_dialog_get_content_area(IntPtr raw);

		public Gtk.Box ContentArea { 
			get {
				IntPtr raw_ret = gtk_dialog_get_content_area(Handle);
				Gtk.Box ret = GLib.Object.GetObject(raw_ret) as Gtk.Box;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_dialog_get_response_for_widget(IntPtr raw, IntPtr widget);

		public int GetResponseForWidget(Gtk.Widget widget) {
			int raw_ret = gtk_dialog_get_response_for_widget(Handle, widget == null ? IntPtr.Zero : widget.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_dialog_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_dialog_get_widget_for_response(IntPtr raw, int response_id);

		public Gtk.Widget GetWidgetForResponse(int response_id) {
			IntPtr raw_ret = gtk_dialog_get_widget_for_response(Handle, response_id);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_dialog_response(IntPtr raw, int response_id);

		public void Respond(int response_id) {
			gtk_dialog_response(Handle, response_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_dialog_run(IntPtr raw);

		public int Run() {
			int raw_ret = gtk_dialog_run(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_dialog_set_alternative_button_order_from_array(IntPtr raw, int n_params, int[] new_order);

		public int[] AlternativeButtonOrder { 
			set {
				gtk_dialog_set_alternative_button_order_from_array(Handle, (value == null ? 0 : value.Length), value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_dialog_set_default_response(IntPtr raw, int response_id);

		public Gtk.ResponseType DefaultResponse { 
			set {
				gtk_dialog_set_default_response(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_dialog_set_response_sensitive(IntPtr raw, int response_id, bool setting);

		public void SetResponseSensitive(Gtk.ResponseType response_id, bool setting) {
			gtk_dialog_set_response_sensitive(Handle, (int) response_id, setting);
		}

#endregion
	}
}
