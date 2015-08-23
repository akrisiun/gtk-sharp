// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class StateSet : GLib.Object {

		public StateSet (IntPtr raw) : base(raw) {}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_state_set_new();

		public StateSet () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StateSet)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = atk_state_set_new();
		}

		[StructLayout (LayoutKind.Sequential)]
		struct AtkStateSetClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, AtkStateSetClass> class_structs;

		static AtkStateSetClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, AtkStateSetClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				AtkStateSetClass class_struct = (AtkStateSetClass) Marshal.PtrToStructure (class_ptr, typeof (AtkStateSetClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, AtkStateSetClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_state_set_add_state(IntPtr raw, int type);

		public bool AddState(Atk.StateType type) {
			bool raw_ret = atk_state_set_add_state(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_state_set_add_states(IntPtr raw, out int types, int n_types);

		public Atk.StateType AddStates(int n_types) {
			Atk.StateType types;
			int native_types;
			atk_state_set_add_states(Handle, out native_types, n_types);
			types = (Atk.StateType) native_types;
			return types;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_state_set_and_sets(IntPtr raw, IntPtr compare_set);

		public Atk.StateSet AndSets(Atk.StateSet compare_set) {
			IntPtr raw_ret = atk_state_set_and_sets(Handle, compare_set == null ? IntPtr.Zero : compare_set.Handle);
			Atk.StateSet ret = GLib.Object.GetObject(raw_ret) as Atk.StateSet;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_state_set_clear_states(IntPtr raw);

		public void ClearStates() {
			atk_state_set_clear_states(Handle);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_state_set_contains_state(IntPtr raw, int type);

		public bool ContainsState(Atk.StateType type) {
			bool raw_ret = atk_state_set_contains_state(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_state_set_contains_states(IntPtr raw, out int types, int n_types);

		public bool ContainsStates(out Atk.StateType types, int n_types) {
			int native_types;
			bool raw_ret = atk_state_set_contains_states(Handle, out native_types, n_types);
			bool ret = raw_ret;
			types = (Atk.StateType) native_types;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_state_set_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_state_set_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_state_set_is_empty(IntPtr raw);

		public bool IsEmpty { 
			get {
				bool raw_ret = atk_state_set_is_empty(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_state_set_or_sets(IntPtr raw, IntPtr compare_set);

		public Atk.StateSet OrSets(Atk.StateSet compare_set) {
			IntPtr raw_ret = atk_state_set_or_sets(Handle, compare_set == null ? IntPtr.Zero : compare_set.Handle);
			Atk.StateSet ret = GLib.Object.GetObject(raw_ret) as Atk.StateSet;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_state_set_remove_state(IntPtr raw, int type);

		public bool RemoveState(Atk.StateType type) {
			bool raw_ret = atk_state_set_remove_state(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_state_set_xor_sets(IntPtr raw, IntPtr compare_set);

		public Atk.StateSet XorSets(Atk.StateSet compare_set) {
			IntPtr raw_ret = atk_state_set_xor_sets(Handle, compare_set == null ? IntPtr.Zero : compare_set.Handle);
			Atk.StateSet ret = GLib.Object.GetObject(raw_ret) as Atk.StateSet;
			return ret;
		}

#endregion
	}
}