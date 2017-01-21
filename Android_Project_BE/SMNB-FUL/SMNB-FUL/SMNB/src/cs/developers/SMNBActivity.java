package cs.developers;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class SMNBActivity extends Activity implements OnClickListener{
    /** Called when the activity is first created. */
	
	
	
	public static final String PREFS_NAME = "FinalSettings";
	SharedPreferences pref;
	
	public static final String PWD = "pwd";
	
	public String validpwd;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        
        Button btnlogin1=(Button)findViewById(R.id.btnlogin);
        btnlogin1.setOnClickListener(this);
        
        Button btnexit=(Button)findViewById(R.id.btnexit);
        btnexit.setOnClickListener(this);
               
    }

	@Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		
		
        if(v.getId()==R.id.btnlogin)
		{

			EditText edusn=(EditText)findViewById(R.id.edtxtusn);
	        EditText edpwd=(EditText)findViewById(R.id.edtxtpwd);
	        
	        String usn=edusn.getText().toString();
	        String pwd=edpwd.getText().toString();
	        
	        String validusn="admin";
	        SharedPreferences pref=getSharedPreferences(PREFS_NAME, 0);
			validpwd=pref.getString(PWD, "admin");
	        
	        // validpwd="admin";
	        
			if(usn.equals(validusn) && pwd.equals(validpwd) )
		        {
				 //Toast.makeText(this, "Access Granted", Toast.LENGTH_SHORT).show();
				AlertDialog.Builder grant=new AlertDialog.Builder(SMNBActivity.this);
				grant.setTitle("Congratulation..! Success");
				 grant.setMessage("Access Granted");
				 grant.setNeutralButton("Proceed", new DialogInterface.OnClickListener() {
					
					@Override
					public void onClick(DialogInterface dialog, int which) {
						// TODO Auto-generated method stub
						Intent nextwel=new Intent(SMNBActivity.this,WelcomeActivity.class);
						 startActivityForResult(nextwel, 0);	
					}
				});
				 grant.show();
				 
			
				// Intent nextwel=new Intent(SMNBActivity.this,WelcomeActivity.class);
				 //startActivityForResult(nextwel, 0);
				 //startActivity(nextwel);
		        }
			else
			{
				//Toast.makeText(this, "Access Denied", Toast.LENGTH_SHORT).show();
				AlertDialog.Builder deny=new AlertDialog.Builder(SMNBActivity.this);
				deny.setTitle("Sorry..Failed");
			    deny.setMessage("Access Denied");
			    deny.setNeutralButton("Try Again", null);
			    deny.show();    
				
			}
			
		}
        
        if(v.getId()==R.id.btnexit)
        {
        	Toast.makeText(this, "Thank you", Toast.LENGTH_SHORT).show();
        	finishActivity(0);
        	finish();
        }
		
		
	}

	public String getValidpwd() {
		return validpwd;
	}

	public void setValidpwd(String validpwd) {
		this.validpwd = validpwd;
	}
}