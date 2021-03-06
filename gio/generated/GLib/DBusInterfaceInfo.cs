// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DBusInterfaceInfo : GLib.Opaque {

		[DllImport ("giosharpglue-3")]
		extern static uint glibsharp_glib_dbusinterfaceinfo_get_ref_count_offset ();

		static uint ref_count_offset = glibsharp_glib_dbusinterfaceinfo_get_ref_count_offset ();
		public int RefCount {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + ref_count_offset);
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + ref_count_offset);
					*raw_ptr = value;
				}
			}
		}

		[DllImport ("giosharpglue-3")]
		extern static uint glibsharp_glib_dbusinterfaceinfo_get_name_offset ();

		static uint name_offset = glibsharp_glib_dbusinterfaceinfo_get_name_offset ();
		public string Name {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + name_offset);
					return GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + name_offset);
					*raw_ptr = GLib.Marshaller.StringToPtrGStrdup (value);
				}
			}
		}

		[DllImport ("giosharpglue-3")]
		extern static uint glibsharp_glib_dbusinterfaceinfo_get_methods_offset ();

		static uint methods_offset = glibsharp_glib_dbusinterfaceinfo_get_methods_offset ();
		public GLib.DBusMethodInfo Methods {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + methods_offset);
					return (*raw_ptr) == IntPtr.Zero ? null : (GLib.DBusMethodInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (GLib.DBusMethodInfo), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + methods_offset);
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		[DllImport ("giosharpglue-3")]
		extern static uint glibsharp_glib_dbusinterfaceinfo_get_signals_offset ();

		static uint signals_offset = glibsharp_glib_dbusinterfaceinfo_get_signals_offset ();
		public GLib.DBusSignalInfo Signals {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + signals_offset);
					return (*raw_ptr) == IntPtr.Zero ? null : (GLib.DBusSignalInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (GLib.DBusSignalInfo), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + signals_offset);
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		[DllImport ("giosharpglue-3")]
		extern static uint glibsharp_glib_dbusinterfaceinfo_get_properties_offset ();

		static uint properties_offset = glibsharp_glib_dbusinterfaceinfo_get_properties_offset ();
		public GLib.DBusPropertyInfo Properties {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + properties_offset);
					return (*raw_ptr) == IntPtr.Zero ? null : (GLib.DBusPropertyInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (GLib.DBusPropertyInfo), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + properties_offset);
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		[DllImport ("giosharpglue-3")]
		extern static uint glibsharp_glib_dbusinterfaceinfo_get_annotations_offset ();

		static uint annotations_offset = glibsharp_glib_dbusinterfaceinfo_get_annotations_offset ();
		public GLib.DBusAnnotationInfo Annotations {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + annotations_offset);
					return (*raw_ptr) == IntPtr.Zero ? null : (GLib.DBusAnnotationInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (GLib.DBusAnnotationInfo), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + annotations_offset);
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_dbus_interface_info_generate_xml(IntPtr raw, uint indent, IntPtr string_builder);

		public void GenerateXml(uint indent, string string_builder) {
			g_dbus_interface_info_generate_xml(Handle, indent, new GLib.GString (string_builder).Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_dbus_interface_info_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_dbus_interface_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_dbus_interface_info_lookup_method(IntPtr raw, IntPtr name);

		public GLib.DBusMethodInfo LookupMethod(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = g_dbus_interface_info_lookup_method(Handle, native_name);
			GLib.DBusMethodInfo ret = raw_ret == IntPtr.Zero ? null : (GLib.DBusMethodInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.DBusMethodInfo), false);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_dbus_interface_info_lookup_property(IntPtr raw, IntPtr name);

		public GLib.DBusPropertyInfo LookupProperty(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = g_dbus_interface_info_lookup_property(Handle, native_name);
			GLib.DBusPropertyInfo ret = raw_ret == IntPtr.Zero ? null : (GLib.DBusPropertyInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.DBusPropertyInfo), false);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_dbus_interface_info_lookup_signal(IntPtr raw, IntPtr name);

		public GLib.DBusSignalInfo LookupSignal(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = g_dbus_interface_info_lookup_signal(Handle, native_name);
			GLib.DBusSignalInfo ret = raw_ret == IntPtr.Zero ? null : (GLib.DBusSignalInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.DBusSignalInfo), false);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		public DBusInterfaceInfo(IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_dbus_interface_info_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				g_dbus_interface_info_ref (raw);
				Owned = true;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_dbus_interface_info_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				g_dbus_interface_info_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				g_dbus_interface_info_unref (handle);
				return false;
			}
		}

		~DBusInterfaceInfo ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
