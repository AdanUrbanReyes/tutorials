import java.io.File;
import java.io.InputStream;
import java.io.FileInputStream;
import java.security.MessageDigest;
public class MD5{
    public static byte[] createChecksum(String filename){
        try{
            InputStream fis =  new FileInputStream(filename);
            byte[] buffer = new byte[1024];
            MessageDigest complete = MessageDigest.getInstance("MD5");
            int numRead;
            do {
                numRead = fis.read(buffer);
                if (numRead > 0) {
                    complete.update(buffer, 0, numRead);
                }
            } while (numRead != -1);
            fis.close();
            return complete.digest();
        }catch(Exception e){
            System.out.print("\nerror in create createChecksum "+e.toString());
            e.printStackTrace();
        }
        return null;
    }
    public static String getMD5Checksum(String filename){
        byte[] b = createChecksum(filename);
        String result = "";
        for (int i = 0; i < b.length; i++) {
            result += Integer.toString((b[i] & 0xff) + 0x100, 16).substring(1);
        }
        return result;
    }	
   public static void main(String []args){
		System.out.print("MD5Checsum = |"+getMD5Checksum(args[0])+"|\n");		
	}
}
