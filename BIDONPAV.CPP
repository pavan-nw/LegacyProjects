#include<iostream.h>
#include<conio.h>
void sharevalue();
void buyorsell();
void buyshare(float,int,int);
void sellshare(float,int,int);
void agent();
long int total=10000,shareamt;
float s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15;
float t1,t2,t3,t4,t5;
int selc,sela,ch,k=0,pu[15],nos[15];
void main()
{
clrscr();

cout<<"-----------------WEL COME TO STOCK EXCHANGE GAME-----------------\n";
cout<<"\nYOUR INTIAL AMOUNT GIVEN IS Rs 10000.. \n";
cout<<"------------------------------------------------------------------\n";
for(int x=0;x<15;x++)
{
pu[x]=0;nos[x]=0;
}

do
{

if(k==0){
s1=1910;s2=1860;s3=1448;s4=1563;s5=1700;s6=1616;s7=1991;s8=1120;s9=200;s10=120;
s11=800;s12=2005;s13=4000;s14=2020;s15=1160.5;
t1=.15;t2=.4;t3=.28;t4=.35;t5=.8;}

if(k==1){
s1=1210;s2=1850;s3=2448;s4=7563;s5=700;s6=616;s7=191;s8=3120;s9=300;s10=150;
s11=808;s12=2105;s13=4010;s14=2027;s15=1168;
t1=.1;t2=.45;t3=.27;t4=.33;t5=.76;}

if(k==2){
s1=910;s2=1460;s3=1420;s4=5563;s5=770;s6=816;s7=1991;s8=1520;s9=210;s10=170;
s11=700;s12=3005;s13=5000;s14=2220;s15=1860.7;
t1=.55;t2=.24;t3=.12;t4=.18;t5=.2;}

if(k==3){
s1=990;s2=1880;s3=1748;s4=3368;s5=881;s6=1214;s7=2371;s8=1630;s9=800;s10=720;
s11=1800;s12=2505;s13=3200;s14=1820;s15=1200;
t1=.22;t2=.33;t3=.87;t4=.5;t5=.19;}

if(k==4){
s1=2212;s2=3460;s3=2448;s4=4563;s5=500;s6=7616;s7=2176;s8=1827;s9=1200;s10=115;
s11=7000;s12=4568;s13=300;s14=2120;s15=670;
t1=.15;t2=.4;t3=.28;t4=.35;t5=.8;}


else if(k==5){
s1=1898;s2=1800;s3=1468;s4=1567;s5=1720;s6=1614;s7=1800;s8=1200;s9=200;s10=120;
s11=800;s12=2005;s13=4000;s14=2020;s15=1160.5;
t1=.5;t2=.6;t3=.48;t4=.55;t5=.9;}


a:
agent();
getch();
clrscr();
switch(sela)
{
case 1:cout<<"JOHN MEHTA PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"1:GOOGLE\n\n";
       cout<<"3:ACCENTURE\n";break;

case 2:cout<<"SITA PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"2:TOYOTA MOTORS \n";
       cout<<"5:TCS\n";break;

case 3:cout<<"UNIVERSAL LTD PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"7:VIJAYA BANK\n\n";
       cout<<"4:INFOSYS\n";break;

case 4:cout<<"SHARE MASTER PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"13:WIPRO\n\n";
       cout<<"14:FEVICOL LTD\n\n";break;
case 5:cout<<"RAMESH KAMAT PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"9:SBI\n\n";
       cout<<"15:FACEBOOK\n";break;
default:cout<<"WRONG CHOICE\n";goto a;
}
cout<<"-----------------------------------------------------------\n";
sharevalue();
cin>>selc;
if(selc>=16){ cout<<"INVALID CHOICE\n"; goto a;}
//getch();
buyorsell();
k++;
if(k==5) k=0;

//getch();

/*s1=1898;s2=1800;s3=1468;s4=1567;s5=1720;s6=1614;s7=1800;s8=1200;s9=200;s10=120;
s11=800;s12=2005;s13=4000;s14=2020;s15=1160.5;
t1=.5;t2=.6;t3=.48;t4=.55;t5=.9;

agent();
int nan;
getch();
//cout<<"DO YOU WANT TO BUY OR SELL\n";
//cout<<"PRESS 1 TO BUY OR 2 TO SELL\n";
//cin>>nan;
nan=1;
if(nan==1)
{
 clrscr();
 switch(sela)
  {
     case 2:cout<<"KOTAK PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"1:RELIENCE POWER\n\n";
       cout<<"3:TECH MAHINDRA\n\n";break;

     case 4:cout<<"INDIAN BULLS PREFER THESE ARE THE BEST COMPANIES\n";
       cout<<"2:TATA INDUSTRIES \n\n";
       cout<<"5:TCS\n\n";break;

    case 1:cout<<"ASHISH MEHTA PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"7:KINGFISHER\n\n";
       cout<<"4:INFOSYS\n\n";break;


    case 5:cout<<"OSWAL PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"13:WIPRO\n\n";
       cout<<"14:INTEL\n\n";break;
    case 3:cout<<"INDIAN BULLS PREFERS THESE ARE THE BEST COMPANIES\n";
       cout<<"9:SBI\n\n";
       cout<<"15:COLGATE\n\n";break;
   default:cout<<"wrong choice";goto a;
   }
   sharevalue();
   cin>>selc;
   getch();
   buyorsell();



 }*/
  cout<<"------------------------------------------------------------------\n";
  cout<<"PRESS 1 TO CONTINUE..\nPRESS 2 TO QUIT..\n";
    cin>>ch;
 }while(ch==1);
/* else
 {
   getch();
 }*/
}
void buyorsell()
{
int i,no;
//cout<<"congarts\n";
cout<<"------------------------------------------------------------------\n";
cout<<"DO YOU WANT TO BUY OR SELL SHARES\n";
cout<<"PRESS 1 TO BUY\nPRESS 2 TO SELL\n";
cout<<"------------------------------------------------------------------\n";
cin>>i;
clrscr();
if(i==1)
{
 switch(selc)
 {
  case 1:cout<<"THE VALUE EACH SHARE IS: ";cout<<s1<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;

	 buyshare(s1,no,1);break;

  case 2:cout<<"THE VALUE EACH SHARE IS:";cout<<s2<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s2,no,2);break;
  case 3:cout<<"THE VALUE EACH SHARE IS:";cout<<s3<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s3,no,3);break;
  case 4:cout<<"THE VALUE EACH SHARE IS:";cout<<s4<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s4,no,4);break;
  case 5:cout<<"THE VALUE EACH SHARE IS:";cout<<s5<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s5,no,5);break;
   case 6:cout<<"THE VALUE EACH SHARE IS:";cout<<s6<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s6,no,6);break;
   case 7:cout<<"THE VALUE EACH SHARE IS:";cout<<s7<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s7,no,7);break;
   case 8:cout<<"THE VALUE EACH SHARE IS:";cout<<s8<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s8,no,8);break;
   case 9:cout<<"THE VALUE EACH SHARE IS:";cout<<s9<<endl;

	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s9,no,9);break;
   case 10:cout<<"THE VALUE EACH SHARE IS:";cout<<s10<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s10,no,10);break;
   case 11:cout<<"THE VALUE EACH SHARE IS:";cout<<s11<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s11,no,11);break;
   case 12:cout<<"THE VALUE EACH SHARE IS:";cout<<s12<<endl;
	   cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s12,no,12);break;
   case 13:cout<<"THE VALUE EACH SHARE IS:";cout<<s13<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s13,no,13);break;
   case 14:cout<<"THE VALUE EACH SHARE IS:";cout<<s14<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s14,no,14);break;
   case 15:cout<<"THE VALUE EACH SHARE IS:";cout<<s15<<endl;
	 cout<<"ENTER THE NO OF SHARES YOU WANT BUY\n";
	 cin>>no;
	 buyshare(s15,no,15);break;
 }
}
if(i==2)
{
switch(selc)
 {
  case 1:cout<<"THE VALUE EACH SHARE IS:";cout<<s1;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	sellshare(s1,no,1);break;

  case 2:cout<<"THE VALUE EACH SHARE IS:";cout<<s2;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s2,no,2);break;
  case 3:cout<<"THE VALUE EACH SHARE IS:";cout<<s3;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s3,no,3);break;
  case 4:cout<<"THE VALUE EACH SHARE IS:";cout<<s4;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s4,no,4);break;
  case 5:cout<<"THE VALUE EACH SHARE IS:";cout<<s5;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s5,no,5);break;
   case 6:cout<<"THE VALUE EACH SHARE IS:";cout<<s6;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s6,no,6);break;
   case 7:cout<<"THE VALUE EACH SHARE IS:";cout<<s7;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s7,no,7);break;
   case 8:cout<<"THE VALUE EACH SHARE IS:";cout<<s8;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s8,no,8);break;
   case 9:cout<<"THE VALUE EACH SHARE IS:";cout<<s9;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s9,no,9);break;
   case 10:cout<<"THE VALUE EACH SHARE IS:";cout<<s10;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s10,no,10);break;
   case 11:cout<<"THE VALUE EACH SHARE IS:";cout<<s11;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL/n";
	 cin>>no;
	 sellshare(s11,no,11);break;
   case 12:cout<<"THE VALUE EACH SHARE IS:";cout<<s12;
	   cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s12,no,12);break;
   case 13:cout<<"THE VALUE EACH SHARE IS:";cout<<s13;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s13,no,13);break;
   case 14:cout<<"THE VALUE EACH SHARE IS:";cout<<s14;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s14,no,14);break;
   case 15:cout<<"THE VALUE EACH SHARE IS:";cout<<s15;
	 cout<<"\nENTER THE NO OF SHARES YOU WANT TO SELL\n";
	 cin>>no;
	 sellshare(s15,no,15);break;
 }
}

}


 void sharevalue()
 {
 cout<<"COMPANY NAME\t                SHAREVALUE    \n";
 cout<<"------------------------------------------------------------------\n";
 cout<<"1:GOOGLE                     \t";cout<<s1;cout<<endl;
 cout<<"2:TOYOTA MOTORS              \t";cout<<s2;cout<<endl;
 cout<<"3:ACCENTURE                  \t";cout<<s3;cout<<endl;
 cout<<"4:INFOSYS                    \t";cout<<s4;cout<<endl;
 cout<<"5:TCS                        \t";cout<<s5;cout<<endl;
 cout<<"6:MINDTREE                   \t";cout<<s6;cout<<endl;
 cout<<"7:VIJAYA BANK                \t";cout<<s7;cout<<endl;
 cout<<"8:KAMAT HOTELS               \t";cout<<s8;cout<<endl;
 cout<<"9:SBI                        \t";cout<<s9;cout<<endl;
 cout<<"10:CANARA                    \t";cout<<s10;cout<<endl;
 cout<<"11:JINDAL STEEL INDUSTRIES   \t";cout<<s11;cout<<endl;
 cout<<"12:IBM                       \t";cout<<s12;cout<<endl;
 cout<<"13:WIPRO TECH                \t";cout<<s13;cout<<endl;
 cout<<"14:FEVICOL LTD               \t";cout<<s14;cout<<endl;
 cout<<"15:FACEBOOK                  \t";cout<<s15;cout<<endl;
 cout<<"------------------------------------------------------------------\n";
 cout<<"SELECT YOUR COMPANY BY PRESSING A CORRESPONDING NUMBER\n";
 cout<<"------------------------------------------------------------------\n";
 }

