// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FileDescriptorBasedAdapter : GLib.GInterfaceAdapter, GLib.IFileDescriptorBased {

		[StructLayout (LayoutKind.Sequential)]
		struct GFileDescriptorBasedIface {
			public GetFdNativeDelegate GetFd;
		}

		static GFileDescriptorBasedIface iface;

		static FileDescriptorBasedAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (FileDescriptorBasedAdapter));
			iface.GetFd = new GetFdNativeDelegate (GetFd_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetFdNativeDelegate (IntPtr inst);

		static int GetFd_cb (IntPtr inst)
		{
			try {
				IFileDescriptorBasedImplementor __obj = GLib.Object.GetObject (inst, false) as IFileDescriptorBasedImplementor;
				int __result;
				__result = __obj.Fd;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GFileDescriptorBasedIface native_iface = (GFileDescriptorBasedIface) Marshal.PtrToStructure (ifaceptr, typeof (GFileDescriptorBasedIface));
			native_iface.GetFd = iface.GetFd;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public FileDescriptorBasedAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public FileDescriptorBasedAdapter (IFileDescriptorBasedImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public FileDescriptorBasedAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_descriptor_based_get_type();

		private static GLib.GType _gtype = new GLib.GType (g_file_descriptor_based_get_type ());

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

		public static IFileDescriptorBased GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IFileDescriptorBased GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IFileDescriptorBasedImplementor)
				return new FileDescriptorBasedAdapter (obj as IFileDescriptorBasedImplementor);
			else if (obj as IFileDescriptorBased == null)
				return new FileDescriptorBasedAdapter (obj.Handle);
			else
				return obj as IFileDescriptorBased;
		}

		public IFileDescriptorBasedImplementor Implementor {
			get {
				return implementor as IFileDescriptorBasedImplementor;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_file_descriptor_based_get_fd(IntPtr raw);

		public int Fd { 
			get {
				int raw_ret = g_file_descriptor_based_get_fd(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}