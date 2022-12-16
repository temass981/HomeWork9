System.Console.WriteLine(SumNM(1,15));

int SumNM(int m, int n){
    int sum=0;
     if (m==n) return sum+=m;
     else return sum=m+SumNM(m+1, n); 
}