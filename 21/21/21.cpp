// Pooja Tewari
// 10-30-2013
// 21

#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main()
{
	srand(time(0));
	
	int x, y;
	cin >> x;
	int total = x;
	for(int x=1; x<=1; x++)
	{
		y = rand()%2 + 1;

		if(y=1)
		{
			total = total + 1;
		}
		
		if(y=2)
		{
			total = total + 2;
		}
		
		cout << total << endl;
	}

	return 0;
}
