// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontButton : Gtk.Button {

		public FontButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_new();

		public FontButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_font_button_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_new_with_font(IntPtr fontname);

		public FontButton (string fontname) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontButton)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			Raw = gtk_font_button_new_with_font(native_fontname);
			GLib.Marshaller.Free (native_fontname);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_get_title(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_title(IntPtr raw, IntPtr title);

		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_font_button_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_button_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_get_font_name(IntPtr raw);

		[GLib.Property ("font-name")]
		public string FontName {
			get  {
				IntPtr raw_ret = gtk_font_button_get_font_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font-name", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_use_font(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_use_font(IntPtr raw, bool use_font);

		[GLib.Property ("use-font")]
		public bool UseFont {
			get  {
				bool raw_ret = gtk_font_button_get_use_font(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_use_font(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_use_size(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_use_size(IntPtr raw, bool use_size);

		[GLib.Property ("use-size")]
		public bool UseSize {
			get  {
				bool raw_ret = gtk_font_button_get_use_size(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_use_size(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_show_style(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_show_style(IntPtr raw, bool show_style);

		[GLib.Property ("show-style")]
		public bool ShowStyle {
			get  {
				bool raw_ret = gtk_font_button_get_show_style(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_show_style(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_show_size(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_show_size(IntPtr raw, bool show_size);

		[GLib.Property ("show-size")]
		public bool ShowSize {
			get  {
				bool raw_ret = gtk_font_button_get_show_size(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_show_size(Handle, value);
			}
		}

		[GLib.Signal("font-set")]
		public event System.EventHandler FontSet {
			add {
				this.AddSignalHandler ("font-set", value);
			}
			remove {
				this.RemoveSignalHandler ("font-set", value);
			}
		}

		static FontSetNativeDelegate FontSet_cb_delegate;
		static FontSetNativeDelegate FontSetVMCallback {
			get {
				if (FontSet_cb_delegate == null)
					FontSet_cb_delegate = new FontSetNativeDelegate (FontSet_cb);
				return FontSet_cb_delegate;
			}
		}

		static void OverrideFontSet (GLib.GType gtype)
		{
			OverrideFontSet (gtype, FontSetVMCallback);
		}

		static void OverrideFontSet (GLib.GType gtype, FontSetNativeDelegate callback)
		{
			GtkFontButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.FontSet = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FontSetNativeDelegate (IntPtr inst);

		static void FontSet_cb (IntPtr inst)
		{
			try {
				FontButton __obj = GLib.Object.GetObject (inst, false) as FontButton;
				__obj.OnFontSet ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.FontButton), ConnectionMethod="OverrideFontSet")]
		protected virtual void OnFontSet ()
		{
			InternalFontSet ();
		}

		private void InternalFontSet ()
		{
			FontSetNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).FontSet;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkFontButtonClass {
			public FontSetNativeDelegate FontSet;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Button)).GetClassSize ();
		static Dictionary<GLib.GType, GtkFontButtonClass> class_structs;

		static GtkFontButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkFontButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkFontButtonClass class_struct = (GtkFontButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkFontButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkFontButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_set_font_name(IntPtr raw, IntPtr fontname);

		public bool SetFontName(string fontname) {
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_button_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
		}

#endregion
	}
}
