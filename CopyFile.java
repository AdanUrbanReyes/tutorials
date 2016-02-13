public class CopyFile{
	public java.io.File file;
	public Runnable writeFile=new Runnable(){
		public void run(){
			;
		}	
	};
	public CopyFile(){
		;
	}
	public static java.util.LinkedList<long[]> getLimits(long sizeofFile,int numberServers){
		long bytesRepartidos=sizeofFile/numberServers;//siempre lo recorta acia avajo ejemplo 2.5 a 2 , 3.9 a 3
		int i;
		long lu=0,ld=0;
		java.util.LinkedList<long[]> reparto=new java.util.LinkedList<long[]>();
		for(i=1;i<=numberServers;i++,ld+=bytesRepartidos+1){
			lu=ld+bytesRepartidos;
			if(lu>sizeofFile)
				lu=sizeofFile;
			reparto.add(new long[]{ld,lu});
		}
		return reparto;	
	}
	public static void main(String []args){
		java.io.File fileForCopy=new java.io.File("/home/ayan/adoo/imagenesPharmacy/actron200.jpg");
		java.util.LinkedList <long[]> limits=getLimits(fileForCopy.length(),3);
		int i;
		long []limitsl;
		for(i=0;i<limits.size();i++){
			limitsl=limits.get(i);
			System.out.print("\nseversocket "+i+" le toco  de "+limitsl[0]+"-"+limitsl[1]);
		}
		//byte []partOne=
		//java.io.BufferedInputStream bis=new BufferedInputStream(new java.io.FileInputStream(file.getAbsolutePath()));
		//bis.skip();
		// while((leidos=bis.read(bufer,0,bufer.length))!=-1)
	}
}
