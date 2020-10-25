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
	 * @param priceIncrement price increments for bids in the auction
	 * @return {number} The x value.
	*/
	Create(start, end, startingPrice, reservePrice, priceIncrement)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [start, end, startingPrice, reservePrice, priceIncrement];
		//TODO: C# let ret = bus.call('EnglishAuction.Create', args);
		//TODO: C# return ret;
	}

	/**
	 * Get the start of an auction
	 * Will return a timestamp in milliseconds
	 * @param auctionId auction id
	 * @return {number} The x value.
	*/
	GetStart(auctionId)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId];
		//TODO: C# let ret = bus.call('EnglishAuction.GetStart', args);
		//TODO: C# return ret;
	}

	/**
	 * Check if auction has ended
	 * @param auctionId auction id
	 * @return {number} The x value.
	*/
	GetEnd(auctionId)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId];
		//TODO: C# let ret = bus.call('EnglishAuction.GetEnd', args);
		//TODO: C# return ret;
	}

	/**
	 * Check if an auction has started yet
	 * @param auctionId auction id
	 * @return {number} The x value.
	*/
	HasStarted(auctionId)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId];
		//TODO: C# let ret = bus.call('EnglishAuction.HasStarted', args);
		//TODO: C# return ret;
	}

	/**
	 * Create a bid in an auction
	 * @param auctionId auction id
	 * @param userId user id
	 * @param price price bud
	*/
	Bid(auctionId, userId, price)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId, userId, price];
		//TODO: bus.call('EnglishAuction.Bid', args);
	}

	/**
	 * Get the highest bidder in an auction
	 * @param auctionId auction id
	 * @return {number} The x value.
	*/
	GetHighestBidder(auctionId)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId];
		//TODO: C# let ret = bus.call('EnglishAuction.GetHighestBidder', args);
		//TODO: C# return ret;
	}

	/**
	 * Get the highest bids in an auction
	 * @param auctionId auction id
	 * @param numBids max number of highest bids to return
	 * @return {number} The x value.
	*/
	GetHighestBids(auctionId, numBids)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId, numBids];
		//TODO: C# let ret = bus.call('EnglishAuction.GetHighestBids', args);
		//TODO: C# return ret;
	}

	/**
	 * Get the number of bids in an auction
	 * @param auctionId auction id
	 * @return {number} The x value.
	*/
	GetNumberOfBids(auctionId)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId];
		//TODO: C# let ret = bus.call('EnglishAuction.GetNumberOfBids', args);
		//TODO: C# return ret;
	}

	/**
	 * Get the price increment for the specified auction
	 * @param auctionId auction id
	 * @return {number} The x value.
	*/
	GetPriceIncrement(auctionId)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [auctionId];
		//TODO: C# let ret = bus.call('EnglishAuction.GetPriceIncrement', args);
		//TODO: C# return ret;
	}

}

