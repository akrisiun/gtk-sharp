// GtkSharp.Generation.OpaqueGen.cs - The Opaque Generatable.
//
// Author: Mike Kestner <mkestner@speakeasy.net>
//
// Copyright (c) 2001-2003 Mike Kestner
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the GNU General Public
// License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GtkSharp.Generation {

	using System;
	using System.Collections;
	using System.IO;
	using System.Xml;

	public class OpaqueGen : ClassBase {

		public OpaqueGen (XmlElement ns, XmlElement elem) : base (ns, elem) {}
	
		public override string FromNative(string var)
		{
			return var + " == IntPtr.Zero ? null : new " + QualifiedName + "(" + var + ")";
		}

		private bool DisableRawCtor {
			get {
				return Elem.HasAttribute ("disable_raw_ctor");
			}
		}

		public override void Generate (GenerationInfo gen_info)
		{
			StreamWriter sw = gen_info.Writer = gen_info.OpenStream (Name);

			sw.WriteLine ("namespace " + NS + " {");
			sw.WriteLine ();
			sw.WriteLine ("\tusing System;");
			sw.WriteLine ("\tusing System.Collections;");
			sw.WriteLine ("\tusing System.Runtime.InteropServices;");
			sw.WriteLine ();

			sw.WriteLine ("#region Autogenerated code");

			SymbolTable table = SymbolTable.Table;

			sw.Write ("\tpublic class " + Name);
			string cs_parent = table.GetCSType(Elem.GetAttribute("parent"));
			if (cs_parent != "")
				sw.Write (" : " + cs_parent);
			else
				sw.Write (" : GLib.Opaque");
			sw.WriteLine (" {");
			sw.WriteLine ();
            
			GenMethods (gen_info, null, null);
			GenCtors (gen_info);
			sw.WriteLine ("#endregion");
			
			AppendCustom(sw, gen_info.CustomDir);

			sw.WriteLine ("\t}");
			sw.WriteLine ("}");

			sw.Close ();
			gen_info.Writer = null;
			Statistics.OpaqueCount++;
		}

		private bool Validate ()
		{
			if (methods != null)
				foreach (Method method in methods.Values)
					if (!method.Validate()) {
						Console.WriteLine ("in Opaque" + QualifiedName);
						return false;
					}
			return true;
		}

		protected override void GenCtors (GenerationInfo gen_info)
		{
			if (!DisableRawCtor) {
				gen_info.Writer.WriteLine("\t\tpublic " + Name + "(IntPtr raw) : base(raw) {}");
				gen_info.Writer.WriteLine();
			}

			base.GenCtors (gen_info);
		}

	}
}

