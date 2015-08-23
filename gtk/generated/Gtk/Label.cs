// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Label : Gtk.Misc {

		public Label (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_new(IntPtr str);

		public static Label New(string str)
		{
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			Label result = new Label (gtk_label_new(native_str));
			GLib.Marshaller.Free (native_str);
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_new_with_mnemonic(IntPtr str);

		public Label (string str) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Label)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("label");
				vals.Add (new GLib.Value (str));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			Raw = gtk_label_new_with_mnemonic(native_str);
			GLib.Marshaller.Free (native_str);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_label(IntPtr raw, IntPtr str);

		[GLib.Property ("label")]
		public string LabelProp {
			get  {
				IntPtr raw_ret = gtk_label_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_label_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_attributes(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_attributes(IntPtr raw, IntPtr attrs);

		[GLib.Property ("attributes")]
		public Pango.AttrList Attributes {
			get  {
				IntPtr raw_ret = gtk_label_get_attributes(Handle);
				Pango.AttrList ret = raw_ret == IntPtr.Zero ? null : (Pango.AttrList) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.AttrList), false);
				return ret;
			}
			set  {
				gtk_label_set_attributes(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_use_markup(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_use_markup(IntPtr raw, bool setting);

		[GLib.Property ("use-markup")]
		public bool UseMarkup {
			get  {
				bool raw_ret = gtk_label_get_use_markup(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_use_markup(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_use_underline(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_use_underline(IntPtr raw, bool setting);

		[GLib.Property ("use-underline")]
		public bool UseUnderline {
			get  {
				bool raw_ret = gtk_label_get_use_underline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_use_underline(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_label_get_justify(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_justify(IntPtr raw, int jtype);

		[GLib.Property ("justify")]
		public Gtk.Justification Justify {
			get  {
				int raw_ret = gtk_label_get_justify(Handle);
				Gtk.Justification ret = (Gtk.Justification) raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_justify(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_pattern(IntPtr raw, IntPtr pattern);

		[GLib.Property ("pattern")]
		public string Pattern {
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_label_set_pattern(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("wrap")]
		public bool Wrap {
			get {
				GLib.Value val = GetProperty ("wrap");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("wrap", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_label_get_line_wrap_mode(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_line_wrap_mode(IntPtr raw, int wrap_mode);

		[GLib.Property ("wrap-mode")]
		public Pango.WrapMode LineWrapMode {
			get  {
				int raw_ret = gtk_label_get_line_wrap_mode(Handle);
				Pango.WrapMode ret = (Pango.WrapMode) raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_line_wrap_mode(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_selectable(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_selectable(IntPtr raw, bool setting);

		[GLib.Property ("selectable")]
		public bool Selectable {
			get  {
				bool raw_ret = gtk_label_get_selectable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_selectable(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_label_get_mnemonic_keyval(IntPtr raw);

		[GLib.Property ("mnemonic-keyval")]
		public uint MnemonicKeyval {
			get  {
				uint raw_ret = gtk_label_get_mnemonic_keyval(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_mnemonic_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_mnemonic_widget(IntPtr raw, IntPtr widget);

		[GLib.Property ("mnemonic-widget")]
		public Gtk.Widget MnemonicWidget {
			get  {
				IntPtr raw_ret = gtk_label_get_mnemonic_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_label_set_mnemonic_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("cursor-position")]
		public int CursorPosition {
			get {
				GLib.Value val = GetProperty ("cursor-position");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("selection-bound")]
		public int SelectionBound {
			get {
				GLib.Value val = GetProperty ("selection-bound");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_label_get_ellipsize(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_ellipsize(IntPtr raw, int mode);

		[GLib.Property ("ellipsize")]
		public Pango.EllipsizeMode Ellipsize {
			get  {
				int raw_ret = gtk_label_get_ellipsize(Handle);
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_ellipsize(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_label_get_width_chars(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_width_chars(IntPtr raw, int n_chars);

		[GLib.Property ("width-chars")]
		public int WidthChars {
			get  {
				int raw_ret = gtk_label_get_width_chars(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_width_chars(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_single_line_mode(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_single_line_mode(IntPtr raw, bool single_line_mode);

		[GLib.Property ("single-line-mode")]
		public bool SingleLineMode {
			get  {
				bool raw_ret = gtk_label_get_single_line_mode(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_single_line_mode(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_label_get_angle(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_angle(IntPtr raw, double angle);

		[GLib.Property ("angle")]
		public double Angle {
			get  {
				double raw_ret = gtk_label_get_angle(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_angle(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_label_get_max_width_chars(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_max_width_chars(IntPtr raw, int n_chars);

		[GLib.Property ("max-width-chars")]
		public int MaxWidthChars {
			get  {
				int raw_ret = gtk_label_get_max_width_chars(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_max_width_chars(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_track_visited_links(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_track_visited_links(IntPtr raw, bool track_links);

		[GLib.Property ("track-visited-links")]
		public bool TrackVisitedLinks {
			get  {
				bool raw_ret = gtk_label_get_track_visited_links(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_label_set_track_visited_links(Handle, value);
			}
		}

		[GLib.Signal("copy-clipboard")]
		public event System.EventHandler CopyClipboard {
			add {
				this.AddSignalHandler ("copy-clipboard", value);
			}
			remove {
				this.RemoveSignalHandler ("copy-clipboard", value);
			}
		}

		[GLib.Signal("activate-link")]
		public event Gtk.ActivateLinkHandler ActivateLink {
			add {
				this.AddSignalHandler ("activate-link", value, typeof (Gtk.ActivateLinkArgs));
			}
			remove {
				this.RemoveSignalHandler ("activate-link", value);
			}
		}

		[GLib.Signal("populate-popup")]
		public event Gtk.PopulatePopupHandler PopulatePopup {
			add {
				this.AddSignalHandler ("populate-popup", value, typeof (Gtk.PopulatePopupArgs));
			}
			remove {
				this.RemoveSignalHandler ("populate-popup", value);
			}
		}

		[GLib.Signal("move-cursor")]
		public event Gtk.MoveCursorHandler MoveCursor {
			add {
				this.AddSignalHandler ("move-cursor", value, typeof (Gtk.MoveCursorArgs));
			}
			remove {
				this.RemoveSignalHandler ("move-cursor", value);
			}
		}

		[GLib.Signal("activate-current-link")]
		public event System.EventHandler ActivateCurrentLink {
			add {
				this.AddSignalHandler ("activate-current-link", value);
			}
			remove {
				this.RemoveSignalHandler ("activate-current-link", value);
			}
		}

		static ActivateCurrentLinkNativeDelegate ActivateCurrentLink_cb_delegate;
		static ActivateCurrentLinkNativeDelegate ActivateCurrentLinkVMCallback {
			get {
				if (ActivateCurrentLink_cb_delegate == null)
					ActivateCurrentLink_cb_delegate = new ActivateCurrentLinkNativeDelegate (ActivateCurrentLink_cb);
				return ActivateCurrentLink_cb_delegate;
			}
		}

		static void OverrideActivateCurrentLink (GLib.GType gtype)
		{
			OverrideActivateCurrentLink (gtype, ActivateCurrentLinkVMCallback);
		}

		static void OverrideActivateCurrentLink (GLib.GType gtype, ActivateCurrentLinkNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "activate-current-link", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateCurrentLinkNativeDelegate (IntPtr inst);

		static void ActivateCurrentLink_cb (IntPtr inst)
		{
			try {
				Label __obj = GLib.Object.GetObject (inst, false) as Label;
				__obj.OnActivateCurrentLink ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Label), ConnectionMethod="OverrideActivateCurrentLink")]
		protected virtual void OnActivateCurrentLink ()
		{
			InternalActivateCurrentLink ();
		}

		private void InternalActivateCurrentLink ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static MoveCursorNativeDelegate MoveCursor_cb_delegate;
		static MoveCursorNativeDelegate MoveCursorVMCallback {
			get {
				if (MoveCursor_cb_delegate == null)
					MoveCursor_cb_delegate = new MoveCursorNativeDelegate (MoveCursor_cb);
				return MoveCursor_cb_delegate;
			}
		}

		static void OverrideMoveCursor (GLib.GType gtype)
		{
			OverrideMoveCursor (gtype, MoveCursorVMCallback);
		}

		static void OverrideMoveCursor (GLib.GType gtype, MoveCursorNativeDelegate callback)
		{
			GtkLabelClass class_iface = GetClassStruct (gtype, false);
			class_iface.MoveCursor = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MoveCursorNativeDelegate (IntPtr inst, int step, int count, bool extend_selection);

		static void MoveCursor_cb (IntPtr inst, int step, int count, bool extend_selection)
		{
			try {
				Label __obj = GLib.Object.GetObject (inst, false) as Label;
				__obj.OnMoveCursor ((Gtk.MovementStep) step, count, extend_selection);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Label), ConnectionMethod="OverrideMoveCursor")]
		protected virtual void OnMoveCursor (Gtk.MovementStep step, int count, bool extend_selection)
		{
			InternalMoveCursor (step, count, extend_selection);
		}

		private void InternalMoveCursor (Gtk.MovementStep step, int count, bool extend_selection)
		{
			MoveCursorNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).MoveCursor;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) step, count, extend_selection);
		}

		static CopyClipboardNativeDelegate CopyClipboard_cb_delegate;
		static CopyClipboardNativeDelegate CopyClipboardVMCallback {
			get {
				if (CopyClipboard_cb_delegate == null)
					CopyClipboard_cb_delegate = new CopyClipboardNativeDelegate (CopyClipboard_cb);
				return CopyClipboard_cb_delegate;
			}
		}

		static void OverrideCopyClipboard (GLib.GType gtype)
		{
			OverrideCopyClipboard (gtype, CopyClipboardVMCallback);
		}

		static void OverrideCopyClipboard (GLib.GType gtype, CopyClipboardNativeDelegate callback)
		{
			GtkLabelClass class_iface = GetClassStruct (gtype, false);
			class_iface.CopyClipboard = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CopyClipboardNativeDelegate (IntPtr inst);

		static void CopyClipboard_cb (IntPtr inst)
		{
			try {
				Label __obj = GLib.Object.GetObject (inst, false) as Label;
				__obj.OnCopyClipboard ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Label), ConnectionMethod="OverrideCopyClipboard")]
		protected virtual void OnCopyClipboard ()
		{
			InternalCopyClipboard ();
		}

		private void InternalCopyClipboard ()
		{
			CopyClipboardNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CopyClipboard;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static PopulatePopupNativeDelegate PopulatePopup_cb_delegate;
		static PopulatePopupNativeDelegate PopulatePopupVMCallback {
			get {
				if (PopulatePopup_cb_delegate == null)
					PopulatePopup_cb_delegate = new PopulatePopupNativeDelegate (PopulatePopup_cb);
				return PopulatePopup_cb_delegate;
			}
		}

		static void OverridePopulatePopup (GLib.GType gtype)
		{
			OverridePopulatePopup (gtype, PopulatePopupVMCallback);
		}

		static void OverridePopulatePopup (GLib.GType gtype, PopulatePopupNativeDelegate callback)
		{
			GtkLabelClass class_iface = GetClassStruct (gtype, false);
			class_iface.PopulatePopup = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PopulatePopupNativeDelegate (IntPtr inst, IntPtr menu);

		static void PopulatePopup_cb (IntPtr inst, IntPtr menu)
		{
			try {
				Label __obj = GLib.Object.GetObject (inst, false) as Label;
				__obj.OnPopulatePopup (GLib.Object.GetObject(menu) as Gtk.Menu);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Label), ConnectionMethod="OverridePopulatePopup")]
		protected virtual void OnPopulatePopup (Gtk.Menu menu)
		{
			InternalPopulatePopup (menu);
		}

		private void InternalPopulatePopup (Gtk.Menu menu)
		{
			PopulatePopupNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).PopulatePopup;
			if (unmanaged == null) return;

			unmanaged (this.Handle, menu == null ? IntPtr.Zero : menu.Handle);
		}

		static ActivateLinkNativeDelegate ActivateLink_cb_delegate;
		static ActivateLinkNativeDelegate ActivateLinkVMCallback {
			get {
				if (ActivateLink_cb_delegate == null)
					ActivateLink_cb_delegate = new ActivateLinkNativeDelegate (ActivateLink_cb);
				return ActivateLink_cb_delegate;
			}
		}

		static void OverrideActivateLink (GLib.GType gtype)
		{
			OverrideActivateLink (gtype, ActivateLinkVMCallback);
		}

		static void OverrideActivateLink (GLib.GType gtype, ActivateLinkNativeDelegate callback)
		{
			GtkLabelClass class_iface = GetClassStruct (gtype, false);
			class_iface.ActivateLink = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ActivateLinkNativeDelegate (IntPtr inst, IntPtr uri);

		static bool ActivateLink_cb (IntPtr inst, IntPtr uri)
		{
			try {
				Label __obj = GLib.Object.GetObject (inst, false) as Label;
				bool __result;
				__result = __obj.OnActivateLink (GLib.Marshaller.Utf8PtrToString (uri));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Label), ConnectionMethod="OverrideActivateLink")]
		protected virtual bool OnActivateLink (string uri)
		{
			return InternalActivateLink (uri);
		}

		private bool InternalActivateLink (string uri)
		{
			ActivateLinkNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ActivateLink;
			if (unmanaged == null) return false;

			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool __result = unmanaged (this.Handle, native_uri);
			GLib.Marshaller.Free (native_uri);
			return __result;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkLabelClass {
			public MoveCursorNativeDelegate MoveCursor;
			public CopyClipboardNativeDelegate CopyClipboard;
			public PopulatePopupNativeDelegate PopulatePopup;
			public ActivateLinkNativeDelegate ActivateLink;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
			IntPtr GtkReserved5;
			IntPtr GtkReserved6;
			IntPtr GtkReserved7;
			IntPtr GtkReserved8;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Misc)).GetClassSize ();
		static Dictionary<GLib.GType, GtkLabelClass> class_structs;

		static GtkLabelClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkLabelClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkLabelClass class_struct = (GtkLabelClass) Marshal.PtrToStructure (class_ptr, typeof (GtkLabelClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkLabelClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_current_uri(IntPtr raw);

		public string CurrentUri { 
			get {
				IntPtr raw_ret = gtk_label_get_current_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_layout(IntPtr raw);

		public Pango.Layout Layout { 
			get {
				IntPtr raw_ret = gtk_label_get_layout(Handle);
				Pango.Layout ret = GLib.Object.GetObject(raw_ret) as Pango.Layout;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_get_layout_offsets(IntPtr raw, out int x, out int y);

		public void GetLayoutOffsets(out int x, out int y) {
			gtk_label_get_layout_offsets(Handle, out x, out y);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_line_wrap(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_line_wrap(IntPtr raw, bool wrap);

		public bool LineWrap { 
			get {
				bool raw_ret = gtk_label_get_line_wrap(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_label_set_line_wrap(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_label_get_selection_bounds(IntPtr raw, out int start, out int end);

		public bool GetSelectionBounds(out int start, out int end) {
			bool raw_ret = gtk_label_get_selection_bounds(Handle, out start, out end);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_text(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_text(IntPtr raw, IntPtr str);

		public string Text { 
			get {
				IntPtr raw_ret = gtk_label_get_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_label_set_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_label_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_label_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_select_region(IntPtr raw, int start_offset, int end_offset);

		public void SelectRegion(int start_offset, int end_offset) {
			gtk_label_select_region(Handle, start_offset, end_offset);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_markup(IntPtr raw, IntPtr str);

		public string Markup { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_label_set_markup(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_markup_with_mnemonic(IntPtr raw, IntPtr str);

		public string MarkupWithMnemonic { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_label_set_markup_with_mnemonic(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_label_set_text_with_mnemonic(IntPtr raw, IntPtr str);

		public string TextWithMnemonic { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_label_set_text_with_mnemonic(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

#endregion
	}
}
