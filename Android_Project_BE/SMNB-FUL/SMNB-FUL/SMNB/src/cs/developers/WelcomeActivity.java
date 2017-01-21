/**
 * 
 */
package cs.developers;

import java.sql.SQLException;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.Toast;


/**
 * @author PAVAN
 *
 */
public class WelcomeActivity extends Activity implements OnClickListener
{
	
	public static final String PREFS_NAME = "FinalSettings";
	SharedPreferences pref;
	public static final String SER_ST = "ser_st";
	public static final String NOT_ST = "not_st";
	SmsListener receiver;
	IntentFilter intflt;
	
	/*DbAdpter newdbadpter = new DbAdpter(this);
	SmsListener s=new SmsListener();*/
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.welcome);
		
		Button btnsendnotify=(Button)findViewById(R.id.btnnotify);
		btnsendnotify.setOnClickListener(this);
		
		Button btnopt=(Button)findViewById(R.id.btnoption);
		btnopt.setOnClickListener(this);
		
		Button btnmin=(Button)findViewById(R.id.btnminimize);
		btnmin.setOnClickListener(this);
		
		
		 receiver=new SmsListener();
		 intflt=new IntentFilter();
		intflt.addAction("android.provider.Telephony.SMS_RECEIVED");
		registerReceiver(receiver, intflt);
		Toast.makeText(this, "Listening started", Toast.LENGTH_SHORT).show();
		
		
		/*try
		{
			newdbadpter.open();
			Toast.makeText(this, "Db Opened", Toast.LENGTH_SHORT).show();
			
			//String x=s.to;
			//newdbadpter.insertEntry(x);
			
		}
		catch (SQLException e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
			Log.d("caught: ", e.getMessage());
			
		}
	}
	
	public void ins(String to) 
	{
		newdbadpter.insertEntry(to);
	}*/
	}
	
		@Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		
			final String lst[]={"Settings","About-us"};
			
		switch(v.getId())
		{
		case R.id.btnnotify: 
			 pref=getSharedPreferences(PREFS_NAME, 0);
			boolean st2=pref.getBoolean(NOT_ST, true);
			//Toast.makeText(this, "Notification="+st2, Toast.LENGTH_SHORT).show();
			if(st2==true)
			{
			Intent sendnotifyintent=new Intent(WelcomeActivity.this,SendNotifyActivity.class);
			startActivityForResult(sendnotifyintent, 0);
			}
			else
			{
				Toast.makeText(this, "Disabled By Admin", Toast.LENGTH_SHORT).show();
			}
			break;
		case R.id.btnoption:
			AlertDialog.Builder ad=new AlertDialog.Builder(WelcomeActivity.this);
			ad.setTitle("Options");
			ad.setItems(lst, new DialogInterface.OnClickListener() {
				
				@Override
				public void onClick(DialogInterface dialog, int which) {
					// TODO Auto-generated method stub
					switch(which)
					{
					case 0:
						Intent settingsintent=new Intent(WelcomeActivity.this,settings.class);
						startActivityForResult(settingsintent, 0);
						break;
					case 1:
						AlertDialog.Builder d3=new AlertDialog.Builder(WelcomeActivity.this);
						d3.setTitle("About-us");
						d3.setMessage("CS Developers, Dept of CSE, BEC-Bagalkot");
						d3.setNeutralButton("OK", null);
                    //d3.setMessage("You selected: " + which + " , " + lst[which]);
                    d3.show();
					break;
					
					}
				}
			});
			ad.show();			
			break;
		case R.id.btnminimize: Intent minimize=new Intent(Intent.ACTION_MAIN);
							minimize.addCategory(Intent.CATEGORY_HOME);
							startActivity(minimize);
							break;
			
		}
		
	}

		@Override
		protected void onRestart() {
			// TODO Auto-generated method stub
			super.onRestart();
			pref=getSharedPreferences(PREFS_NAME, 0);
			boolean st2=pref.getBoolean(SER_ST, true);
			try{
				if(st2==false)
				{
			  unregisterReceiver(receiver);
				Toast.makeText(this, "Listening Stopped", Toast.LENGTH_SHORT).show();
				}
				else
				{
					registerReceiver(receiver, intflt);
					Toast.makeText(this, "Listening started", Toast.LENGTH_SHORT).show();
				}
			}
			catch(Exception e)
			{
				//Toast.makeText(this, e.getMessage(), Toast.LENGTH_SHORT).show();
			}
			
			
		}
	


}
