// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction : global::haxe.lang.HxObject {
		
		static EnglishAuction() {
			unchecked{
				#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{5541879, 13816588, 263824376, 407283053, 907774356, 957002115, 1224901875}, new string[]{"obj", "SuppressWarnings", "convertToMagLev", "hasNext", "convertToHaxe", "registerMyMethods", "next"});
				#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
				{
					#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						object __temp_odecl1 = new global::haxe.lang.DynamicObject(new int[]{13816588}, new object[]{new global::Array<object>(new object[]{new global::Array<object>(new object[]{"checkstyle:FieldDocComment", "checkstyle:LocalVariableName", "checkstyle:MultipleStringLiterals", "checkstyle:MagicNumber"})})}, new int[]{}, new double[]{});
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						global::englishauction.EnglishAuction.__meta__ = new global::haxe.lang.DynamicObject(new int[]{5541879}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
					}
					
				}
				
			}
		}
		#line default
		
		public EnglishAuction(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public EnglishAuction(global::maglev.MagLev maglev) {
			#line 14 "/my-component/src/englishauction/EnglishAuction.hx"
			global::englishauction.EnglishAuction.__hx_ctor_englishauction_EnglishAuction(this, maglev);
		}
		#line default
		
		protected static void __hx_ctor_englishauction_EnglishAuction(global::englishauction.EnglishAuction __hx_this, global::maglev.MagLev maglev) {
			#line 15 "/my-component/src/englishauction/EnglishAuction.hx"
			__hx_this.maglev = maglev;
			__hx_this.registerMyMethods();
		}
		#line default
		
		public static object __meta__;
		
		public global::maglev.MagLev maglev;
		
		public virtual void registerMyMethods() {
			#line 19 "/my-component/src/englishauction/EnglishAuction.hx"
			global::englishauction.EnglishAuction _gthis = this;
			global::maglev.MagLev bus = this.maglev;
			#line 21 "/my-component/src/englishauction/EnglishAuction.hx"
			this.maglev.register("EnglishAuction.Create", global::maglev.MagLevFunction.fromFunction(( (( global::englishauction.EnglishAuction_registerMyMethods_21__Fun.__hx_current != null )) ? (global::englishauction.EnglishAuction_registerMyMethods_21__Fun.__hx_current) : (global::englishauction.EnglishAuction_registerMyMethods_21__Fun.__hx_current = ((global::englishauction.EnglishAuction_registerMyMethods_21__Fun) (new global::englishauction.EnglishAuction_registerMyMethods_21__Fun()) )) )));
			#line 27 "/my-component/src/englishauction/EnglishAuction.hx"
			this.maglev.register("EnglishAuction.GetStart", global::maglev.MagLevFunction.fromFunction(new global::englishauction.EnglishAuction_registerMyMethods_27__Fun(bus, _gthis)));
			#line 40 "/my-component/src/englishauction/EnglishAuction.hx"
			this.maglev.register("EnglishAuction.GetEnd", global::maglev.MagLevFunction.fromFunction(new global::englishauction.EnglishAuction_registerMyMethods_40__Fun(bus, _gthis)));
			#line 53 "/my-component/src/englishauction/EnglishAuction.hx"
			this.maglev.register("EnglishAuction.HasStarted", global::maglev.MagLevFunction.fromFunction(new global::englishauction.EnglishAuction_registerMyMethods_53__Fun(bus, _gthis)));
			#line 81 "/my-component/src/englishauction/EnglishAuction.hx"
			this.maglev.register("EnglishAuction.Bid", global::maglev.MagLevFunction.fromFunction(new global::englishauction.EnglishAuction_registerMyMethods_81__Fun(bus)));
			#line 96 "/my-component/src/englishauction/EnglishAuction.hx"
			this.maglev.register("EnglishAuction.GetHighestBidder", global::maglev.MagLevFunction.fromFunction(new global::englishauction.EnglishAuction_registerMyMethods_96__Fun(bus)));
		}
		#line default
		
		public virtual object convertToHaxe(global::maglev.MagLevAny x) {
			#line 172 "/my-component/src/englishauction/EnglishAuction.hx"
			if (( x.getType() == global::maglev.MagLevNull.getStaticType() )) {
				#line 173 "/my-component/src/englishauction/EnglishAuction.hx"
				return null;
			}
			else if (( x.getType() == global::maglev.MagLevBoolean.getStaticType() )) {
				#line 176 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevBoolean y = ((global::maglev.MagLevBoolean) (x) );
				return ((object) (y.getBool()) );
			}
			else if (( x.getType() == global::maglev.MagLevString.getStaticType() )) {
				#line 180 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevString y1 = ((global::maglev.MagLevString) (x) );
				return ((object) (y1.getString()) );
			}
			else if (( x.getType() == global::maglev.MagLevNumber.getStaticType() )) {
				#line 184 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevNumber y2 = ((global::maglev.MagLevNumber) (x) );
				return ((object) (y2.getFloat()) );
			}
			else if (( x.getType() == global::maglev.MagLevArray.getStaticType() )) {
				#line 188 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray y3 = ((global::maglev.MagLevArray) (x) );
				global::Array<object> arr = new global::Array<object>();
				#line 190 "/my-component/src/englishauction/EnglishAuction.hx"
				int i = 0;
				while (( i < y3.size() )) {
					#line 192 "/my-component/src/englishauction/EnglishAuction.hx"
					arr.push(((object) (y3.@get(i)) ));
				}
				
				#line 194 "/my-component/src/englishauction/EnglishAuction.hx"
				return ((object) (arr) );
			}
			else if (( x.getType() == global::maglev.MagLevObject.getStaticType() )) {
				#line 197 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevObject y4 = ((global::maglev.MagLevObject) (x) );
				global::haxe.ds.StringMap<object> map = new global::haxe.ds.StringMap<object>();
				#line 199 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray keys = y4.keys();
				int i1 = 0;
				#line 201 "/my-component/src/englishauction/EnglishAuction.hx"
				while (( i1 < keys.size() )) {
					#line 202 "/my-component/src/englishauction/EnglishAuction.hx"
					string key = (((global::maglev.MagLevString) (keys.@get(i1)) )).getString();
					map.@set(key, ((object) (y4.@get(key)) ));
				}
				
				#line 205 "/my-component/src/englishauction/EnglishAuction.hx"
				return ((object) (map) );
			}
			else {
				#line 208 "/my-component/src/englishauction/EnglishAuction.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown("convertToHaxe: unknown type")) );
			}
			
		}
		#line default
		
		public virtual global::maglev.MagLevAny convertToMagLev(object x) {
			#line 213 "/my-component/src/englishauction/EnglishAuction.hx"
			if (( x == null )) {
				#line 214 "/my-component/src/englishauction/EnglishAuction.hx"
				return global::maglev.MagLevNull.create();
			}
			else if (global::Std.isOfType(((object) (x) ), ((object) (typeof(bool)) ))) {
				#line 217 "/my-component/src/englishauction/EnglishAuction.hx"
				return global::maglev.MagLevBoolean.fromBool(global::haxe.lang.Runtime.toBool(x));
			}
			else if (global::Std.isOfType(((object) (x) ), ((object) (typeof(string)) ))) {
				#line 220 "/my-component/src/englishauction/EnglishAuction.hx"
				return global::maglev.MagLevString.fromString(global::haxe.lang.Runtime.toString(x));
			}
			else if (global::Std.isOfType(((object) (x) ), ((object) (typeof(int)) ))) {
				#line 223 "/my-component/src/englishauction/EnglishAuction.hx"
				return global::maglev.MagLevNumber.fromInt(((int) (global::haxe.lang.Runtime.toInt(x)) ));
			}
			else if (global::Std.isOfType(((object) (x) ), ((object) (typeof(double)) ))) {
				#line 226 "/my-component/src/englishauction/EnglishAuction.hx"
				return global::maglev.MagLevNumber.fromFloat(((double) (global::haxe.lang.Runtime.toDouble(((object) (x) ))) ));
			}
			else if (global::Std.isOfType(((object) (x) ), ((object) (typeof(global::Array<object>)) ))) {
				#line 229 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray arr = global::maglev.MagLevArray.create();
				global::Array<object> y = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (((object) (x) )) ))) );
				#line 231 "/my-component/src/englishauction/EnglishAuction.hx"
				{
					#line 231 "/my-component/src/englishauction/EnglishAuction.hx"
					int _g = 0;
					#line 231 "/my-component/src/englishauction/EnglishAuction.hx"
					while (( _g < y.length )) {
						#line 231 "/my-component/src/englishauction/EnglishAuction.hx"
						object item = y[_g];
						#line 231 "/my-component/src/englishauction/EnglishAuction.hx"
						 ++ _g;
						arr.push(this.convertToMagLev(item));
					}
					
				}
				
				#line 234 "/my-component/src/englishauction/EnglishAuction.hx"
				return arr;
			}
			else if (global::Std.isOfType(((object) (x) ), ((object) (typeof(global::haxe.ds.StringMap<object>)) ))) {
				#line 237 "/my-component/src/englishauction/EnglishAuction.hx"
				global::haxe.ds.StringMap<object> map = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((object) (x) )) ))) );
				global::maglev.MagLevObject obj = global::maglev.MagLevObject.create();
				#line 239 "/my-component/src/englishauction/EnglishAuction.hx"
				{
					#line 239 "/my-component/src/englishauction/EnglishAuction.hx"
					object key = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator<object>(((global::haxe.ds.StringMap<object>) (map) ))) );
					#line 239 "/my-component/src/englishauction/EnglishAuction.hx"
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(key, "hasNext", 407283053, null))) {
						#line 239 "/my-component/src/englishauction/EnglishAuction.hx"
						string key1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(key, "next", 1224901875, null));
						obj.@set(key1, this.convertToMagLev((map.@get(key1)).toDynamic()));
					}
					
				}
				
				#line 242 "/my-component/src/englishauction/EnglishAuction.hx"
				return obj;
			}
			else if (global::Reflect.isObject(x)) {
				#line 245 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevObject obj1 = global::maglev.MagLevObject.create();
				{
					#line 246 "/my-component/src/englishauction/EnglishAuction.hx"
					int _g1 = 0;
					#line 246 "/my-component/src/englishauction/EnglishAuction.hx"
					global::Array<string> _g2 = global::Reflect.fields(x);
					#line 246 "/my-component/src/englishauction/EnglishAuction.hx"
					while (( _g1 < _g2.length )) {
						#line 246 "/my-component/src/englishauction/EnglishAuction.hx"
						string field = _g2[_g1];
						#line 246 "/my-component/src/englishauction/EnglishAuction.hx"
						 ++ _g1;
						object val = global::Reflect.getProperty(x, field);
						#line 248 "/my-component/src/englishauction/EnglishAuction.hx"
						obj1.@set(field, this.convertToMagLev(val));
					}
					
				}
				
				#line 250 "/my-component/src/englishauction/EnglishAuction.hx"
				return obj1;
			}
			else if (( ((object) (x) ) is global::haxe.lang.Function )) {
				#line 253 "/my-component/src/englishauction/EnglishAuction.hx"
				global::haxe.lang.Function f = ((global::haxe.lang.Function) (((object) (x) )) );
				return global::maglev.MagLevFunction.fromFunction(f);
			}
			else {
				#line 257 "/my-component/src/englishauction/EnglishAuction.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown("convertToMagLev: unknown type")) );
			}
			
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
				switch (hash) {
					case 858513194:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						this.maglev = ((global::maglev.MagLev) (@value) );
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return @value;
					}
					
					
					default:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
				switch (hash) {
					case 263824376:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "convertToMagLev", 263824376)) );
					}
					
					
					case 907774356:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "convertToHaxe", 907774356)) );
					}
					
					
					case 957002115:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "registerMyMethods", 957002115)) );
					}
					
					
					case 858513194:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return this.maglev;
					}
					
					
					default:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
				switch (hash) {
					case 263824376:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return this.convertToMagLev(dynargs[0]);
					}
					
					
					case 907774356:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return this.convertToHaxe(((global::maglev.MagLevAny) (dynargs[0]) ));
					}
					
					
					case 957002115:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						this.registerMyMethods();
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						break;
					}
					
					
					default:
					{
						#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
			baseArr.push("maglev");
			#line 11 "/my-component/src/englishauction/EnglishAuction.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction_registerMyMethods_21__Fun : global::haxe.lang.Function {
		
		public EnglishAuction_registerMyMethods_21__Fun() : base(1, 0) {
		}
		
		
		public static global::englishauction.EnglishAuction_registerMyMethods_21__Fun __hx_current;
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 21 "/my-component/src/englishauction/EnglishAuction.hx"
			global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
			#line 24 "/my-component/src/englishauction/EnglishAuction.hx"
			string ret = "still_id_here";
			return global::maglev.MagLevResult.fromResult(global::maglev.MagLevString.fromString(ret));
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction_registerMyMethods_27__Fun : global::haxe.lang.Function {
		
		public EnglishAuction_registerMyMethods_27__Fun(global::maglev.MagLev bus, global::englishauction.EnglishAuction _gthis) : base(1, 0) {
			#line 27 "/my-component/src/englishauction/EnglishAuction.hx"
			this.bus = bus;
			#line 27 "/my-component/src/englishauction/EnglishAuction.hx"
			this._gthis = _gthis;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 27 "/my-component/src/englishauction/EnglishAuction.hx"
			global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
			string id = (((global::maglev.MagLevString) (args.@get(0)) )).getString();
			#line 29 "/my-component/src/englishauction/EnglishAuction.hx"
			global::Array arr = new global::Array<object>(new object[]{"EnglishAuction.Auction", "FindById", new global::Array<object>(new object[]{id})});
			global::haxe.ds.StringMap<object> auction = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((object) (this._gthis.convertToHaxe(this.bus.call("Persistence.Get", ((global::maglev.MagLevArray) (this._gthis.convertToMagLev(((object) (arr) ))) )).getResult())) )) ))) );
			#line 31 "/my-component/src/englishauction/EnglishAuction.hx"
			double start = ((double) (0) );
			if (global::Std.isOfType((auction.@get("start")).toDynamic(), ((object) (typeof(string)) ))) {
				#line 33 "/my-component/src/englishauction/EnglishAuction.hx"
				global::Date _this = global::Date.fromString(global::haxe.lang.Runtime.toString((auction.@get("start")).toDynamic()));
				#line 33 "/my-component/src/englishauction/EnglishAuction.hx"
				start = ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this.date) )).Ticks) ) - ((long) (global::Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
			}
			else {
				#line 35 "/my-component/src/englishauction/EnglishAuction.hx"
				start = ((double) (global::haxe.lang.Runtime.toDouble((auction.@get("start")).toDynamic())) );
			}
			
			#line 37 "/my-component/src/englishauction/EnglishAuction.hx"
			double result = start;
			return global::maglev.MagLevResult.fromResult(global::maglev.MagLevNumber.fromFloat(result));
		}
		#line default
		
		public global::maglev.MagLev bus;
		
		public global::englishauction.EnglishAuction _gthis;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction_registerMyMethods_40__Fun : global::haxe.lang.Function {
		
		public EnglishAuction_registerMyMethods_40__Fun(global::maglev.MagLev bus, global::englishauction.EnglishAuction _gthis) : base(1, 0) {
			#line 40 "/my-component/src/englishauction/EnglishAuction.hx"
			this.bus = bus;
			#line 40 "/my-component/src/englishauction/EnglishAuction.hx"
			this._gthis = _gthis;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 40 "/my-component/src/englishauction/EnglishAuction.hx"
			global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
			string id = (((global::maglev.MagLevString) (args.@get(0)) )).getString();
			#line 42 "/my-component/src/englishauction/EnglishAuction.hx"
			global::Array arr = new global::Array<object>(new object[]{"EnglishAuction.Auction", "FindById", new global::Array<object>(new object[]{id})});
			global::haxe.ds.StringMap<object> auction = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((object) (this._gthis.convertToHaxe(this.bus.call("Persistence.Get", ((global::maglev.MagLevArray) (this._gthis.convertToMagLev(((object) (arr) ))) )).getResult())) )) ))) );
			#line 44 "/my-component/src/englishauction/EnglishAuction.hx"
			double end = ((double) (0) );
			if (global::Std.isOfType((auction.@get("end")).toDynamic(), ((object) (typeof(string)) ))) {
				#line 46 "/my-component/src/englishauction/EnglishAuction.hx"
				global::Date _this = global::Date.fromString(global::haxe.lang.Runtime.toString((auction.@get("end")).toDynamic()));
				#line 46 "/my-component/src/englishauction/EnglishAuction.hx"
				end = ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this.date) )).Ticks) ) - ((long) (global::Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
			}
			else {
				#line 48 "/my-component/src/englishauction/EnglishAuction.hx"
				end = ((double) (global::haxe.lang.Runtime.toDouble((auction.@get("end")).toDynamic())) );
			}
			
			#line 50 "/my-component/src/englishauction/EnglishAuction.hx"
			double result = end;
			return global::maglev.MagLevResult.fromResult(global::maglev.MagLevNumber.fromFloat(result));
		}
		#line default
		
		public global::maglev.MagLev bus;
		
		public global::englishauction.EnglishAuction _gthis;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction_registerMyMethods_53__Fun : global::haxe.lang.Function {
		
		public EnglishAuction_registerMyMethods_53__Fun(global::maglev.MagLev bus, global::englishauction.EnglishAuction _gthis) : base(1, 0) {
			#line 53 "/my-component/src/englishauction/EnglishAuction.hx"
			this.bus = bus;
			#line 53 "/my-component/src/englishauction/EnglishAuction.hx"
			this._gthis = _gthis;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 53 "/my-component/src/englishauction/EnglishAuction.hx"
			global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
			string id = (((global::maglev.MagLevString) (args.@get(0)) )).getString();
			#line 55 "/my-component/src/englishauction/EnglishAuction.hx"
			global::Array arr = new global::Array<object>(new object[]{"EnglishAuction.Auction", "FindById", new global::Array<object>(new object[]{id})});
			global::haxe.ds.StringMap<object> auction = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((object) (this._gthis.convertToHaxe(this.bus.call("Persistence.Get", ((global::maglev.MagLevArray) (this._gthis.convertToMagLev(((object) (arr) ))) )).getResult())) )) ))) );
			#line 57 "/my-component/src/englishauction/EnglishAuction.hx"
			double start = ((double) (0) );
			if (global::Std.isOfType((auction.@get("start")).toDynamic(), ((object) (typeof(string)) ))) {
				#line 59 "/my-component/src/englishauction/EnglishAuction.hx"
				global::Date _this = global::Date.fromString(global::haxe.lang.Runtime.toString((auction.@get("start")).toDynamic()));
				#line 59 "/my-component/src/englishauction/EnglishAuction.hx"
				start = ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this.date) )).Ticks) ) - ((long) (global::Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
			}
			else {
				#line 61 "/my-component/src/englishauction/EnglishAuction.hx"
				start = ((double) (global::haxe.lang.Runtime.toDouble((auction.@get("start")).toDynamic())) );
			}
			
			#line 63 "/my-component/src/englishauction/EnglishAuction.hx"
			global::Date _this1 = new global::Date(((global::System.DateTime) (global::System.DateTime.Now) ));
			#line 63 "/my-component/src/englishauction/EnglishAuction.hx"
			double now = ( ((double) (((long) (( ((long) (global::System.TimeZone.CurrentTimeZone.ToUniversalTime(((global::System.DateTime) (_this1.date) )).Ticks) ) - ((long) (global::Date.epochTicks) ) )) )) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
			bool result = ( start <= now );
			#line 65 "/my-component/src/englishauction/EnglishAuction.hx"
			return global::maglev.MagLevResult.fromResult(global::maglev.MagLevBoolean.fromBool(result));
		}
		#line default
		
		public global::maglev.MagLev bus;
		
		public global::englishauction.EnglishAuction _gthis;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction_registerMyMethods_81__Fun : global::haxe.lang.Function {
		
		public EnglishAuction_registerMyMethods_81__Fun(global::maglev.MagLev bus) : base(1, 0) {
			#line 81 "/my-component/src/englishauction/EnglishAuction.hx"
			this.bus = bus;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 81 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
				global::maglev.MagLevString auctionId = ((global::maglev.MagLevString) (args.@get(0)) );
				#line 83 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevString userId = ((global::maglev.MagLevString) (args.@get(1)) );
				global::maglev.MagLevNumber price = ((global::maglev.MagLevNumber) (args.@get(2)) );
				#line 85 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevObject data = global::maglev.MagLevObject.create();
				data.@set("auctionId", auctionId);
				#line 87 "/my-component/src/englishauction/EnglishAuction.hx"
				data.@set("userId", userId);
				data.@set("price", price);
				#line 89 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray args1 = global::maglev.MagLevArray.create();
				args1.push(global::maglev.MagLevString.fromString("EnglishAuction.Bid"));
				#line 91 "/my-component/src/englishauction/EnglishAuction.hx"
				args1.push(global::maglev.MagLevString.fromString("New"));
				args1.push(data);
				#line 93 "/my-component/src/englishauction/EnglishAuction.hx"
				this.bus.call("Persistence.Mutate", args1);
				return global::maglev.MagLevResult.fromResult(global::maglev.MagLevBoolean.fromBool(true));
			}
			#line default
		}
		
		
		public global::maglev.MagLev bus;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class EnglishAuction_registerMyMethods_96__Fun : global::haxe.lang.Function {
		
		public EnglishAuction_registerMyMethods_96__Fun(global::maglev.MagLev bus) : base(1, 0) {
			#line 96 "/my-component/src/englishauction/EnglishAuction.hx"
			this.bus = bus;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 96 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray args = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::maglev.MagLevArray) (((object) (__fn_float1) )) )) : (((global::maglev.MagLevArray) (__fn_dyn1) )) );
				global::maglev.MagLevString auctionId = ((global::maglev.MagLevString) (args.@get(0)) );
				#line 98 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevArray myargs = global::maglev.MagLevArray.create();
				myargs.push(auctionId);
				#line 100 "/my-component/src/englishauction/EnglishAuction.hx"
				myargs.push(global::maglev.MagLevNumber.fromInt(1));
				global::maglev.MagLevArray myargs2 = global::maglev.MagLevArray.create();
				#line 102 "/my-component/src/englishauction/EnglishAuction.hx"
				myargs2.push(global::maglev.MagLevString.fromString("EnglishAuction.Bid"));
				myargs2.push(global::maglev.MagLevString.fromString("FindByHighestPriceForAuction"));
				#line 104 "/my-component/src/englishauction/EnglishAuction.hx"
				myargs2.push(myargs);
				global::maglev.MagLevResult ret = this.bus.call("Persistence.Get", myargs2);
				#line 106 "/my-component/src/englishauction/EnglishAuction.hx"
				if (ret.isError()) {
					#line 106 "/my-component/src/englishauction/EnglishAuction.hx"
					return ret;
				}
				
				#line 107 "/my-component/src/englishauction/EnglishAuction.hx"
				global::maglev.MagLevAny res = ret.getResult();
				#line 109 "/my-component/src/englishauction/EnglishAuction.hx"
				if (global::Std.isOfType(((object) (res) ), ((object) (typeof(global::maglev.MagLevArray)) ))) {
					#line 110 "/my-component/src/englishauction/EnglishAuction.hx"
					global::maglev.MagLevArray resarr = ((global::maglev.MagLevArray) (res) );
					if (( resarr.size() > 0 )) {
						#line 112 "/my-component/src/englishauction/EnglishAuction.hx"
						global::maglev.MagLevObject row = ((global::maglev.MagLevObject) (resarr.@get(0)) );
						global::maglev.MagLevObject row2 = global::maglev.MagLevObject.create();
						#line 114 "/my-component/src/englishauction/EnglishAuction.hx"
						row2.@set("userId", row.@get("userId"));
						row2.@set("price", row.@get("price"));
						#line 116 "/my-component/src/englishauction/EnglishAuction.hx"
						return global::maglev.MagLevResult.fromResult(row2);
					}
					else {
						#line 118 "/my-component/src/englishauction/EnglishAuction.hx"
						return global::maglev.MagLevResult.fromResult(global::maglev.MagLevNull.create());
					}
					
				}
				else {
					#line 122 "/my-component/src/englishauction/EnglishAuction.hx"
					global::maglev.MagLevError error = global::maglev.MagLevError.create(0, "persistence getter did not return array", global::maglev.MagLevNull.create());
					return global::maglev.MagLevResult.fromError(error);
				}
				
			}
			#line default
		}
		
		
		public global::maglev.MagLev bus;
		
	}
}


