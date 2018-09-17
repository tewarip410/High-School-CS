// Pooja
// 11-1-2013
// Craps

#include <iostream>
using namespace std;
#include <time.h>
#include <stdlib.h>

int rollDice();

int main()
{
	srand(time(0));

	// Enumerated Data Types - sequential list of information
	//enum Months (JAN=1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC);
	//Months todayDate
	
	enum Status {REROLL, WON, LOST};
	Status gameStatus; 
	int sum, point;

	sum = rollDice();
	
	switch(sum)
	{
	case 7:
	case 11:
		gameStatus = WON;
		break;

	case 2:
	case 3:
	case 12:
		gameStatus = LOST;
		break;

	default:		//else for switch case
		gameStatus = REROLL;
		point = sum;
		cout << "The point is " << point << endl;
		break;
	}

	while(gameStatus == REROLL)
	{
		sum = rollDice();

		if(sum==point)
		{
			gameStatus = WON;
		}
		else if(sum==7)
		{
			gameStatus = LOST;
		}
	}

	if(gameStatus==WON)
	{
		cout << "You win!" << endl;
	}
	else
	{
		cout << "You lose!" << endl;
	}

	return 0;
}

int rollDice()
{
	int d1 = rand()%6 + 1;
	int d2 = rand()%6 + 1;

	cout << "You rolled a " << d1 << " and " << d2 << " = " << d1+d2 << endl;

	return d1+d2;
}