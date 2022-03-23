#pragma once
enum class CardSuit
{
    Hearts, Diamonds, Spades, Clubs
};

class Card
{
private:
    CardSuit _suit;//field

public:
    Card(CardSuit suit);//constructor
    CardSuit GetSuit();
    void SetSuit(CardSuit suit);
};