void buyshare(float a,int b,int m)
{
cout<<"------------------------------------------------------------------\n";
float shamt,taxamt;
shamt=a*b;
int n;
b:
if(total<shamt)
{
cout<<"PLS CHECK YOUR AMOUNT. MAY BE LOW;-(\n";
//getch();
cout<<"PLS ENTER THE SHARES AGAIN\n";
cin>>n;
shamt=a*n;
goto b;
}
total=total-shamt;
if(sela==1)
taxamt=shamt*t1/100;
if(sela==2)
taxamt=shamt*t2/100;
if(sela==3)
taxamt=shamt*t3/100;
if(sela==4)
taxamt=shamt*t4/100;
if(sela==5)
taxamt=shamt*t5/100;

total=total-taxamt;
//cout<<"------------------------------------------------------------------\n";
cout<<"\nYOUR SHARE AMOUNT:"<<shamt;
cout<<"\nYOUR TOTAL AMOUNT:"<<total;
cout<<"\n------------------------------------------------------------------\n";
pu[m]=1;
nos[m]=nos[m]+b;
}

void agent()
{
cout<<"SELECT YOUR AGENT\n";
//cout<<"------------------------------------------------------------------\n";
cout<<"AGENT NAME \t       TAX RATE\n";
cout<<"------------------------------------------------------------------\n";
cout<<"1:JOHN MEHTA      \t";cout<<t1;cout<<endl;
cout<<"2:SITA            \t";cout<<t2;cout<<endl;
cout<<"3:UNIVERSAL LTD   \t";cout<<t3;cout<<endl;
cout<<"4:SHARE MASTER    \t";cout<<t4;cout<<endl;
cout<<"5:RAMESH KAMAT    \t";cout<<t5;cout<<endl;
cout<<"------------------------------------------------------------------\n";

cin>>sela;
}


void sellshare(float p,int q,int m)
{
cout<<"------------------------------------------------------------------\n";
 if(pu[m]==1&&q<=nos[m])
 {
float amt,taxamt;
amt=p*q;
total=total+amt;

if(sela==1)
taxamt=amt*t1/100;
if(sela==2)
taxamt=amt*t2/100;
if(sela==3)
taxamt=amt*t3/100;
if(sela==4)
taxamt=amt*t4/100;
if(sela==5)
taxamt=amt*t5/100;

total=total-taxamt;

cout<<"------------------------------------------------------------------\n";
cout<<"YOUR SHARE AMOUT:"<<amt;
cout<<"\nYOUR TOTAL AMOUNT:"<<total;
cout<<"\n------------------------------------------------------------------\n";
nos[m]=nos[m]-q;
	if(nos[m]==0) pu[m]=0;
}
else cout<<"YOUR SHARES MAY BE LOW.. CAN'T SALE\n";

}


