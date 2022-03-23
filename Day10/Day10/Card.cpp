#include "Card.h"

Card::Card(CardSuit suit)
{
	SetSuit(suit);
}
CardSuit Card::GetSuit()
{
	return _suit;
}

void Card::SetSuit(CardSuit suit)
{
	_suit = suit;
}