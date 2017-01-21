package cs.developers;

import java.sql.SQLException;
import java.util.ArrayList;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.telephony.SmsMessage;
import android.util.Log;
import android.widget.Toast;

public class SmsListener extends BroadcastReceiver {

	String rplybody;
String to;
WelcomeActivity w=new WelcomeActivity();
static int flag=1;
ArrayList<String> rpls;
int i;

	@Override
	public void onReceive(Context context, Intent intent) 
	{
		// TODO Auto-generated method stub
		DbAdpter newdbadpter = new DbAdpter(context);
		
		try
		{
			newdbadpter.open();
			i=0;
			/*if(flag==1)
			{
				newdbadpter.insertAll();
				flag=0;
			}*/
				
		}
		catch (SQLException e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
			Log.d("caught: ", e.getMessage());
			
		}
				
		String ping="@get";
		 String qr1="@register";
		String qr2="@marks";
		String qr3="@timetable";
		String qr4="@event";
		String qr5="@scholarship";
		String qr6="@shortlist";
		String qr7="@help";
	   
	    
	    Bundle bnd=intent.getExtras();
		
		Object[] pds=(Object[])bnd.get("pdus");
		
		SmsMessage[] rcmsgs=new SmsMessage[pds.length];
		
		for (int i = 0; i < pds.length; i++)
		{
			rcmsgs[i]=SmsMessage.createFromPdu((byte[])pds[i]);
		}

		
	  Toast.makeText(context, "Request Recieved:"+rcmsgs[0].getMessageBody(), Toast.LENGTH_LONG).show();
	  
	  String reqmsg=rcmsgs[0].getMessageBody();
	    
	  if(reqmsg.equalsIgnoreCase(qr1))
	  {
		  //Toast.makeText(context, "you can echo", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		   
		   long st=newdbadpter.insertEntry(to);
		   
		   if(st==-1)
		   {
			   String rplybody="You are already registered or Error Occured.";
				  autorplymngr.sendTextMessage(to, null, rplybody, null, null);
		   }
		   else
		   {
		   String rplybody="Registerd Successfuly";
		  autorplymngr.sendTextMessage(to, null, rplybody, null, null);
		   }		 
	  }
	  
	  Cursor csr=newdbadpter.searchph(rcmsgs[0].getDisplayOriginatingAddress());
	  int count=csr.getCount();
	  //Toast.makeText(context, "rows= "+count, Toast.LENGTH_SHORT).show();
	if(count==1)
	{
	  
	  if(reqmsg.equalsIgnoreCase(ping))
	  {
		  //Toast.makeText(context, "you can echo", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		   
		  String rplybody="Your request recieved successfully n Sent for processing. Kindly wait";
		  autorplymngr.sendTextMessage(to, null, rplybody, null, null);
		  Toast.makeText(context, "sms sent", Toast.LENGTH_LONG).show();
			  
	  }
	  
	  else if(reqmsg.startsWith(qr2))
	  {
		  Toast.makeText(context, "Search Started", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		  rplybody="";
		   try
		   {    
			   String substr=reqmsg.substring(7);
			   Toast.makeText(context, substr, Toast.LENGTH_LONG).show(); 	   
			  Cursor c=newdbadpter.searchmarks(substr);
			  if(c.getCount()>0)
			  {
			  c.moveToFirst();
			 do 
			 {
				  rplybody =rplybody+" Sub: "+c.getString(1)+" Marks: "+c.getString(2)+"  Tot Marks: "+c.getString(3);
				  
				  
			  				 
			} while (c.moveToNext());
			  }
			  else rplybody="No Records Found against this USN";
			   //String rplybody=c.getString(0)+" "+c.getString(1)+" "+c.getString(2)+" "+c.getString(3);
			   Toast.makeText(context, rplybody, Toast.LENGTH_LONG).show();
			   rpls=autorplymngr.divideMessage(rplybody);
			   while(i<rpls.size())
				  autorplymngr.sendTextMessage(to, null, rpls.get(i++), null, null);
				  
		   }
		   catch(Exception ex)
		   {
			   Toast.makeText(context, "Cought : "+ex.getMessage(), Toast.LENGTH_LONG).show(); 
		   }  
	  }
	  
	  else if(reqmsg.startsWith(qr3))
	  {
		  Toast.makeText(context, "Search Started", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		  rplybody="";
		   try
		   {    
			   int sem=Integer.parseInt(reqmsg.substring(11, 12));
			   String div=reqmsg.substring(13, 14);
			   String day=reqmsg.substring(15);
			   Toast.makeText(context, sem+div+day, Toast.LENGTH_LONG).show(); 	   
			  Cursor c=newdbadpter.searchtt(day, sem, div);
			  c.moveToFirst();
			  if(c.getCount()>0)
			  {
			 do 
			 {
				  rplybody =rplybody+" Day: "+c.getString(0)+"\nP1: "+c.getString(1)+"\nP2: "+c.getString(2)+"\nP3: "+c.getString(3)+"\nP4: "+c.getString(4)+"\nP5: "+c.getString(5);
			  				 
			} while (c.moveToNext());
			  }
			  else rplybody="No Records Found";
			 
			   //String rplybody=c.getString(0)+" "+c.getString(1)+" "+c.getString(2)+" "+c.getString(3);
			   Toast.makeText(context, rplybody, Toast.LENGTH_LONG).show();
			   rpls=autorplymngr.divideMessage(rplybody);
			   while(i<rpls.size())
				  autorplymngr.sendTextMessage(to, null, rpls.get(i++), null, null);
				  
		   }
		   catch(Exception ex)
		   {
			   Toast.makeText(context, "Cought : "+ex.getMessage(), Toast.LENGTH_LONG).show(); 
		   }  
	  }
	  
	  else if(reqmsg.equalsIgnoreCase(qr4))
	  {
		  Toast.makeText(context, "Search Started", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		  rplybody="";
		   try
		   {    
			  // String substr=reqmsg.substring(7);
			   //Toast.makeText(context, substr, Toast.LENGTH_LONG).show(); 	   
			  Cursor c=newdbadpter.searchevents();
			  int nrows=c.getCount();
			  c.moveToPosition(nrows-3);
			  if(c.getCount()>0)
			  {
			 do 
			 {
				  rplybody =rplybody+" From: "+c.getString(0)+" To: "+c.getString(1)+" Details :"+c.getString(2)+"\n";
			  				 
			} while (c.moveToNext());
			  }
			  else rplybody="No Records Found";
			 
			   //String rplybody=c.getString(0)+" "+c.getString(1)+" "+c.getString(2)+" "+c.getString(3);
			   Toast.makeText(context, rplybody, Toast.LENGTH_LONG).show();
			   rpls=autorplymngr.divideMessage(rplybody);
			   while(i<rpls.size())
				  autorplymngr.sendTextMessage(to, null, rpls.get(i++), null, null);
		   }
		   catch(Exception ex)
		   {
			   Toast.makeText(context, "Cought : "+ex.getMessage(), Toast.LENGTH_LONG).show(); 
		   }  
	  }
	  
	  
	  else if(reqmsg.startsWith(qr5))
	  {
		  Toast.makeText(context, "Search Started", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		  rplybody="";
		   try
		   {    
			   String substr=reqmsg.substring(13);
			   Toast.makeText(context, substr, Toast.LENGTH_LONG).show(); 	   
			  Cursor c=newdbadpter.searchscholarship(substr);
			  c.moveToFirst();
			  if(c.getCount()>0)
			  {
			 do 
			 {
				  rplybody =rplybody+" Amount: "+c.getString(1)+" Details: "+c.getString(2)+"\n";
			  				 
			} while (c.moveToNext());
			  }
			  else rplybody="No Records Found against this USN";
			   //String rplybody=c.getString(0)+" "+c.getString(1)+" "+c.getString(2)+" "+c.getString(3);
			   Toast.makeText(context, rplybody, Toast.LENGTH_LONG).show();
			   rpls=autorplymngr.divideMessage(rplybody);
			   while(i<rpls.size())
				  autorplymngr.sendTextMessage(to, null, rpls.get(i++), null, null);
				  
		   }
		   catch(Exception ex)
		   {
			   Toast.makeText(context, "Cought : "+ex.getMessage(), Toast.LENGTH_LONG).show(); 
		   }  
	  }
	  
	  else if(reqmsg.startsWith(qr6))
	  {
		  Toast.makeText(context, "Search Started", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		  rplybody="";
		   try
		   {    
			   String substr=reqmsg.substring(11);
			   Toast.makeText(context, substr, Toast.LENGTH_LONG).show(); 	   
			  Cursor c=newdbadpter.searchshort(substr);
			  c.moveToFirst();
			  if(c.getCount()>0)
			  {
			 do 
			 {
				  rplybody =rplybody+" Cls atnded: "+c.getString(1)+" Tot clses: "+c.getString(2)+" Sub :"+c.getString(3)+"\n";
			  				 
			} while (c.moveToNext());
			  }else rplybody="No Records Found against this USN";
			   //String rplybody=c.getString(0)+" "+c.getString(1)+" "+c.getString(2)+" "+c.getString(3);
			   Toast.makeText(context, rplybody, Toast.LENGTH_LONG).show();
			   rpls=autorplymngr.divideMessage(rplybody);
			   while(i<rpls.size())
				  autorplymngr.sendTextMessage(to, null, rpls.get(i++), null, null);
				 
		   }
		   catch(Exception ex)
		   {
			   Toast.makeText(context, "Cought : "+ex.getMessage(), Toast.LENGTH_LONG).show(); 
		   }  
	  }
	  else if(reqmsg.equalsIgnoreCase(qr7))
	  {
		  Toast.makeText(context, "Search Started", Toast.LENGTH_LONG).show();
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		  rplybody="Requesting formats are:\n" +
		  		"@register\n@marks <usn>\n@timetable <sem> <div> <day>\n@event\n@scholarship <usn>\n@shortlist <usn>";
		  
		  
		  autorplymngr.sendTextMessage(to, null, rplybody, null, null);
	  }
	  else if(reqmsg.startsWith("@"))
	  {
		  if(reqmsg.equalsIgnoreCase(qr1))
		  {  }
		  else
		  {
		  SmsManager autorplymngr=SmsManager.getDefault();
		   to=rcmsgs[0].getDisplayOriginatingAddress();
		   rplybody="Invalid Keyword Format\n@help to get list of commands";
		  autorplymngr.sendTextMessage(to, null, rplybody, null, null);}
	  }  
   
	}
	else if(count==0)
	{
		
		if(reqmsg.startsWith("@"))
		{
		SmsManager autorplymngr=SmsManager.getDefault();
		String rplybody="You have not registered to service yet\n@register to register for service";
		to=rcmsgs[0].getDisplayOriginatingAddress();
		autorplymngr.sendTextMessage(to, null, rplybody, null, null);
		}
	
	
	}
		
		
	}

}
