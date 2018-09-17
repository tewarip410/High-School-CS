/*****************************
* Pooja Tewari		Period 8
* January 17th, 2014
* 8 Queens 
*****************************/

#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;

bool validMove(int, int);
bool validBoard();
void fillQueens();
void resetBoard();
void printBoard();

int board[8][8];

int main()
{
	srand(6);

	do
	{
		resetBoard();
		fillQueens();
	}while(validBoard()==false);

	printBoard();

	return 0;
}

/****************************************
* Function: Reset Board
* Purpose: Resets the entire board to 0
* Parameters: real numbers row, col
* Return value: 0
****************************************/

void resetBoard()
{
	for(int row=0; row<=7; row++)
	{
		for(int col=0; col<=7; col++)
		{
			board[row][col] = 0;
		}
	}
}

/****************************************
* Function: Print Board
* Purpose: Prints the values on the board
* Parameters: real numbers row, col
* Return value: board[row]col]
****************************************/

void printBoard()
{
	for(int row=0; row<=7; row++)
	{
		for(int col=0; col<=7; col++)
		{
			cout << board[row][col];
		}

		cout << endl;
	}
}

/****************************************
* Function: Valid Move
* Purpose: Checks if a move is valid 
* Parameters: real numbers row, col
* Return value: true or false
****************************************/

bool validMove(int row, int col)
{
	if(row>=0 && row<=7 && col>=0 && col<=7)
	{
		return true;
	}

	return false;
}

/******************************************************************
* Function: fill Queens
* Purpose: Picks a random row in each column to place the queen in
* Parameters: real numbers col
* Return value: 1
******************************************************************/

void fillQueens()
{
	for(int col=0; col<=7; col++)
	{
		board[rand()%8][col]=1;
	}
}

/*********************************************************************************
* Function: Valid Board
* Purpose: Makes sure that there is only 1 queen in each column, row, and diagonal
* Parameters: real numbers row, col, testTotal, rowValue, colValue
* Return value: 0
*********************************************************************************/

bool validBoard()
{
	int testTotal=0; // The rows and columns associated with each queen

	for(int row=0;row<=7; row++)
	{
		for(int col=0; col<=7; col++)
		{
			testTotal+= board[row][col];
		}

		if(testTotal!=1)
		{
			return false;
		}

		testTotal=0;
	}

	for(int rowValue=0; rowValue<=7; rowValue++)
	{
		for(int colValue=0; colValue<=7; colValue++)
		{
			testTotal = 0;

			int row=rowValue, col=colValue;

			for(int diagonal=0; diagonal<=7; diagonal++)	//	Upper left diagonal
			{
				row--;
				col--;

				if(validMove(row, col)==true)
				{
					testTotal+=board[row][col];
				}
			}
		
			if(testTotal>1)
			{
				return false;
			}
		
			testTotal=0;
			row = rowValue;
			col = colValue;

			for(int diagonal=0; diagonal<=7; diagonal++)	//	Upper right diagonal
			{
				row--;
				col++;

				if(validMove(row, col)==true)
				{
					testTotal+=board[row][col];
				}
			}
		
			if(testTotal>1)
			{
				return false;
			}
		
			testTotal=0;
			row = rowValue;
			col = colValue;
			
			for(int diagonal=0; diagonal<=7; diagonal++)	//	Bottom left diagonal
			{
				row++;
				col--;

				if(validMove(row, col)==true)
				{
					testTotal+=board[row][col];
				}
			}
		
			if(testTotal>1)
			{
				return false;
			}
		
			testTotal=0;
			row = rowValue;
			col = colValue;

			for(int diagonal=0; diagonal<=7; diagonal++)	//	Bottom right diagonal
			{
				row++;
				col++;

				if(validMove(row, col)==true)
				{
					testTotal+=board[row][col];
				}
			}
		
			if(testTotal>1)
			{
				return false;
			}

			testTotal=0;
		}
	}

	return true;
}
