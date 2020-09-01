/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

/**
 * An Auction Library
 * Timed auction starting at a low price and increasing until no more bids are made.
 * Also supports reserve price and automatic bidding.
 */
public class EnglishAuction
{

	/**
	 * Create a new auction
	 * @param start start time of auction
	 * @param end end time of auction
	 * @param startingPrice starting price of auction
	 * @param reservePrice reserve price for the auction (0 = none)
	 * @return {number} The x value.
	*/
	Create(start, end, startingPrice, reservePrice)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [start, end, startingPrice, reservePrice];
		//TODO: C# let ret = bus.call('EnglishAuction.Create', args);
		//TODO: C# return ret;
	}

	/**
	 * Bid in an auction
	 * @param auctionId auction id to bid in
	 * @param userId user id that's bidding
	 * @param price bid price
	 * @return {number} The x value.
	*/
	Bid(auctionId, userId, price)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId, userId, price];
		//TODO: C# let ret = bus.call('EnglishAuction.Bid', args);
		//TODO: C# return ret;
	}

	/**
	 * Automatically bid against others in an auction (up to the specified amount)
	 * @param auctionId auction id to bid in
	 * @param userId user id that's bidding
	 * @param price bid price
	 * @return {number} The x value.
	*/
	AutoBid(auctionId, userId, price)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId, userId, price];
		//TODO: C# let ret = bus.call('EnglishAuction.AutoBid', args);
		//TODO: C# return ret;
	}

	/**
	 * Force an auction to close and specify the winning bid.
	 * @param auctionId auction id to bid in
	 * @param userId user id that's bidding
	 * @param price bid price
	 * @return {number} The x value.
	*/
	ForceClose(auctionId, userId, price)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId, userId, price];
		//TODO: C# let ret = bus.call('EnglishAuction.ForceClose', args);
		//TODO: C# return ret;
	}

	/**
	 * TBD
	*/
	Status()
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [];
		//TODO: bus.call('EnglishAuction.Status', args);
	}

}

