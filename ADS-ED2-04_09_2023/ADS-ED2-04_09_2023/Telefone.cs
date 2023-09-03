namespace ADS_ED2_04_09_2023
{
    public class Telefone
    {
        public string tipo;
        public string numero;
        public bool principal;

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string Numero
        {
            get => numero;
            set => numero = value;
        }

        public bool Principal
        {
            get => principal;
            set => principal = value;
        }
    }
}