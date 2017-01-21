package cs.developers;
import java.sql.SQLException;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteDatabase.CursorFactory;
import android.database.sqlite.SQLiteOpenHelper;
import android.os.Environment;
import android.widget.Toast;

public class DbAdpter {

	public static int f=1;
	private static final String DATABASE_NAME="/smnb1.db";
	private static final String DATABASE_TABLE1="register";
	private static final String DATABASE_TABLE2="markslist";
	private static final String DATABASE_TABLE3="timetable";
	private static final String DATABASE_TABLE4="events";
	private static final String DATABASE_TABLE5="scholarship";
	private static final String DATABASE_TABLE6="shortlist";
	
	private static final int DATABASE_VERSION = 1;
	
	// The index (key) column name for use in where clauses.
	//public static final String KEY_ID="_id";
	
	// The name and column index of each column in your database.
	public static final String KEY_PH="ph";
	
	public static final String USN="usn";
	public static final String SUBNAME="sub_name";
	public static final String OBTMRK="obtainedmarks";
	public static final String TOTMRK="totalmarks";
	
	public static final String DAY="day";
	public static final String P1="P1";
	public static final String P2="P2";
	public static final String P3="P3";
	public static final String P4="P4";
	public static final String P5="P5";
	public static final String SEM="sem";
	public static final String DIV="div";
	
	public static final String FRMDT="from_date";
	public static final String TODT="to_date";
	public static final String DETAILS="details";
	
	public static final String AMT="amount";
	
	public static final String ATTND="attendence";
	public static final String TOTATTND="totalattnd";
	
	
	
	//public static final String KEY_NAME="name";
	//public static final int NAME_COLUMN = 1;
	
	// TODO: Create public field for each column in your table.
	// SQL Statement to create a new database.
	public static final String DATABASE_CREATE1 = "create table " +
	DATABASE_TABLE1 + " (" + KEY_PH +
	" integer primary key);";
	
	public static final String DATABASE_CREATE2 = "create table " +
			DATABASE_TABLE2 + " (" + USN +
			" text , " + SUBNAME + " text, " + OBTMRK + " text, " + TOTMRK + " text);";
	
	public static final String DATABASE_CREATE3 = "create table " +
			DATABASE_TABLE3 + " (" + DAY +
			" text, " + P1 + " text, " + P2 + " text, " + P3 + " text, " + P4 + " text, " + P5 + " text, " + SEM + " integer, " + DIV + " text );";
	
	public static final String DATABASE_CREATE4 = "create table " +
			DATABASE_TABLE4 + " (" + FRMDT +
			" text, " + TODT + " text, " + DETAILS + " text);";
	
	public static final String DATABASE_CREATE5 = "create table " +
			DATABASE_TABLE5 + " (" + USN +
			" text , " + AMT + " integer, " + DETAILS + " text );";
	
	public static final String DATABASE_CREATE6 = "create table " +
			DATABASE_TABLE6 + " (" + USN +
			" text , " + ATTND + " integer, " + TOTATTND + " integer, " + SUBNAME + " text  );";
	
	
	String path=Environment.getExternalStorageDirectory().getAbsolutePath()+DATABASE_NAME;
	
	// Variable to hold the database instance
	private SQLiteDatabase db;
	private final Context context;
	//private myDbHelper dbHelper;
	
	public DbAdpter(Context _context)
	{
		context = _context;
		//dbHelper = new myDbHelper(context, DATABASE_NAME, null, DATABASE_VERSION);
	}
	
	public DbAdpter open() throws SQLException
	{
		//db = dbHelper.getWritableDatabase();
		try{
			
			
			
			//Toast.makeText(context, path, Toast.LENGTH_SHORT).show();
			//db=SQLiteDatabase.openDatabase(path, null, SQLiteDatabase.OPEN_READWRITE+SQLiteDatabase.CREATE_IF_NECESSARY);
			db=SQLiteDatabase.openOrCreateDatabase(path, null);
			
			if(f==1){
			  db.execSQL(DATABASE_CREATE1); 
			  db.execSQL(DATABASE_CREATE2);
				db.execSQL(DATABASE_CREATE3);
				db.execSQL(DATABASE_CREATE4);
				db.execSQL(DATABASE_CREATE5);
				db.execSQL(DATABASE_CREATE6);	  
			  f=0;
			  }
		   //Toast.makeText(context, "Ok Done", Toast.LENGTH_SHORT).show();
			}
			catch(SQLiteException e)
			{
			//	Toast.makeText(context, e.getMessage(), Toast.LENGTH_SHORT).show();
			}
		
		
		return this;
	}
	
	public void close()
	{
		db.close();
	}
		
