// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ApplicationImpl : GLib.Opaque {

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_application_impl_activate(IntPtr raw, IntPtr platform_data);

		public void Activate(GLib.Variant platform_data) {
			g_application_impl_activate(Handle, platform_data == null ? IntPtr.Zero : platform_data.Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_application_impl_activate_action(IntPtr raw, IntPtr action_name, IntPtr parameter, IntPtr platform_data);

		public void ActivateAction(string action_name, GLib.Variant parameter, GLib.Variant platform_data) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			g_application_impl_activate_action(Handle, native_action_name, parameter == null ? IntPtr.Zero : parameter.Handle, platform_data == null ? IntPtr.Zero : platform_data.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_application_impl_change_action_state(IntPtr raw, IntPtr action_name, IntPtr value, IntPtr platform_data);

		public void ChangeActionState(string action_name, GLib.Variant value, GLib.Variant platform_data) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			g_application_impl_change_action_state(Handle, native_action_name, value == null ? IntPtr.Zero : value.Handle, platform_data == null ? IntPtr.Zero : platform_data.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_application_impl_command_line(IntPtr raw, IntPtr arguments, IntPtr platform_data);

		public int CommandLine(string arguments, GLib.Variant platform_data) {
			int raw_ret = g_application_impl_command_line(Handle, GLib.Marshaller.StringToPtrGStrdup(arguments), platform_data == null ? IntPtr.Zero : platform_data.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_application_impl_flush(IntPtr raw);

		public void Flush() {
			g_application_impl_flush(Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_application_impl_open(IntPtr raw, IntPtr files, int n_files, IntPtr hint, IntPtr platform_data);

		public void Open(GLib.IFile files, int n_files, string hint, GLib.Variant platform_data) {
			IntPtr native_hint = GLib.Marshaller.StringToPtrGStrdup (hint);
			g_application_impl_open(Handle, files == null ? IntPtr.Zero : ((files is GLib.Object) ? (files as GLib.Object).Handle : (files as GLib.FileAdapter).Handle), n_files, native_hint, platform_data == null ? IntPtr.Zero : platform_data.Handle);
			GLib.Marshaller.Free (native_hint);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_application_impl_register(IntPtr application, IntPtr appid, int flags, System.IntPtr remote_actions, IntPtr cancellable, out IntPtr error);

		public static unsafe GLib.ApplicationImpl Register(GLib.Application application, string appid, GLib.ApplicationFlags flags, System.IntPtr remote_actions, GLib.Cancellable cancellable) {
			IntPtr native_appid = GLib.Marshaller.StringToPtrGStrdup (appid);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_application_impl_register(application == null ? IntPtr.Zero : application.Handle, native_appid, (int) flags, remote_actions, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.ApplicationImpl ret = raw_ret == IntPtr.Zero ? null : (GLib.ApplicationImpl) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.ApplicationImpl), false);
			GLib.Marshaller.Free (native_appid);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public ApplicationImpl(IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_application_impl_destroy(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			g_application_impl_destroy (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				g_application_impl_destroy (handle);
				return false;
			}
		}

		~ApplicationImpl ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
