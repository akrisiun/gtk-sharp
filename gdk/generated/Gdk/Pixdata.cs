// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Pixdata : IEquatable<Pixdata> {

		public uint Magic;
		public int Length;
		public uint PixdataType;
		public uint Rowstride;
		public uint Width;
		public uint Height;
		private IntPtr _pixel_data;

		public static Gdk.Pixdata Zero = new Gdk.Pixdata ();

		public static Gdk.Pixdata New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gdk.Pixdata.Zero;
			return (Gdk.Pixdata) Marshal.PtrToStructure (raw, typeof (Gdk.Pixdata));
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gdk_pixdata_deserialize(IntPtr raw, uint stream_length, byte[] stream, out IntPtr error);

		public unsafe bool Deserialize(uint stream_length, byte[] stream) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gdk_pixdata_deserialize(this_as_native, stream_length, stream, out error);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixdata_from_pixbuf(IntPtr raw, IntPtr pixbuf, bool use_rle);

		public IntPtr FromPixbuf(Gdk.Pixbuf pixbuf, bool use_rle) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gdk_pixdata_from_pixbuf(this_as_native, pixbuf == null ? IntPtr.Zero : pixbuf.Handle, use_rle);
			IntPtr ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gdk.Pixdata target)
		{
			target = New (native);
		}

		public bool Equals (Pixdata other)
		{
			return true && Magic.Equals (other.Magic) && Length.Equals (other.Length) && PixdataType.Equals (other.PixdataType) && Rowstride.Equals (other.Rowstride) && Width.Equals (other.Width) && Height.Equals (other.Height) && _pixel_data.Equals (other._pixel_data);
		}

		public override bool Equals (object other)
		{
			return other is Pixdata && Equals ((Pixdata) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Magic.GetHashCode () ^ Length.GetHashCode () ^ PixdataType.GetHashCode () ^ Rowstride.GetHashCode () ^ Width.GetHashCode () ^ Height.GetHashCode () ^ _pixel_data.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
