// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace AtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool FunctionNative(IntPtr data);

	internal class FunctionInvoker {

		FunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FunctionInvoker (FunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FunctionInvoker (FunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FunctionInvoker (FunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Atk.Function Handler {
			get {
				return new Atk.Function(InvokeNative);
			}
		}

		bool InvokeNative ()
		{
			bool __result = native_cb (__data);
			return __result;
		}
	}

	internal class FunctionWrapper {

		public bool NativeCallback (IntPtr data)
		{
			try {
				bool __ret = managed ();
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

		internal FunctionNative NativeDelegate;
		Atk.Function managed;

		public FunctionWrapper (Atk.Function managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FunctionNative (NativeCallback);
		}

		public static Atk.Function GetManagedDelegate (FunctionNative native)
		{
			if (native == null)
				return null;
			FunctionWrapper wrapper = (FunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}