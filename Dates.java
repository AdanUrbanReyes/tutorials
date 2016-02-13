import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;
public class Dates{
	public static Calendar expiration;
    public static String getExpirationWithFormat(String format){
        SimpleDateFormat formatCalendar=new SimpleDateFormat(format);
        if(expiration!=null){
            return formatCalendar.format(expiration.getTime());
        }else{
            Calendar auxiliary=GregorianCalendar.getInstance();
				auxiliary.set(1,Calendar.JANUARY,1);
				System.out.print("in else\n");
            return formatCalendar.format(auxiliary.getTime());
        }
    }
	public static void main(String []args){
		System.out.print("expiration="+getExpirationWithFormat("yyyy-MM-dd"));
	}
}
