
System.Console.WriteLine(OtN(10)); 
string OtN(int N){
     if (N==1) return "1";
     else return (N.ToString()+ " " + OtN(N-1));
}





