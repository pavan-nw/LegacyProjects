package cs.developers;

import java.util.ArrayList;

import android.app.Activity;
import android.database.Cursor;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class SendNotifyActivity extends Activity implements OnClickListener {
	
	DbAdpter  dbhandler=new DbAdpter(this);
	int nomsgs;
	ArrayList<String> lstmsg;
	
	protected void onCreate(Bundle saved)
	{
		super.onCreate(saved);
		setContentView(R.layout.sendnotification);
		
		Button btnsend=(Button)findViewById(R.id.btnsendnotification);
		btnsend.setOnClickListener(this);
		
		
		
	}

	@Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		EditText edmsg=(EditText)findViewById(R.id.ednotifymsg);
		
		
		if(v.getId()==R.id.btnsendnotification)
		{
			String msg=edmsg.getText().toString();
			
			
			if(msg.length()==0)
			{ 
				Toast.makeText(this, "Invalid Data or Empty Data", Toast.LENGTH_SHORT).show();
			
			}
			
			else
			{	
				try
				{
				
			//SmsManager mymngr=SmsManager.getDefault();
			
			dbhandler.open();
			Cursor cr=dbhandler.getAllEntries();
			
			/*for (int i = 0; i < 3; i++) 
			{
				
				String phn=cr.getString(0);
				Toast.makeText(this, "sent to "+phn+" "+i+" time", Toast.LENGTH_SHORT).show();
				mymngr.sendTextMessage(phn, null, msg, null, null);
				Thread.sleep(5000, 0);
				
			}*/
			
			while(cr.moveToNext())
			 { 
				int i=0;
				String phn=cr.getString(0);
				Toast.makeText(this, phn, Toast.LENGTH_LONG).show();
				SmsManager mymngr=SmsManager.getDefault();
				lstmsg=mymngr.divideMessage(msg);
				while(i<lstmsg.size())
				{
				Toast.makeText(this, lstmsg.get(i), Toast.LENGTH_LONG).show();
				
				mymngr.sendTextMessage(phn, null, lstmsg.get(i), null, null);
				
				Toast.makeText(this, "sms sent", Toast.LENGTH_LONG).show();
				i++;
				}
				//Thread.sleep(3000, 0);	
			 }
			}
			catch (Exception e) 
			{
				// TODO: handle exception
				Toast.makeText(this, e.getMessage(), Toast.LENGTH_LONG).show();
			}
	
			
			
			
			
			}
		}
		
	}

}
