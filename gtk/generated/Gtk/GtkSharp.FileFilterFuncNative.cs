// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool FileFilterFuncNative(IntPtr filter_info, IntPtr data);

	internal class FileFilterFuncInvoker {

		FileFilterFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FileFilterFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FileFilterFuncInvoker (FileFilterFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FileFilterFuncInvoker (FileFilterFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FileFilterFuncInvoker (FileFilterFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.FileFilterFunc Handler {
			get {
				return new Gtk.FileFilterFunc(InvokeNative);
			}
		}

		bool InvokeNative (Gtk.FileFilterInfo filter_info)
		{
			IntPtr native_filter_info = GLib.Marshaller.StructureToPtrAlloc (filter_info);
			bool __result = native_cb (native_filter_info, __data);
			filter_info = Gtk.FileFilterInfo.New (native_filter_info);
			Marshal.FreeHGlobal (native_filter_info);
			return __result;
		}
	}

	internal class FileFilterFuncWrapper {

		public bool NativeCallback (IntPtr filter_info, IntPtr data)
		{
			try {
				bool __ret = managed (Gtk.FileFilterInfo.New (filter_info));
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FileFilterFuncNative NativeDelegate;
		Gtk.FileFilterFunc managed;

		public FileFilterFuncWrapper (Gtk.FileFilterFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FileFilterFuncNative (NativeCallback);
		}

		public static Gtk.FileFilterFunc GetManagedDelegate (FileFilterFuncNative native)
		{
			if (native == null)
				return null;
			FileFilterFuncWrapper wrapper = (FileFilterFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
