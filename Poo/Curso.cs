namespace CursoSuperior{
    public class Curso{
        // atributes
        private string _NomeCurso;
        private string _Centro;
        private int _CodigoCurso;
        private string _Periodo;

        // constructor
        public Curso(){
            Console.WriteLine("Iniciando...");

        }

        public Curso(string NomeCurso, string Centro, int CodigoCurso, string Periodo){
            _NomeCurso = NomeCurso;
            _Centro = Centro;
            _CodigoCurso = CodigoCurso;
            _Periodo = Periodo;
        }
        // methods
        public string NomeCurso{
            get{return _NomeCurso;}
            set{_NomeCurso = value;}
        }

        public string Centro{
            get{return _Centro;}
            set{_Centro = value;}
        }

        public int CodigoCurso{
            get{return _CodigoCurso;}
            set{_CodigoCurso = value;}
        }

        public string Periodo{
            get{return _Periodo;}
            set{_Periodo = value;}
        }
    }
}