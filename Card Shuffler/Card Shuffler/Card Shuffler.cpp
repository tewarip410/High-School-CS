/*************
Pooja Tewari
1-30-2014
Card Shuffler
*************/

#include <iostream>
#include <iomanip>
#include <stdlib.h>
#include <time.h>
using namespace std;

void shuffle(int[][13]);
void deal(int[][13], char *[], char *[]);

bool isPair(int[][13]);
bool twoPair(int[][13]);
bool fullhouse(int[][13]);
bool isThreeOfAKind(int[][13]);
bool isFourOfAKind(int[][13]);
bool isFlush(int[][13]);
bool isSF(int[][13]);
bool isStraight(int[][13]);

int main()
{
	srand(time(0));
	
	int deck[4][13] = {0};

	char *suit[4] = {"Hearts", "Diamonds", "Clubs", "Spades"};

	char *face[13] = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

	shuffle(deck);
	deal(deck, suit, face);

	cout << endl;
	
	if(isSF(deck))
	{
		cout << "You have a straight flush!" << endl;
	}
	else if(isFourOfAKind(deck))
	{
		cout << "You have a four of a kind!" << endl;
	}
	else if(isPair(deck) && isThreeOfAKind(deck))
	{
		cout << "You have a full house" << endl;
	}
	else if(isFlush(deck))
	{
		cout << "You have a flush!" << endl;
	}
	else if(isStraight(deck))
	{
		cout << "You have a straight!" << endl;
	}
	else if(isThreeOfAKind(deck))
	{
		cout << "You have a three of a kind!" << endl;
	}
	else if(twoPair(deck))
	{
		cout << "You have a two pair!" << endl;
	}
	else if(isPair(deck))
	{
		cout << "You have a pair!" << endl;
	}

	cout << endl;

	return 0;
}

void shuffle(int deck[][13])
{
	int row, col;

	for(int card=1; card<=5; card++)
	{
		do
		{
			row = rand() % 4;
			col = rand() %13;
		}while(deck[row][col]!=0);

		deck[row][col] = card;
	}
}

void deal(int deck[][13], char *suit[], char *face[])
{
	for(int card=1; card<=5; card++)
	{
		for(int s=0; s<=3; s++)
		{
			for(int f=0; f<=12; f++)
			{
				if(deck[s][f]==card)
				{
					cout << face[f] << " of " << suit[s] << endl;
				}
			}
		}
	}
}

bool isPair(int deck[][13])
{
	int count = 0;

	for(int f=0; f<=12; f++)
	{
		count=0;

		for(int s=0; s<=3; s++)
		{
			if(deck[s][f]!=0)
			{
				count++;
			}
		}

		if(count==2)
		{
			return true;
		}
	}

	return false;
}

bool twoPair(int deck[][13])
{
	int count = 0, pairs = 0;

	for(int f=0; f<=12; f++)
	{
		count=0;

		for(int s=0; s<=3; s++)
		{
			if(deck[s][f]!=0)
			{
				count++;
			}
		}

		if(count==2)
		{
			pairs++;
		}
	}

	if(pairs==2)
	{
		return true;
	}

	return false;
}

bool isThreeOfAKind(int deck[][13])
{
	int count = 0;

	for(int f = 0; f <= 12; f++)
	{
		count = 0;

		for(int s = 0; s <= 3; s++)
		{
			if(deck[s][f] != 0)
			{
				count++;
			}
		}

		if(count == 3)
		{
			return true;
		}
	}

	return false;
}

bool isFourOfAKind(int deck[][13])
{
	int count = 0;

	for(int f = 0; f <= 12; f++)
	{
		count = 0;

		for(int s = 0; s <= 3; s++)
		{
			if(deck[s][f] != 0)
			{
				count++;
			}
		}

		if(count == 4)
		{
			return true;
		}
	}

	return false;
}

bool isFlush(int deck[][13])
{
	int count = 0;

	for (int s=0; s<4;s++)
	{
		count = 0;

		for (int f=0; f<13; f++)
		{
			if (deck[s][f]!=0)
			{
				count ++;
			}
		}
		
		if(count==5)
		{
			return true;
		}
	}

	return false;
}

bool isSF(int deck[][13])
{
	if((isFlush(deck)) &&(isStraight(deck)))
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool isStraight(int deck[][13])
{
	int cards[6];
	for(int card=1;card<=5;card++)
	{
		for(int s=0;s<=3;s++)
		{
			for(int f=0;f<=12;f++)
			{
				if(deck[s][f]==card)
				{
					cards[card]=f;
				}
			}
		}
	}
	for (int k = 1; k < 5; k++)
	{
		for (int i = 0; i <4 - k; i++)
		{
			if (cards[i] > cards[i +1])
			{
				int temp = cards[i];
				cards[i] = cards[i + 1];
				cards[i + 1] = temp;
			}
		}
	}
	for(int i=1;i++;i<5)
	{
			if (cards[i]-cards[i+1]!=1)
				return false;
	}
	return true;
}
