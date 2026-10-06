namespace MediatrCurso.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Nome { get; set; }    

        public string Sobrenome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;
    }
}
