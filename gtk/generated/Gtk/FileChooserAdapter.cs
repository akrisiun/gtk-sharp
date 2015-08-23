// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FileChooserAdapter : GLib.GInterfaceAdapter, Gtk.IFileChooser {

		GLib.Object implementor;

		public FileChooserAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_file_chooser_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IFileChooser GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IFileChooser GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj as IFileChooser == null)
				return new FileChooserAdapter (obj.Handle);
			else
				return obj as IFileChooser;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_file_chooser_get_action(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_action(IntPtr raw, int action);

		[GLib.Property ("action")]
		public Gtk.FileChooserAction Action {
			get  {
				int raw_ret = gtk_file_chooser_get_action(Handle);
				Gtk.FileChooserAction ret = (Gtk.FileChooserAction) raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_action(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_filter(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_filter(IntPtr raw, IntPtr filter);

		[GLib.Property ("filter")]
		public Gtk.FileFilter Filter {
			get  {
				IntPtr raw_ret = gtk_file_chooser_get_filter(Handle);
				Gtk.FileFilter ret = GLib.Object.GetObject(raw_ret) as Gtk.FileFilter;
				return ret;
			}
			set  {
				gtk_file_chooser_set_filter(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_local_only(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_local_only(IntPtr raw, bool local_only);

		[GLib.Property ("local-only")]
		public bool LocalOnly {
			get  {
				bool raw_ret = gtk_file_chooser_get_local_only(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_local_only(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_preview_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_preview_widget(IntPtr raw, IntPtr preview_widget);

		[GLib.Property ("preview-widget")]
		public Gtk.Widget PreviewWidget {
			get  {
				IntPtr raw_ret = gtk_file_chooser_get_preview_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_file_chooser_set_preview_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_preview_widget_active(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_preview_widget_active(IntPtr raw, bool active);

		[GLib.Property ("preview-widget-active")]
		public bool PreviewWidgetActive {
			get  {
				bool raw_ret = gtk_file_chooser_get_preview_widget_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_preview_widget_active(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_use_preview_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_use_preview_label(IntPtr raw, bool use_label);

		[GLib.Property ("use-preview-label")]
		public bool UsePreviewLabel {
			get  {
				bool raw_ret = gtk_file_chooser_get_use_preview_label(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_use_preview_label(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_extra_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_extra_widget(IntPtr raw, IntPtr extra_widget);

		[GLib.Property ("extra-widget")]
		public Gtk.Widget ExtraWidget {
			get  {
				IntPtr raw_ret = gtk_file_chooser_get_extra_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_file_chooser_set_extra_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_select_multiple(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_select_multiple(IntPtr raw, bool select_multiple);

		[GLib.Property ("select-multiple")]
		public bool SelectMultiple {
			get  {
				bool raw_ret = gtk_file_chooser_get_select_multiple(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_select_multiple(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_show_hidden(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_show_hidden(IntPtr raw, bool show_hidden);

		[GLib.Property ("show-hidden")]
		public bool ShowHidden {
			get  {
				bool raw_ret = gtk_file_chooser_get_show_hidden(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_show_hidden(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_do_overwrite_confirmation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_do_overwrite_confirmation(IntPtr raw, bool do_overwrite_confirmation);

		[GLib.Property ("do-overwrite-confirmation")]
		public bool DoOverwriteConfirmation {
			get  {
				bool raw_ret = gtk_file_chooser_get_do_overwrite_confirmation(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_do_overwrite_confirmation(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_get_create_folders(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_create_folders(IntPtr raw, bool create_folders);

		[GLib.Property ("create-folders")]
		public bool CreateFolders {
			get  {
				bool raw_ret = gtk_file_chooser_get_create_folders(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_file_chooser_set_create_folders(Handle, value);
			}
		}

		[GLib.Signal("selection-changed")]
		public event System.EventHandler SelectionChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("selection-changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("selection-changed", value);
			}
		}

		[GLib.Signal("confirm-overwrite")]
		public event Gtk.ConfirmOverwriteHandler ConfirmOverwrite {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("confirm-overwrite", value, typeof (Gtk.ConfirmOverwriteArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("confirm-overwrite", value);
			}
		}

		[GLib.Signal("file-activated")]
		public event System.EventHandler FileActivated {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("file-activated", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("file-activated", value);
			}
		}

		[GLib.Signal("update-preview")]
		public event System.EventHandler UpdatePreview {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("update-preview", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("update-preview", value);
			}
		}

		[GLib.Signal("current-folder-changed")]
		public event System.EventHandler CurrentFolderChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("current-folder-changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("current-folder-changed", value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_add_filter(IntPtr raw, IntPtr filter);

		public void AddFilter(Gtk.FileFilter filter) {
			gtk_file_chooser_add_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_add_shortcut_folder(IntPtr raw, IntPtr folder, out IntPtr error);

		public bool AddShortcutFolder(string folder) {
			IntPtr native_folder = GLib.Marshaller.StringToFilenamePtr (folder);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_file_chooser_add_shortcut_folder(Handle, native_folder, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_folder);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_add_shortcut_folder_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool AddShortcutFolderUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_file_chooser_add_shortcut_folder_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_file_chooser_error_quark();

		public static int ErrorQuark() {
			int raw_ret = gtk_file_chooser_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_current_folder(IntPtr raw);

		[DllImport("libgtk-3-0.dll")]
		static extern IntPtr gtk_file_chooser_get_current_folder_utf8(IntPtr raw);

		public string CurrentFolder { 
			get {
				IntPtr raw_ret;
				if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
				    Environment.OSVersion.Platform == PlatformID.Win32S ||
				    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				    Environment.OSVersion.Platform == PlatformID.WinCE)
					raw_ret = gtk_file_chooser_get_current_folder_utf8(Handle);
				else
					raw_ret = gtk_file_chooser_get_current_folder(Handle);
				string ret = GLib.Marshaller.FilenamePtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_current_folder_file(IntPtr raw);

		public GLib.IFile CurrentFolderFile { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_current_folder_file(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_current_folder_uri(IntPtr raw);

		public string CurrentFolderUri { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_current_folder_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_file(IntPtr raw);

		public GLib.IFile File { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_file(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_filename(IntPtr raw);

		[DllImport("libgtk-3-0.dll")]
		static extern IntPtr gtk_file_chooser_get_filename_utf8(IntPtr raw);

		public string Filename { 
			get {
				IntPtr raw_ret;
				if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
				    Environment.OSVersion.Platform == PlatformID.Win32S ||
				    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				    Environment.OSVersion.Platform == PlatformID.WinCE)
					raw_ret = gtk_file_chooser_get_filename_utf8(Handle);
				else
					raw_ret = gtk_file_chooser_get_filename(Handle);
				string ret = GLib.Marshaller.FilenamePtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_filenames(IntPtr raw);

		[DllImport("libgtk-3-0.dll")]
		static extern IntPtr gtk_file_chooser_get_filenames_utf8(IntPtr raw);

		public string[] Filenames { 
			get {
				IntPtr raw_ret;
				if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
				    Environment.OSVersion.Platform == PlatformID.Win32S ||
				    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				    Environment.OSVersion.Platform == PlatformID.WinCE)
					raw_ret = gtk_file_chooser_get_filenames_utf8(Handle);
				else
					raw_ret = gtk_file_chooser_get_filenames(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, true, typeof(GLib.ListBase.FilenameString));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_files(IntPtr raw);

		public GLib.IFile[] Files { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_files(Handle);
				GLib.IFile[] ret = (GLib.IFile[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(GLib.IFile));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_preview_file(IntPtr raw);

		public GLib.IFile PreviewFile { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_preview_file(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_preview_filename(IntPtr raw);

		[DllImport("libgtk-3-0.dll")]
		static extern IntPtr gtk_file_chooser_get_preview_filename_utf8(IntPtr raw);

		public string PreviewFilename { 
			get {
				IntPtr raw_ret;
				if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
				    Environment.OSVersion.Platform == PlatformID.Win32S ||
				    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				    Environment.OSVersion.Platform == PlatformID.WinCE)
					raw_ret = gtk_file_chooser_get_preview_filename_utf8(Handle);
				else
					raw_ret = gtk_file_chooser_get_preview_filename(Handle);
				string ret = GLib.Marshaller.FilenamePtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_preview_uri(IntPtr raw);

		public string PreviewUri { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_preview_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_uri(IntPtr raw);

		public string Uri { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_get_uris(IntPtr raw);

		public string[] Uris { 
			get {
				IntPtr raw_ret = gtk_file_chooser_get_uris(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, true, typeof(string));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_list_filters(IntPtr raw);

		public Gtk.FileFilter[] Filters { 
			get {
				IntPtr raw_ret = gtk_file_chooser_list_filters(Handle);
				Gtk.FileFilter[] ret = (Gtk.FileFilter[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, false, typeof(Gtk.FileFilter));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_list_shortcut_folder_uris(IntPtr raw);

		public string[] ShortcutFolderUris { 
			get {
				IntPtr raw_ret = gtk_file_chooser_list_shortcut_folder_uris(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, true, typeof(string));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_list_shortcut_folders(IntPtr raw);

		[DllImport("libgtk-3-0.dll")]
		static extern IntPtr gtk_file_chooser_list_shortcut_folders_utf8(IntPtr raw);

		public string[] ShortcutFolders { 
			get {
				IntPtr raw_ret;
				if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
				    Environment.OSVersion.Platform == PlatformID.Win32S ||
				    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				    Environment.OSVersion.Platform == PlatformID.WinCE)
					raw_ret = gtk_file_chooser_list_shortcut_folders_utf8(Handle);
				else
					raw_ret = gtk_file_chooser_list_shortcut_folders(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, true, typeof(GLib.ListBase.FilenameString));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_remove_filter(IntPtr raw, IntPtr filter);

		public void RemoveFilter(Gtk.FileFilter filter) {
			gtk_file_chooser_remove_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_remove_shortcut_folder(IntPtr raw, IntPtr folder, out IntPtr error);

		[DllImport("libgtk-3-0.dll")]
		static extern bool gtk_file_chooser_remove_shortcut_folder_utf8(IntPtr raw, IntPtr folder, out IntPtr error);

		public bool RemoveShortcutFolder(string folder) {
			IntPtr native_folder = GLib.Marshaller.StringToFilenamePtr (folder);
			IntPtr error = IntPtr.Zero;
			bool raw_ret;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				raw_ret = gtk_file_chooser_remove_shortcut_folder_utf8(Handle, native_folder, out error);
			else
				raw_ret = gtk_file_chooser_remove_shortcut_folder(Handle, native_folder, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_folder);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_remove_shortcut_folder_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool RemoveShortcutFolderUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_file_chooser_remove_shortcut_folder_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_select_all(IntPtr raw);

		public void SelectAll() {
			gtk_file_chooser_select_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_select_file(IntPtr raw, IntPtr file, out IntPtr error);

		public bool SelectFile(GLib.IFile file) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_file_chooser_select_file(Handle, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_select_filename(IntPtr raw, IntPtr filename);

		[DllImport("libgtk-3-0.dll")]
		static extern bool gtk_file_chooser_select_filename_utf8(IntPtr raw, IntPtr filename);

		public bool SelectFilename(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToFilenamePtr (filename);
			bool raw_ret;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				raw_ret = gtk_file_chooser_select_filename_utf8(Handle, native_filename);
			else
				raw_ret = gtk_file_chooser_select_filename(Handle, native_filename);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_filename);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_select_uri(IntPtr raw, IntPtr uri);

		public bool SelectUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gtk_file_chooser_select_uri(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_set_current_folder(IntPtr raw, IntPtr filename);

		[DllImport("libgtk-3-0.dll")]
		static extern bool gtk_file_chooser_set_current_folder_utf8(IntPtr raw, IntPtr filename);

		public bool SetCurrentFolder(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToFilenamePtr (filename);
			bool raw_ret;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				raw_ret = gtk_file_chooser_set_current_folder_utf8(Handle, native_filename);
			else
				raw_ret = gtk_file_chooser_set_current_folder(Handle, native_filename);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_filename);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_set_current_folder_file(IntPtr raw, IntPtr file, out IntPtr error);

		public bool SetCurrentFolderFile(GLib.IFile file) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_file_chooser_set_current_folder_file(Handle, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_set_current_folder_uri(IntPtr raw, IntPtr uri);

		public bool SetCurrentFolderUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gtk_file_chooser_set_current_folder_uri(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_set_current_name(IntPtr raw, IntPtr name);

		public string CurrentName { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_file_chooser_set_current_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_set_file(IntPtr raw, IntPtr file, out IntPtr error);

		public bool SetFile(GLib.IFile file) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_file_chooser_set_file(Handle, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_set_filename(IntPtr raw, IntPtr filename);

		[DllImport("libgtk-3-0.dll")]
		static extern bool gtk_file_chooser_set_filename_utf8(IntPtr raw, IntPtr filename);

		public bool SetFilename(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToFilenamePtr (filename);
			bool raw_ret;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				raw_ret = gtk_file_chooser_set_filename_utf8(Handle, native_filename);
			else
				raw_ret = gtk_file_chooser_set_filename(Handle, native_filename);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_filename);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_chooser_set_uri(IntPtr raw, IntPtr uri);

		public bool SetUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gtk_file_chooser_set_uri(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_unselect_all(IntPtr raw);

		public void UnselectAll() {
			gtk_file_chooser_unselect_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_unselect_file(IntPtr raw, IntPtr file);

		public void UnselectFile(GLib.IFile file) {
			gtk_file_chooser_unselect_file(Handle, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle));
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_unselect_filename(IntPtr raw, IntPtr filename);

		[DllImport("libgtk-3-0.dll")]
		static extern void gtk_file_chooser_unselect_filename_utf8(IntPtr raw, IntPtr filename);

		public void UnselectFilename(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToFilenamePtr (filename);
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				gtk_file_chooser_unselect_filename_utf8(Handle, native_filename);
			else
				gtk_file_chooser_unselect_filename(Handle, native_filename);
			GLib.Marshaller.Free (native_filename);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_chooser_unselect_uri(IntPtr raw, IntPtr uri);

		public void UnselectUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			gtk_file_chooser_unselect_uri(Handle, native_uri);
			GLib.Marshaller.Free (native_uri);
		}

#endregion
	}
}
