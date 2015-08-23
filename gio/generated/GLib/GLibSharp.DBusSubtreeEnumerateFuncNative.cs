// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr DBusSubtreeEnumerateFuncNative(IntPtr connection, IntPtr sender, IntPtr object_path, IntPtr user_data);

	internal class DBusSubtreeEnumerateFuncInvoker {

		DBusSubtreeEnumerateFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~DBusSubtreeEnumerateFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal DBusSubtreeEnumerateFuncInvoker (DBusSubtreeEnumerateFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal DBusSubtreeEnumerateFuncInvoker (DBusSubtreeEnumerateFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal DBusSubtreeEnumerateFuncInvoker (DBusSubtreeEnumerateFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.DBusSubtreeEnumerateFunc Handler {
			get {
				return new GLib.DBusSubtreeEnumerateFunc(InvokeNative);
			}
		}

		string InvokeNative (GLib.DBusConnection connection, string sender, string object_path)
		{
			IntPtr native_sender = GLib.Marshaller.StringToPtrGStrdup (sender);
			IntPtr native_object_path = GLib.Marshaller.StringToPtrGStrdup (object_path);
			string __result = GLib.Marshaller.PtrToStringGFree(native_cb (connection == null ? IntPtr.Zero : connection.Handle, native_sender, native_object_path, __data));
			GLib.Marshaller.Free (native_sender);
			GLib.Marshaller.Free (native_object_path);
			return __result;
		}
	}

	internal class DBusSubtreeEnumerateFuncWrapper {

		public IntPtr NativeCallback (IntPtr connection, IntPtr sender, IntPtr object_path, IntPtr user_data)
		{
			try {
				string __ret = managed (GLib.Object.GetObject(connection) as GLib.DBusConnection, GLib.Marshaller.Utf8PtrToString (sender), GLib.Marshaller.Utf8PtrToString (object_path));
				if (release_on_call)
					gch.Free ();
				return GLib.Marshaller.StringToPtrGStrdup(__ret);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal DBusSubtreeEnumerateFuncNative NativeDelegate;
		GLib.DBusSubtreeEnumerateFunc managed;

		public DBusSubtreeEnumerateFuncWrapper (GLib.DBusSubtreeEnumerateFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new DBusSubtreeEnumerateFuncNative (NativeCallback);
		}

		public static GLib.DBusSubtreeEnumerateFunc GetManagedDelegate (DBusSubtreeEnumerateFuncNative native)
		{
			if (native == null)
				return null;
			DBusSubtreeEnumerateFuncWrapper wrapper = (DBusSubtreeEnumerateFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
