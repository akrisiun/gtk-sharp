// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class NativeVolumeMonitor : GLib.VolumeMonitor {

		public NativeVolumeMonitor (IntPtr raw) : base(raw) {}

		protected NativeVolumeMonitor() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GNativeVolumeMonitorClass {
			IntPtr GetMountForMountPath;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.VolumeMonitor)).GetClassSize ();
		static Dictionary<GLib.GType, GNativeVolumeMonitorClass> class_structs;

		static GNativeVolumeMonitorClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GNativeVolumeMonitorClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GNativeVolumeMonitorClass class_struct = (GNativeVolumeMonitorClass) Marshal.PtrToStructure (class_ptr, typeof (GNativeVolumeMonitorClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GNativeVolumeMonitorClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_native_volume_monitor_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_native_volume_monitor_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
