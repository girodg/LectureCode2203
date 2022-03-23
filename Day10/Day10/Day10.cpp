// Day10.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
#include "Card.h"


void printSuit(CardSuit suit)
{
    switch (suit)
    {
    case CardSuit::Hearts:
        std::cout << "Hearts\n";
    case CardSuit::Diamonds:
        std::cout << "Diamonds\n";
        break;
    case CardSuit::Spades:
        break;
    case CardSuit::Clubs:
        break;
    default:
        break;
    }
}
int main()
{
    //C#: System.Console.Write("Hello World!\n");
    //std: standard namespace
    //:: - scope resolution operator. C# equivalent - '.' EX: System.
    //cout - console output stream
    //<< - insertion operator. inserting text into the output stream
    std::cout << "Hello World!\n" << "Hello Gotham. I am the hero you need.\n";

    int number = 5;
    bool isBatman = true;
    char b = 'b';//1 byte in C++. 2 bytes in C#

    //C#: 
    //int[] nums = new int[]{4,7,13}; arrays and classes are reference types
    int* nums = new int[] {4, 7, 13};//#'s stored on the heap
    delete[] nums;//to clean up
    //nums is a pointer
    int numbers[3] = {4,7,13};//stored on the stack

    char best[] = "Batman";//insert a \0 (null terminator) at the end
    char meh[] = { 'A','q','u','a','m','a','n','\0'};//does NOT add the null terminator
    std::cout << best << "\n" << meh << "\n";

    for (int i = 0; i < 6; i++)
    {
        std::cout << best[i] << " ";
    }
    while (true)
    {
        break;
    }
    do
    {
        break;
    } while (true);

    if (isBatman)
    {
        std::cout << "Because I'm BATMAN!\n";
    }
    else
    {
        std::cout << "Oh well.\n";
    }

    //C#: CardSuit suit = CardSuit.Hearts
    CardSuit suit = CardSuit::Hearts;
    switch (suit)
    {
    case CardSuit::Hearts:
        std::cout << "Hearts\n";
    case CardSuit::Diamonds:
        std::cout << "Diamonds\n";
        break;
    case CardSuit::Spades:
        break;
    case CardSuit::Clubs:
        break;
    default:
        break;
    }

    printSuit(suit);

    srand(time(NULL));//seed random
    int grade = rand() % 101;//0-100

    //C#: List<T>
    //C++ vector<type>
    std::vector<int>* pNums = new std::vector<int>();
    pNums->push_back(10);
    (*pNums).push_back(15);
    delete pNums;

    std::vector<int> vNums;
    vNums.push_back(5);//c#: Add()


    Card myCard(CardSuit::Clubs);

    Card* pCard = new Card(CardSuit::Hearts);
    delete pCard;
}