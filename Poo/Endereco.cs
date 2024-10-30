namespace Localizacao{
    public class Endereco{
        private string _NomeRua;
        private int _NumCasa;
        private string _Cep;
        private string _Cidade;
        private string _Estado;

        // constructor
        public Endereco(){

        }

        public Endereco(string NomeRua, int NumCasa, string Cep, string Cidade, string Estado){
            _NomeRua = NomeRua;
            _NumCasa = NumCasa;
            _Cep = Cep;
            _Cidade = Cidade;
            _Estado = Estado;
        }

        public string NomeRua{
            get{return _NomeRua;} set{_NomeRua = value;}
        }

        public int NumCasa{
            get{return _NumCasa;} set{_NumCasa = value;}
        }

        public string Cep{
            get{return _Cep;} set{_Cep = value;}
        }

        public string Cidade{
            get{return _Cidade;} set{_Cidade = value;}
        }

        public string Estado{
            get{return _Estado;} set{_Estado = value;}
        }

    }
}