// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RecentAction : Gtk.Action, Gtk.IRecentChooser {

		public RecentAction (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_action_new(IntPtr name, IntPtr label, IntPtr tooltip, IntPtr stock_id);

		public RecentAction (string name, string label, string tooltip, string stock_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RecentAction)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				names.Add ("tooltip");
				vals.Add (new GLib.Value (tooltip));
				names.Add ("stock_id");
				vals.Add (new GLib.Value (stock_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			IntPtr native_tooltip = GLib.Marshaller.StringToPtrGStrdup (tooltip);
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_recent_action_new(native_name, native_label, native_tooltip, native_stock_id);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_label);
			GLib.Marshaller.Free (native_tooltip);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_action_new_for_manager(IntPtr name, IntPtr label, IntPtr tooltip, IntPtr stock_id, IntPtr manager);

		public RecentAction (string name, string label, string tooltip, string stock_id, Gtk.RecentManager manager) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RecentAction)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			IntPtr native_tooltip = GLib.Marshaller.StringToPtrGStrdup (tooltip);
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_recent_action_new_for_manager(native_name, native_label, native_tooltip, native_stock_id, manager == null ? IntPtr.Zero : manager.Handle);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_label);
			GLib.Marshaller.Free (native_tooltip);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_action_get_show_numbers(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_action_set_show_numbers(IntPtr raw, bool show_numbers);

		[GLib.Property ("show-numbers")]
		public bool ShowNumbers {
			get  {
				bool raw_ret = gtk_recent_action_get_show_numbers(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_recent_action_set_show_numbers(Handle, value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkRecentActionClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Action)).GetClassSize ();
		static Dictionary<GLib.GType, GtkRecentActionClass> class_structs;

		static GtkRecentActionClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkRecentActionClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkRecentActionClass class_struct = (GtkRecentActionClass) Marshal.PtrToStructure (class_ptr, typeof (GtkRecentActionClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkRecentActionClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_action_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_recent_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_add_filter(IntPtr raw, IntPtr filter);

		public void AddFilter(Gtk.RecentFilter filter) {
			gtk_recent_chooser_add_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_current_item(IntPtr raw);

		public Gtk.RecentInfo CurrentItem { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_current_item(Handle);
				Gtk.RecentInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.RecentInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.RecentInfo), false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_current_uri(IntPtr raw);

		public string CurrentUri { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_current_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_filter(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_filter(IntPtr raw, IntPtr filter);

		public Gtk.RecentFilter Filter { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_filter(Handle);
				Gtk.RecentFilter ret = GLib.Object.GetObject(raw_ret) as Gtk.RecentFilter;
				return ret;
			}
			set {
				gtk_recent_chooser_set_filter(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_items(IntPtr raw);

		public Gtk.RecentInfo[] Items { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_items(Handle);
				Gtk.RecentInfo[] ret = (Gtk.RecentInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gtk.RecentInfo));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_recent_chooser_get_limit(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_limit(IntPtr raw, int limit);

		public int Limit { 
			get {
				int raw_ret = gtk_recent_chooser_get_limit(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_limit(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_local_only(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_local_only(IntPtr raw, bool local_only);

		public bool LocalOnly { 
			get {
				bool raw_ret = gtk_recent_chooser_get_local_only(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_local_only(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_select_multiple(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_select_multiple(IntPtr raw, bool select_multiple);

		public bool SelectMultiple { 
			get {
				bool raw_ret = gtk_recent_chooser_get_select_multiple(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_select_multiple(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_icons(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_icons(IntPtr raw, bool show_icons);

		public bool ShowIcons { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_icons(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_icons(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_not_found(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_not_found(IntPtr raw, bool show_not_found);

		public bool ShowNotFound { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_not_found(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_not_found(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_private(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_private(IntPtr raw, bool show_private);

		public bool ShowPrivate { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_private(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_private(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_tips(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_tips(IntPtr raw, bool show_tips);

		public bool ShowTips { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_tips(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_tips(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_recent_chooser_get_sort_type(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_sort_type(IntPtr raw, int sort_type);

		public Gtk.RecentSortType SortType { 
			get {
				int raw_ret = gtk_recent_chooser_get_sort_type(Handle);
				Gtk.RecentSortType ret = (Gtk.RecentSortType) raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_sort_type(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_uris(IntPtr raw, out UIntPtr length);

		public string[] GetUris(out ulong length) {
			UIntPtr native_length;
			IntPtr raw_ret = gtk_recent_chooser_get_uris(Handle, out native_length);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			length = (ulong) native_length;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_list_filters(IntPtr raw);

		public Gtk.RecentFilter[] Filters { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_list_filters(Handle);
				Gtk.RecentFilter[] ret = (Gtk.RecentFilter[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, false, typeof(Gtk.RecentFilter));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_remove_filter(IntPtr raw, IntPtr filter);

		public void RemoveFilter(Gtk.RecentFilter filter) {
			gtk_recent_chooser_remove_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_select_all(IntPtr raw);

		public void SelectAll() {
			gtk_recent_chooser_select_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_select_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool SelectUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_chooser_select_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_set_current_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool SetCurrentUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_chooser_set_current_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_sort_func(IntPtr raw, GtkSharp.RecentSortFuncNative sort_func, IntPtr sort_data, GLib.DestroyNotify data_destroy);

		public Gtk.RecentSortFunc SortFunc { 
			set {
				GtkSharp.RecentSortFuncWrapper value_wrapper = new GtkSharp.RecentSortFuncWrapper (value);
				IntPtr sort_data;
				GLib.DestroyNotify data_destroy;
				if (value == null) {
					sort_data = IntPtr.Zero;
					data_destroy = null;
				} else {
					sort_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					data_destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_recent_chooser_set_sort_func(Handle, value_wrapper.NativeDelegate, sort_data, data_destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_unselect_all(IntPtr raw);

		public void UnselectAll() {
			gtk_recent_chooser_unselect_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_unselect_uri(IntPtr raw, IntPtr uri);

		public void UnselectUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			gtk_recent_chooser_unselect_uri(Handle, native_uri);
			GLib.Marshaller.Free (native_uri);
		}

#endregion
	}
}
