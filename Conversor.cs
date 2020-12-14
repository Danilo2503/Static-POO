namespace Static_POO
{
    public class Conversor
    {
        
        private static float CotacaoDolar = 5.02f;

        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReal(float valorUS){
            return CotacaoDolar * valorUS; 
        }


        private static float CotacaoEuro = 6.11f;

        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }

        public static float EuroParaReal(float valorEU){
            return CotacaoEuro * valorEU;
        }
    }
}