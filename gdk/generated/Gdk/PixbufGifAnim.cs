// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufGifAnim : Gdk.PixbufAnimation {

		public PixbufGifAnim (IntPtr raw) : base(raw) {}

		protected PixbufGifAnim() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdkPixbufGifAnimClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gdk.PixbufAnimation)).GetClassSize ();
		static Dictionary<GLib.GType, GdkPixbufGifAnimClass> class_structs;

		static GdkPixbufGifAnimClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdkPixbufGifAnimClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdkPixbufGifAnimClass class_struct = (GdkPixbufGifAnimClass) Marshal.PtrToStructure (class_ptr, typeof (GdkPixbufGifAnimClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdkPixbufGifAnimClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_pixbuf_gif_anim_frame_composite(IntPtr raw, IntPtr frame);

		public void FrameComposite(Gdk.PixbufFrame frame) {
			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			gdk_pixbuf_gif_anim_frame_composite(Handle, native_frame);
			frame = Gdk.PixbufFrame.New (native_frame);
			Marshal.FreeHGlobal (native_frame);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_gif_anim_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_gif_anim_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
