// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufSimpleAnim : Gdk.PixbufAnimation {

		public PixbufSimpleAnim (IntPtr raw) : base(raw) {}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_simple_anim_new(int width, int height, float rate);

		public PixbufSimpleAnim (int width, int height, float rate) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufSimpleAnim)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = gdk_pixbuf_simple_anim_new(width, height, rate);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_simple_anim_get_loop(IntPtr raw);

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_pixbuf_simple_anim_set_loop(IntPtr raw, bool loop);

		[GLib.Property ("loop")]
		public bool Loop {
			get  {
				bool raw_ret = gdk_pixbuf_simple_anim_get_loop(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gdk_pixbuf_simple_anim_set_loop(Handle, value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdkPixbufSimpleAnimClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gdk.PixbufAnimation)).GetClassSize ();
		static Dictionary<GLib.GType, GdkPixbufSimpleAnimClass> class_structs;

		static GdkPixbufSimpleAnimClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdkPixbufSimpleAnimClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdkPixbufSimpleAnimClass class_struct = (GdkPixbufSimpleAnimClass) Marshal.PtrToStructure (class_ptr, typeof (GdkPixbufSimpleAnimClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdkPixbufSimpleAnimClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_pixbuf_simple_anim_add_frame(IntPtr raw, IntPtr pixbuf);

		public void AddFrame(Gdk.Pixbuf pixbuf) {
			gdk_pixbuf_simple_anim_add_frame(Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_simple_anim_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_simple_anim_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
