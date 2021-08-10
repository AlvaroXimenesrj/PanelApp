using System;

namespace Globo.ServiceApi.Dtos
{
    public class CDEEvents
    {
        public int ordem { get; set; }
        public string codigoWorkOrder { get; set; }
        public string recurso { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime datafim { get; set; }
        public string produto { get; set; }
        public string reserva { get; set; }
        public string descricao { get; set; }
        public string equipe { get; set; }
        public string equipamentos { get; set; }
        public string equipamentosExtras { get; set; }
        public string informacoes { get; set; }
        public string instrucoes { get; set; }
    }
}
