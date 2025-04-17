namespace CRUDDapper.Models
{
    public class ResponseModel<T>
    {
        // Modelo de resposta -> retorno do endpoint
        // Dados pode ser qualquer tipo genérico <T>, podendo ser nulo "?"
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;

    }
}
