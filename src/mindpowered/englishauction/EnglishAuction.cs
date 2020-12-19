/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * An Auction Library
 * Timed auction starting at a low price and increasing until no more bids are made.
 * Also supports reserve price and automatic bidding.
 */
namespace mindpowered.englishauction {
	public delegate void MyCallbackDelegate(object o);

	public class EnglishAuction
	{
		public EnglishAuction()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::englishauction.EnglishAuction myinstance = new global::englishauction.EnglishAuction(bus);
		}

		/**
		 * Create a new auction
		 * @param start start time of auction
		 * @param end end time of auction
		 * @param startingPrice starting price of auction
		 * @param reservePrice reserve price for the auction (0 = none)
		 * @param priceIncrement price increments for bids in the auction
		 * @return {string} auctionId
		*/
		public string Create(double start, double end, double startingPrice, double reservePrice, double priceIncrement)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(start);
			args.push(end);
			args.push(startingPrice);
			args.push(reservePrice);
			args.push(priceIncrement);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.Create", args, async_callback);
			return ret;
		}

		/**
		 * Get the start of an auction
		 * Will return a timestamp in milliseconds
		 * @param auctionId auction id
		 * @return {double} start of auction
		*/
		public double GetStart(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetStart", args, async_callback);
			return ret;
		}

		/**
		 * Check if auction has ended
		 * @param auctionId auction id
		 * @return {bool} true if auction has ended, false otherwise
		*/
		public bool GetEnd(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			bool ret = false;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (bool) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetEnd", args, async_callback);
			return ret;
		}

		/**
		 * Check if an auction has started yet
		 * @param auctionId auction id
		 * @return {bool} true if auction has started, false otherwise
		*/
		public bool HasStarted(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			bool ret = false;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (bool) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.HasStarted", args, async_callback);
			return ret;
		}

		/**
		 * Check if an auction has ended yet
		 * @param auctionId auction id
		 * @return {bool} true if auction has ended, false otherwise
		*/
		public bool HasEnded(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			bool ret = false;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (bool) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.HasEnded", args, async_callback);
			return ret;
		}

		/**
		 * Create a bid in an auction
		 * @param auctionId auction id
		 * @param userId user id
		 * @param price price bud
		*/
		public void Bid(string auctionId, string userId, double price)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			args.push(userId);
			args.push(price);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.Bid", args, async_callback);
		}

		/**
		 * Get the highest bidder in an auction
		 * @param auctionId auction id
		 * @return {dynamic} 
		*/
		public dynamic GetHighestBidder(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			dynamic ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (dynamic) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetHighestBidder", args, async_callback);
			return ret;
		}

		/**
		 * Get the highest bids in an auction
		 * @param auctionId auction id
		 * @param numBids max number of highest bids to return
		 * @return {object[]} Highest bids for the specified auction
		*/
		public object[] GetHighestBids(string auctionId, double numBids)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			args.push(numBids);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetHighestBids", args, async_callback);
			return ret;
		}

		/**
		 * Get the number of bids in an auction
		 * @param auctionId auction id
		 * @return {double} Number of bids placed in the specified auction
		*/
		public double GetNumberOfBids(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetNumberOfBids", args, async_callback);
			return ret;
		}

		/**
		 * Get the price increment for the specified auction
		 * @param auctionId auction id
		 * @return {double} Price increment
		*/
		public double GetPriceIncrement(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetPriceIncrement", args, async_callback);
			return ret;
		}

		/**
		 * Get the reserve price for the specified auction
		 * @param auctionId auction id
		 * @return {double} Reserve price
		*/
		public double GetReservePrice(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetReservePrice", args, async_callback);
			return ret;
		}

		/**
		 * Get the starting price for the specified auction
		 * @param auctionId auction id
		 * @return {double} Starting price
		*/
		public double GetStartingPrice(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetStartingPrice", args, async_callback);
			return ret;
		}

		/**
		 * Get the time remaining for the specified auction
		 * @param auctionId auction id
		 * @param now current unix timestamp
		 * @return {double} Time remaining in seconds
		*/
		public double CalcTimeRemaining(string auctionId, double now)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			args.push(now);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.CalcTimeRemaining", args, async_callback);
			return ret;
		}

		/**
		 * Get the minimum next bid for the specified auction
		 * @param auctionId auction id
		 * @return {double} Minimum bid price
		*/
		public double CalcMinimumBid(string auctionId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(auctionId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.CalcMinimumBid", args, async_callback);
			return ret;
		}

		/**
		 * Get a list of auctions based on their end time
		 * @param endfrom end from
		 * @param endto end to
		 * @param page 
		 * @param perpage number of auctions per page
		 * @param sort field to sort by
		 * @param asc ascending (true) or descending (false)
		 * @return {object[]} List of auctions ending in the specified period
		*/
		public object[] GetAuctionsEnding(double endfrom, double endto, double page, double perpage, string sort, bool asc)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(endfrom);
			args.push(endto);
			args.push(page);
			args.push(perpage);
			args.push(sort);
			args.push(asc);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetAuctionsEnding", args, async_callback);
			return ret;
		}

		/**
		 * Get a list of auctions based on their start time
		 * @param startfrom start from
		 * @param startto start to
		 * @param page 
		 * @param perpage number of auctions per page
		 * @param sort field to sort by
		 * @param asc ascending (true) or descending (false)
		 * @return {object[]} List of auctions starting in the specified period
		*/
		public object[] GetAuctionsStarting(double startfrom, double startto, double page, double perpage, string sort, bool asc)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(startfrom);
			args.push(startto);
			args.push(page);
			args.push(perpage);
			args.push(sort);
			args.push(asc);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetAuctionsStarting", args, async_callback);
			return ret;
		}

		/**
		 * Get a list of currently running auctions
		 * @param page 
		 * @param perpage number of auctions per page
		 * @param sort field to sort by
		 * @param asc ascending (true) or descending (false)
		 * @return {object[]} List of open auctions
		*/
		public object[] GetOpenAuctions(double page, double perpage, string sort, bool asc)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(page);
			args.push(perpage);
			args.push(sort);
			args.push(asc);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("EnglishAuction.GetOpenAuctions", args, async_callback);
			return ret;
		}

	}
}

