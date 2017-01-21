// tictoetac.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<conio.h>
#include<iostream>
using namespace std;

	int x[10],o[10],n=3,turn=1,tturn=9,ch;
	int a[3][3]={{8,1,6},{3,5,7},{4,9,2}};
	int board[3][3]={{2,2,2},{2,2,2},{2,2,2}};

void display()
{
	
	cout<<"\nMagic Square Positions "<<endl;
	for (int i=0;i<n;i++)
	{
		for (int j=0;j<n;j++)
		  cout<<a[i][j]<<" ";
		cout<<endl;
	}

	cout<<"\nCurrent Status of Board is "<<endl;
	for (int i=0;i<n;i++)
	{
		for (int j=0;j<n;j++)
		  cout<<board[i][j]<<" ";
		cout<<endl;
	}
}

void whowin()
{
	//display();
	int rp, cp,dp=1;
	for (int i=0;i<n;i++)
	{
		rp=1;cp=1;
		dp=dp*board[i][i];
		for (int j=0;j<n;j++)
		{
			rp=rp*board[i][j];
			cp=cp*board[j][i];
		}
	 if(rp==27||cp==27||dp==27)
	 {
		cout<<"\n\nUser Wins\n";
		_getch();
		exit(1);
	 }
	 else if(rp==125||cp==125||dp==125)
	 {
	  cout<<"\nComputer wins\n";
	  _getch();
	  exit(2);
	 }
	}
}



void go(int t)
{
	for (int i=0;i<n;i++)
	{
		for (int j=0;j<n;j++)
		{
			if(t==a[i][j])
			{ if(turn%2==0)
				    board[i][j]=5;
			  else board[i][j]=3;
			}
		}
	}

	turn++;
	display();
	whowin();
}
int check(int t)
{
	for (int i=0;i<n;i++)
	{
		for (int j=0;j<n;j++)
		{
			if(t==a[i][j])
			{ 
				if(board[i][j]==2)
				 return a[i][j];
				/*if(turn%2==0)
				    board[i][j]=5;
			  else board[i][j]=3;*/
			}
		}
	}
	return 0;
}
int make()
{
	if(board[1][1]==2)
		return (a[1][1]);
	else
	{
	 for (int i=0;i<n;i++)
		{
		 for (int j=0;j<n;j++)
		 {
			if(board[i][i+1]==2)
				return(a[i][i+1]);
			if(board[i+1][i]==2)
				return(a[i+1][i]);
		 }
	    }
	}
	
	for (int i=0;i<n;i++)
	{
		   if(board[i][i]==2 && i!=1)
			   return a[i][i];
		   if(board[i][i+2]==2)
			   return a[i][i+2];
		   if(board[i+2][i]=2)
			   return a[i+2][i];
	}
}

int posswin(int p)
{
	/*if (turn<=3)
	{
		int g=make();
		if (g==0) cout<<"ful\n";
		go(g);
	}*/
	
	for (int i=0;i<n;i++)
	{
		for (int j=0;j<n;j++)
		{
			if(board[i][j]==p)
			{
				if (i==j)
				 for(int y=1;y<n;y++)
					if (board[y][y]==p && y!=i)
					{
						int x=15-a[i][j]-a[y][y];
						return(check(x));
					}

				if(j==n-1)
					if (board[1][1]==p)
					{
						int x=15-a[i][j]-a[1][1];
						return(check(x));
					}
					else if(board[j][i]==p)
					{
						int x=15-a[i][j]-a[j][i];
						return(check(x));
					}

				for(int k=j+1;k<n;k++)
					if(board[i][k]==p)
					{
						int x=15-a[i][j]-a[i][k];
						return(check(x));
					}
				for(int k=i+1;k<n;k++)
					if(board[k][j]==p)
					{
						int x=15-a[i][j]-a[k][j];
						return(check(x));
					}


			}
		}
	}
	return 0;

}




int _tmain(int argc, _TCHAR* argv[])
{
	int t;
	cout<<"Welcome to Tic Tac Toe game"<<endl;
	display();
	/*cout<<"1st Player Choice  (1-User 0-Computer)"<<endl;
	cin>>ch;
	if(ch==1)*/

	do
	{
		
	cout<<"User Turn (Enter the position in magic square to be marked) : ";
	cin>>t;
	go(t);
	if(turn>9) break;
	cout<<"Computer Turn : ";
	_getch();
	if(turn<=3)
	  go(make());
	else if(turn==4)
	{
	int c=posswin(3);
	  if(c!=0)
	    go(c);
	  else
		 go(make());
	}
	else 
	{
	  if(posswin(5)!=0)
	      go(posswin(5));
	  else if(posswin(3)!=0)
		 go(posswin(3));
	  else go(make());
	}
	}while(turn<=9);

	
		cout<<"\nDrawn\n";

	_getch();
	return 0;
}