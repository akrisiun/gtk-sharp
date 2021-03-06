// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class UnixSocketAddress : GLib.SocketAddress {

		public UnixSocketAddress (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_socket_address_new(IntPtr path);

		public UnixSocketAddress (string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixSocketAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("path");
				vals.Add (new GLib.Value (path));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			Raw = g_unix_socket_address_new(native_path);
			GLib.Marshaller.Free (native_path);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_socket_address_new_abstract(IntPtr path, int path_len);

		public static UnixSocketAddress NewAbstract(string path)
		{
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			UnixSocketAddress result = new UnixSocketAddress (g_unix_socket_address_new_abstract(native_path, System.Text.Encoding.UTF8.GetByteCount (path)));
			GLib.Marshaller.Free (native_path);
			return result;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_socket_address_new_with_type(IntPtr path, int path_len, int type);

		public UnixSocketAddress (string path, GLib.UnixSocketAddressType type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixSocketAddress)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			Raw = g_unix_socket_address_new_with_type(native_path, System.Text.Encoding.UTF8.GetByteCount (path), (int) type);
			GLib.Marshaller.Free (native_path);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_socket_address_get_path(IntPtr raw);

		[GLib.Property ("path")]
		public string Path {
			get  {
				IntPtr raw_ret = g_unix_socket_address_get_path(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[GLib.Property ("path-as-array")]
		public IntPtr PathAsArray {
			get {
				GLib.Value val = GetProperty ("path-as-array");
				IntPtr ret = (IntPtr) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("abstract")]
		public bool Abstract {
			get {
				GLib.Value val = GetProperty ("abstract");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_socket_address_get_address_type(IntPtr raw);

		[GLib.Property ("address-type")]
		public GLib.UnixSocketAddressType AddressType {
			get  {
				int raw_ret = g_unix_socket_address_get_address_type(Handle);
				GLib.UnixSocketAddressType ret = (GLib.UnixSocketAddressType) raw_ret;
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GUnixSocketAddressClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.SocketAddress)).GetClassSize ();
		static Dictionary<GLib.GType, GUnixSocketAddressClass> class_structs;

		static GUnixSocketAddressClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GUnixSocketAddressClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GUnixSocketAddressClass class_struct = (GUnixSocketAddressClass) Marshal.PtrToStructure (class_ptr, typeof (GUnixSocketAddressClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GUnixSocketAddressClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_unix_socket_address_abstract_names_supported();

		public static bool AbstractNamesSupported() {
			bool raw_ret = g_unix_socket_address_abstract_names_supported();
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_unix_socket_address_get_is_abstract(IntPtr raw);

		[Obsolete]
		public bool IsAbstract { 
			get {
				bool raw_ret = g_unix_socket_address_get_is_abstract(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_unix_socket_address_get_path_len(IntPtr raw);

		public ulong PathLen { 
			get {
				UIntPtr raw_ret = g_unix_socket_address_get_path_len(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_socket_address_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_socket_address_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