	public long insertEntry(String ph)
	{
		// TODO: Create a new ContentValues to represent my row
		// and insert it into the database.
		
		ContentValues newvalues= new ContentValues();
		
		//newvalues.put(KEY_ID, i);
		newvalues.put(KEY_PH, ph);
		//newvalues.put(KEY_NAME, name);
		long status=db.insert(DATABASE_TABLE1, null, newvalues);
		
		return status;
		
		}
	/*public long insertAll()
	{
		// TODO: Create a new ContentValues to represent my row
		// and insert it into the database.
		
		ContentValues newvalues1= new ContentValues();
		ContentValues newvalues2= new ContentValues();
		ContentValues newvalues3= new ContentValues();
		ContentValues newvalues4= new ContentValues();
		ContentValues newvalues5= new ContentValues();
		ContentValues newvalues6= new ContentValues();
		
		//newvalues.put(KEY_ID, i);
		newvalues1.put(USN, "2ba08cs100");
		newvalues1.put(SUBNAME, "aca");
		newvalues1.put(OBTMRK, "13");
		newvalues1.put(TOTMRK,"15");
		//newvalues.put(KEY_NAME, name);
		long status1=db.insert(DATABASE_TABLE2, null, newvalues1);
		
		newvalues2.put(USN, "2ba08cs101");
		newvalues2.put(AMT, 1000);
		newvalues2.put(DETAILS,"Vidyaposhak");	
		//newvalues.put(KEY_NAME, name);
		long status2=db.insert(DATABASE_TABLE5, null, newvalues2);
		
		
		newvalues3.put(USN, "2ba08cs102");
		newvalues3.put(ATTND,"3");
		newvalues3.put(TOTATTND,"12");
		newvalues3.put(SUBNAME, "mc");
		//newvalues.put(KEY_NAME, name);
		long status3=db.insert(DATABASE_TABLE6, null, newvalues3);
		
		newvalues4.put(DAY,"mon");
		newvalues4.put(P1,"aca(9am-10am)");
		newvalues4.put(P2, "mc(10.15am-11.15am)");
		newvalues4.put(P3,"st(11.15am-12.15am)");
		newvalues4.put(P4, "-");
		newvalues4.put(P5,"-");
		newvalues4.put(SEM, 8);
		newvalues4.put(DIV, "b");
		
		long status4=db.insert(DATABASE_TABLE3, null, newvalues4);
		
		
		return status1;
		
		}*/
	
	/*public boolean removeEntry(long _rowIndex)
	{
		return db.delete(DATABASE_TABLE, KEY_ID + "=" + _rowIndex, null) > 0;
	}*/
	
	public Cursor getAllEntries ()
	{
		return db.query(DATABASE_TABLE1, new String[] {KEY_PH},	null, null, null, null, null);
	}
	
	//public MyObject getEntry(long _rowIndex) {
		// TODO: Return a cursor to a row from the database and
		// use the values to populate an instance of MyObject
		//return objectInstance;
		//}
		
	public Cursor searchph(String ph)
	{
	String where=KEY_PH+"="+ph;
	return db.query(DATABASE_TABLE1, new String[] {KEY_PH},where, null, null, null, null);
	}
	public Cursor searchmarks(String marks)
	{
	String where=USN+"='"+marks+"'";
	return db.query(DATABASE_TABLE2,null,where, null, null, null, null);
	}
	
	
	public Cursor searchtt(String day,int sem, String div)
	{
		String where=SEM+"="+sem+" and "+DIV+"='"+div+"' and "+DAY+"='"+day+"'";
	 return db.query(DATABASE_TABLE3, null,where, null, null, null, null);
	}
	public Cursor searchevents()
	{
		//String where=DAY+"='"+day+"'";
	 return db.query(DATABASE_TABLE4, null,null, null, null, null, null);
	}
	public Cursor searchscholarship(String usn)
	{
		String where=USN+"='"+usn+"'";
	 return db.query(DATABASE_TABLE5, null,where, null, null, null, null);
	}
	
	public Cursor searchshort(String usn)
	{
		String where=USN+"='"+usn+"'";
	 return db.query(DATABASE_TABLE6, null,where, null, null, null, null);
	}
	
	public boolean updateEntry(long _rowIndex)
	{
		// TODO: Create a new ContentValues based on the new object
		// and use it to update a row in the database.
		return true;
	}
	
	
	
	
	//////New Class....................
	
	/*private static class myDbHelper extends SQLiteOpenHelper
	{

		public myDbHelper(Context context, String name, CursorFactory factory,
				int version) 
		{
			super(context, name, factory, version);
			// TODO Auto-generated constructor stub
		}

		@Override
		public void onCreate(SQLiteDatabase db) 
		{
			// TODO Auto-generated method stub
			db.execSQL(DATABASE_CREATE1);
			db.execSQL(DATABASE_CREATE2);
			db.execSQL(DATABASE_CREATE3);
			db.execSQL(DATABASE_CREATE4);
			db.execSQL(DATABASE_CREATE5);
			db.execSQL(DATABASE_CREATE6);
			
			
		}

		
		@Override
		public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) 
		{
			// TODO Auto-generated method stub
			
		}
		
	}*/
	
	
	
}