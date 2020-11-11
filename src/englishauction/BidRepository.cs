// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace englishauction {
	public class BidRepository : global::haxe.lang.HxObject {
		
		static BidRepository() {
			unchecked{
				#line 5 "/my-component/src/englishauction/BidRepository.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{3254785, 770176554, 958206052, 1542743820, 1609038980, 1835582091}, new string[]{"Add", "Edit", "Remove", "GetNumberOfBids", "GetHighestBids", "FindById"});
			}
		}
		#line default
		
		public BidRepository(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public BidRepository(global::maglev.MagLev bus) {
			#line 9 "/my-component/src/englishauction/BidRepository.hx"
			global::englishauction.BidRepository.__hx_ctor_englishauction_BidRepository(this, bus);
		}
		#line default
		
		protected static void __hx_ctor_englishauction_BidRepository(global::englishauction.BidRepository __hx_this, global::maglev.MagLev bus) {
			#line 10 "/my-component/src/englishauction/BidRepository.hx"
			__hx_this.bus = bus;
		}
		#line default
		
		public global::maglev.MagLev bus;
		
		public virtual void Add(global::englishauction.BidModel bid) {
		}
		
		
		public virtual void Edit(global::englishauction.BidModel bid) {
		}
		
		
		public virtual void Remove(string bidId) {
		}
		
		
		public virtual global::englishauction.BidModel FindById(string bidId) {
			#line 27 "/my-component/src/englishauction/BidRepository.hx"
			return null;
		}
		#line default
		
		public virtual int GetNumberOfBids(string auctionId) {
			#line 31 "/my-component/src/englishauction/BidRepository.hx"
			global::maglev.MagLevArray pargs = global::maglev.MagLevArray.create();
			pargs.push(global::maglev.MagLevString.fromString("EnglishAuction.Bid"));
			#line 33 "/my-component/src/englishauction/BidRepository.hx"
			pargs.push(global::maglev.MagLevString.fromString("CountForAuction"));
			global::maglev.MagLevArray parr = global::maglev.MagLevArray.create();
			#line 35 "/my-component/src/englishauction/BidRepository.hx"
			parr.push(global::maglev.MagLevString.fromString(auctionId));
			pargs.push(parr);
			#line 37 "/my-component/src/englishauction/BidRepository.hx"
			global::maglev.MagLevResult ret = this.bus.call("Persistence.Get", pargs);
			int count = 0;
			#line 39 "/my-component/src/englishauction/BidRepository.hx"
			if ( ! (ret.isError()) ) {
				#line 40 "/my-component/src/englishauction/BidRepository.hx"
				count = (((global::maglev.MagLevNumber) (ret.getResult()) )).getInt();
			}
			
			#line 42 "/my-component/src/englishauction/BidRepository.hx"
			return count;
		}
		#line default
		
		public virtual global::Array<object> GetHighestBids(string auctionId, int numBids) {
			#line 46 "/my-component/src/englishauction/BidRepository.hx"
			global::maglev.MagLevArray myargs = global::maglev.MagLevArray.create();
			myargs.push(global::maglev.MagLevString.fromString(auctionId));
			#line 48 "/my-component/src/englishauction/BidRepository.hx"
			myargs.push(global::maglev.MagLevNumber.fromInt(numBids));
			global::maglev.MagLevArray myargs2 = global::maglev.MagLevArray.create();
			#line 50 "/my-component/src/englishauction/BidRepository.hx"
			myargs2.push(global::maglev.MagLevString.fromString("EnglishAuction.Bid"));
			myargs2.push(global::maglev.MagLevString.fromString("FindByHighestPriceForAuction"));
			#line 52 "/my-component/src/englishauction/BidRepository.hx"
			myargs2.push(myargs);
			global::maglev.MagLevResult res = this.bus.call("Persistence.Get", myargs2);
			#line 54 "/my-component/src/englishauction/BidRepository.hx"
			global::maglev.MagLevArray arr = ((global::maglev.MagLevArray) (res.getResult()) );
			global::Array<object> bids = new global::Array<object>();
			#line 56 "/my-component/src/englishauction/BidRepository.hx"
			int i = 0;
			while (( i < arr.size() )) {
				#line 58 "/my-component/src/englishauction/BidRepository.hx"
				global::englishauction.BidModel model = new global::englishauction.BidModel();
				global::maglev.MagLevObject resobj = ((global::maglev.MagLevObject) (arr.@get(i)) );
				#line 60 "/my-component/src/englishauction/BidRepository.hx"
				model.id = (((global::maglev.MagLevString) (resobj.@get("bidId")) )).getString();
				if (resobj.exists("auctionId")) {
					#line 62 "/my-component/src/englishauction/BidRepository.hx"
					model.auctionId = (((global::maglev.MagLevString) (resobj.@get("auctionId")) )).getString();
				}
				else {
					#line 64 "/my-component/src/englishauction/BidRepository.hx"
					model.auctionId = auctionId;
				}
				
				#line 66 "/my-component/src/englishauction/BidRepository.hx"
				model.userId = (((global::maglev.MagLevString) (resobj.@get("userId")) )).getString();
				model.amount = (((global::maglev.MagLevNumber) (resobj.@get("price")) )).getFloat();
				#line 68 "/my-component/src/englishauction/BidRepository.hx"
				bids.push(model);
				 ++ i;
			}
			
			#line 71 "/my-component/src/englishauction/BidRepository.hx"
			return bids;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 5 "/my-component/src/englishauction/BidRepository.hx"
				switch (hash) {
					case 4899648:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						this.bus = ((global::maglev.MagLev) (@value) );
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return @value;
					}
					
					
					default:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 5 "/my-component/src/englishauction/BidRepository.hx"
				switch (hash) {
					case 1609038980:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "GetHighestBids", 1609038980)) );
					}
					
					
					case 1542743820:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "GetNumberOfBids", 1542743820)) );
					}
					
					
					case 1835582091:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "FindById", 1835582091)) );
					}
					
					
					case 958206052:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "Remove", 958206052)) );
					}
					
					
					case 770176554:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "Edit", 770176554)) );
					}
					
					
					case 3254785:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "Add", 3254785)) );
					}
					
					
					case 4899648:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return this.bus;
					}
					
					
					default:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 5 "/my-component/src/englishauction/BidRepository.hx"
				switch (hash) {
					case 1609038980:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return this.GetHighestBids(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1542743820:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return this.GetNumberOfBids(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1835582091:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return this.FindById(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 958206052:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						this.Remove(global::haxe.lang.Runtime.toString(dynargs[0]));
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						break;
					}
					
					
					case 770176554:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						this.Edit(((global::englishauction.BidModel) (dynargs[0]) ));
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						break;
					}
					
					
					case 3254785:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						this.Add(((global::englishauction.BidModel) (dynargs[0]) ));
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						break;
					}
					
					
					default:
					{
						#line 5 "/my-component/src/englishauction/BidRepository.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 5 "/my-component/src/englishauction/BidRepository.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 5 "/my-component/src/englishauction/BidRepository.hx"
			baseArr.push("bus");
			#line 5 "/my-component/src/englishauction/BidRepository.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


