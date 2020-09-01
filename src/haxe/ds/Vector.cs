// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._Vector {
	public sealed class Vector_Impl_ {
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static T1[] _new<T1>(int length) {
			#line 64 "/opt/haxe/std/haxe/ds/Vector.hx"
			T1[] this1 = new T1[length];
			#line 64 "/opt/haxe/std/haxe/ds/Vector.hx"
			return ((T1[]) (this1) );
		}
		#line default
		
		public static T1 @get<T1>(T1[] this1, int index) {
			#line 103 "/opt/haxe/std/haxe/ds/Vector.hx"
			return global::haxe.lang.Runtime.genericCast<T1>(this1[index]);
		}
		#line default
		
		public static T1 @set<T1>(T1[] this1, int index, T1 val) {
			#line 121 "/opt/haxe/std/haxe/ds/Vector.hx"
			return this1[index] = val;
		}
		#line default
		
		
		
		public static int get_length<T1>(T1[] this1) {
			#line 134 "/opt/haxe/std/haxe/ds/Vector.hx"
			return ( this1 as global::System.Array ).Length;
		}
		#line default
		
		public static void blit<T>(T[] src, int srcPos, T[] dest, int destPos, int len) {
			#line 157 "/opt/haxe/std/haxe/ds/Vector.hx"
			global::System.Array.Copy(((global::System.Array) (src) ), ((int) (srcPos) ), ((global::System.Array) (dest) ), ((int) (destPos) ), ((int) (len) ));
		}
		#line default
		
		public static global::Array<T1> toArray<T1>(T1[] this1) {
			#line 202 "/opt/haxe/std/haxe/ds/Vector.hx"
			global::Array<T1> a = new global::Array<T1>();
			int len = ( this1 as global::System.Array ).Length;
			#line 209 "/opt/haxe/std/haxe/ds/Vector.hx"
			{
				#line 209 "/opt/haxe/std/haxe/ds/Vector.hx"
				int _g = 0;
				#line 209 "/opt/haxe/std/haxe/ds/Vector.hx"
				int _g1 = len;
				#line 209 "/opt/haxe/std/haxe/ds/Vector.hx"
				while (( _g < _g1 )) {
					#line 209 "/opt/haxe/std/haxe/ds/Vector.hx"
					int i = _g++;
					a[i] = global::haxe.lang.Runtime.genericCast<T1>(((T1[]) (this1) )[i]);
				}
				
			}
			
			#line 211 "/opt/haxe/std/haxe/ds/Vector.hx"
			return a;
		}
		#line default
		
		public static T1[] toData<T1>(T1[] this1) {
			#line 221 "/opt/haxe/std/haxe/ds/Vector.hx"
			return this1;
		}
		#line default
		
		public static T[] fromData<T>(T[] data) {
			#line 231 "/opt/haxe/std/haxe/ds/Vector.hx"
			return ((T[]) (data) );
		}
		#line default
		
		public static T[] fromArrayCopy<T>(global::Array<T> array) {
			#line 252 "/opt/haxe/std/haxe/ds/Vector.hx"
			T[] ret = new T[array.length];
			#line 252 "/opt/haxe/std/haxe/ds/Vector.hx"
			global::cs.Lib.p_nativeArray<T>(((global::Array<T>) (array) ), ((global::System.Array) (ret) ));
			#line 252 "/opt/haxe/std/haxe/ds/Vector.hx"
			return ((T[]) (ret) );
		}
		#line default
		
		public static void sort<T, T1>(T[] this1, global::haxe.lang.Function f) {
			#line 350 "/opt/haxe/std/haxe/ds/Vector.hx"
			throw ((global::System.Exception) (global::haxe.Exception.thrown("not yet supported")) );
		}
		#line default
		
	}
}


