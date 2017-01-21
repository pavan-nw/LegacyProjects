package cs.developers;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;

public class settings extends Activity implements OnClickListener
{

	public static final String PREFS_NAME = "FinalSettings";
	SharedPreferences pref;
	public static final String SER_ST = "ser_st";
	public static final String NOT_ST = "not_st";
	public static final String PWD = "pwd";
	Button btnsave,btnpwd;
	CheckBox service,notify;
	String txt1,txt2,txt3,oldpwd;
	EditText edtxt1,edtxt2,edtxt3;
	
	
	
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.settings);
		
		
		
		btnsave=(Button)findViewById(R.id.btnsave);
		btnsave.setOnClickListener(this);
		
		btnpwd=(Button)findViewById(R.id.btnchngpwd);
		btnpwd.setOnClickListener(this);
		
		service=(CheckBox)findViewById(R.id.chkbxservice);
		notify=(CheckBox)findViewById(R.id.chkbxnotify);
		
		SharedPreferences pref=getSharedPreferences(PREFS_NAME, 0);
		boolean st1=pref.getBoolean(SER_ST, true);
		boolean st2=pref.getBoolean(NOT_ST, true);
		oldpwd=pref.getString(PWD, "admin");
	    service.setChecked(st1);
	    notify.setChecked(st2);
		
	}


	@Override
	public void onClick(View v) 
	{
		// TODO Auto-generated method stub
		
		switch(v.getId())
		{
		case R.id.btnsave:
			
			SharedPreferences pref=getSharedPreferences(PREFS_NAME, 0);
			SharedPreferences.Editor ed=pref.edit();
			
			boolean ser=service.isChecked();
			boolean not=notify.isChecked();
			
			ed.putBoolean(SER_ST, ser);
			ed.putBoolean(NOT_ST, not);
			ed.commit();
			Toast.makeText(this, "Settings Saved Successfully", Toast.LENGTH_SHORT).show();
			//Toast.makeText(this, "service= "+ser, Toast.LENGTH_SHORT).show();
			//Toast.makeText(this, "notify= "+not, Toast.LENGTH_SHORT).show();
			settings.this.setResult(RESULT_OK);
			finish();
			break;
			
		case R.id.btnchngpwd:
			
			
			
			LayoutInflater inflt=LayoutInflater.from(this);
			final View txtvw = inflt.inflate(R.layout.entryview, null);
			
			edtxt1=(EditText)txtvw.findViewById(R.id.editText1);
	        edtxt2=(EditText)txtvw.findViewById(R.id.editText2);
	        edtxt3=(EditText)txtvw.findViewById(R.id.editText3);
			
			AlertDialog.Builder adb=new AlertDialog.Builder(this);
			adb.setTitle("Change Password");
			adb.setView(txtvw);
			adb.setPositiveButton("Ok", new DialogInterface.OnClickListener() {
				
				@Override
				public void onClick(DialogInterface dialog, int which) {
					// TODO Auto-generated method stub
					txt1=edtxt1.getText().toString();
					txt2=edtxt2.getText().toString();
					txt3=edtxt3.getText().toString();
					//Toast.makeText(getApplicationContext(), txt1, Toast.LENGTH_SHORT).show();
					Toast.makeText(getApplicationContext(), oldpwd, Toast.LENGTH_SHORT).show();
					if(txt1.equals(oldpwd))
					{
						if(txt2.equals(txt3))
						{
							SharedPreferences pref1=getSharedPreferences(PREFS_NAME, 0);
							SharedPreferences.Editor ed1=pref1.edit();
							ed1.putString(PWD, txt2);
							ed1.commit();
							Toast.makeText(getApplicationContext(), "Password Reset Successfully", Toast.LENGTH_SHORT).show();
						}
						else
							Toast.makeText(getApplicationContext(), "Password Mismatch", Toast.LENGTH_SHORT).show();
					}
					else
						Toast.makeText(getApplicationContext(), "Old Password incorrect", Toast.LENGTH_SHORT).show();
					
				}
			});
			
			
			adb.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
				
				@Override
				public void onClick(DialogInterface dialog, int which) {
					// TODO Auto-generated method stub
					
				}
			});
			adb.show();
			
			
		    
		}
		
	}



	@Override
	protected void onSaveInstanceState(Bundle outState) {
		// TODO Auto-generated method stub
		super.onSaveInstanceState(outState);
	}

}
