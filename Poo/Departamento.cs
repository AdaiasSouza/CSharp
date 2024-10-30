namespace DepartamentoInfor{
    public class Departamento{
        // atributes
        private string _NomeDepartamento;
        private int _CodigoDepartamento;
        private int _NumBloco;
        private int _NumAndar;
        private int _NumPredio;

        // constructor
        public Departamento(){
            Console.WriteLine("Iniciando...");

        }

        public Departamento(string NomeDepartamento, int CodigoDepartamento, int NumBloco, int NumAndar, int NumPredio){
            _NomeDepartamento = NomeDepartamento;
            _CodigoDepartamento = CodigoDepartamento;
            _NumBloco = NumBloco;
            _NumAndar = NumAndar;
            _NumPredio = NumPredio;

        }

        // set, get
        // methods

    }
}