
namespace vetor{
    class vet{
        static void Main(String[] args){
            int[] vet3 = new int[10];
            int i = 1;
            System.Console.WriteLine("Informe um numero: ");
            vet3[i] = int.Parse(Console.ReadLine());
            int maior = vet3[0];
            int menor = vet3[0];
            for(int v = 1; v < 10; v++){
                System.Console.WriteLine("Informe um numero: ");
                vet3[v] = int.Parse(Console.ReadLine());
                if(vet3[i] > maior){
                    maior = vet3[i];
                }else if(vet3[i] < menor){
                    menor = vet3[i];
                }
            }
            System.Console.WriteLine($"O maior numero eh: {maior}");
            System.Console.WriteLine($"O menor numero eh: {menor}");
        }
    }
}